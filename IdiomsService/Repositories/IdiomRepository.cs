﻿using IdiomsService.Database;
using IdiomsService.Protos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using IdiomsService.ExtensionMethods;
using IdiomsService.Database.Models;

namespace IdiomsService.Repositories
{
    public class IdiomRepository : IIdiomRepository
    {
        private readonly Context _db;

        public IdiomRepository(Context db)
        {
            _db = db;
        }

        public async Task<GetIdiomInfoReply> GetIdiomInfo(int idiomId, int currentUserId)
        {
            var result = await _db.Idioms.Where(x => x.IdiomId == idiomId).Select(i =>
                          new GetIdiomInfoReply
                          {
                              IdiomId = i.IdiomId,
                              DateAdded = Timestamp.FromDateTime(i.DateAdded.ToUniversalTime()),
                              DateModified = Timestamp.FromDateTime(i.DateChanged.ToUniversalTime()),
                              Text = i.Text,
                              Meaning = i.Meaning,
                              Usage = i.Usage,
                              FavoritesCount = _db.Favorites.Where(x => x.IdiomId == idiomId).Count(),
                              UpvoteCount = _db.Upvotes.Where(x => x.IdiomId == idiomId && x.IsUpvote).Count() -
                                            _db.Upvotes.Where(x => x.IdiomId == idiomId && !x.IsUpvote).Count(),
                              Language = i.Language.ToReply(),
                              User = i.User.ToReply(),
                              IsFavorite = _db.Favorites.Any(x => x.IdiomId == idiomId && x.UserId == currentUserId),
                              IsUserUpvoted = _db.Upvotes.Any(x => x.IdiomId == idiomId && x.UserId == currentUserId),
                              IsUpvote = _db.Upvotes.Where(x => x.IdiomId == idiomId && x.UserId == currentUserId).Select(x => x.IsUpvote).FirstOrDefault()
                          }).AsNoTracking().FirstOrDefaultAsync();
            result.Comments.AddRange(await _db.Comments.Where(x => x.IdiomId == idiomId)
                                                  .Include(x => x.User)
                                                  .Include(x => x.CommentLikes)
                                                  .Select(x => x.ToReply(currentUserId))
                                                  .AsNoTracking()
                                                  .ToListAsync());
            result.Translations.AddRange(await _db.Links.Where(x => x.LinkTypeId == (int)LinkTypes.Translation && (x.RootId == idiomId || x.LinkId == idiomId))
                .Select(x => new IdiomLinkReply
                {
                    IdiomId = x.RootId == idiomId ? x.RelatedId : x.RootId,
                    Language = x.RootId == idiomId ? x.Related.Language.ToReply() : x.Root.Language.ToReply()
                }).AsNoTracking()
                .ToListAsync());
            result.Similar.AddRange(await _db.Links.Where(x => x.LinkTypeId == (int)LinkTypes.Similar && (x.RootId == idiomId || x.LinkId == idiomId))
                .Select(x => new IdiomLinkReply
                {
                    IdiomId = x.RootId == idiomId ? x.RelatedId : x.RootId,
                    Language = x.RootId == idiomId ? x.Related.Language.ToReply() : x.Root.Language.ToReply()
                }).AsNoTracking()
                .ToListAsync());
            return result;
        }

        public async Task<IEnumerable<IdiomReply>> GetIdiomList(int skip, int count, int currentUserId)
        {
            return await _db.Idioms.Select(i => new IdiomReply
            {
                IdiomId = i.IdiomId,
                DateAdded = Timestamp.FromDateTime(i.DateAdded.ToUniversalTime()),
                Text = i.Text,
                FavoritesCount = _db.Favorites.Where(x => x.IdiomId == i.IdiomId).Count(),
                UpvoteCount = _db.Upvotes.Where(x => x.IdiomId == i.IdiomId && x.IsUpvote).Count() -
                                            _db.Upvotes.Where(x => x.IdiomId == i.IdiomId && !x.IsUpvote).Count(),
                Language = i.Language.ToReply(),
                User = i.User.ToReply(),
                IsFavorite = _db.Favorites.Any(x => x.IdiomId == i.IdiomId && x.UserId == currentUserId)
            }).Skip(skip).Take(count).AsNoTracking().ToListAsync();
        }

        public async Task<bool> AddIdiom(Database.Models.Idiom idiom)
        {
            if (!await _db.Idioms.AnyAsync(x => x.Text == idiom.Text))
            {
                idiom.DateAdded = DateTime.UtcNow;
                _db.Idioms.Add(idiom);
                await _db.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteIdiom(int idiomId)
        {
            var idiom = await _db.Idioms.FirstOrDefaultAsync(x => x.IdiomId == idiomId);
            if (idiom != null)
            {
                _db.Upvotes.RemoveRange(_db.Upvotes.Where(x => x.IdiomId == idiomId));
                _db.Comments.RemoveRange(_db.Comments.Where(x => x.IdiomId == idiomId));
                _db.Favorites.RemoveRange(_db.Favorites.Where(x => x.IdiomId == idiomId));
                _db.Idioms.Remove(idiom);
                await _db.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> ChangeIdiom(int idiomId, string text, string meaning, string usage, int languageId)
        {
            var oldIdiom = await _db.Idioms.FirstOrDefaultAsync(x => x.IdiomId == idiomId);
            if (oldIdiom != null)
            {
                oldIdiom.DateChanged = DateTime.UtcNow;
                oldIdiom.Text = text ?? oldIdiom.Text;
                oldIdiom.Meaning = meaning ?? oldIdiom.Meaning;
                oldIdiom.Usage = usage ?? oldIdiom.Usage;
                oldIdiom.LanguageId = languageId != 0 ? languageId : oldIdiom.LanguageId;
                _db.Idioms.Update(oldIdiom);
                await _db.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<IdiomLinkReply> AddIdiomLink(int currentIdiomId, int linkIdiomId, int linkTypeId, int currentUserId)
        {
            if (!await _db.Idioms.AnyAsync(x => x.IdiomId == currentIdiomId) ||
                !await _db.Idioms.AnyAsync(x => x.IdiomId == linkIdiomId) ||
                !System.Enum.IsDefined(typeof(LinkTypes), linkTypeId))
            {
                return null;
            }

            _db.Links.Add(new Link { RootId = currentIdiomId, RelatedId = linkIdiomId, LinkTypeId = linkTypeId });
            await _db.SaveChangesAsync();
            var language = await _db.Idioms.Where(x => x.IdiomId == linkIdiomId).Select(x => x.Language.ToReply()).AsNoTracking().FirstOrDefaultAsync();
            return new IdiomLinkReply { IdiomId = linkIdiomId, Language = language };
        }

        public async Task AddLinksBatch(IEnumerable<Link> links)
        {
            _db.Links.AddRange(links);
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<IdiomReply>> FastSearch(string name)
        {
            var number = 3;
            return await _db.Idioms.Where(x => EF.Functions.FuzzyStringMatchLevenshteinLessEqual(name.ToLower(), x.Text.ToLower(), number) <= number || x.Text.ToLower().Contains(name.ToLower())).Select(x => new IdiomReply
            {
                IdiomId = x.IdiomId,
                Text = x.Text,
                Language = x.Language.ToReply(),
            }).Take(50).AsNoTracking().ToListAsync();
        }
    }
}
