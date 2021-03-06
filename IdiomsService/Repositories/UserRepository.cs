using Google.Protobuf.WellKnownTypes;
using IdiomsService.Database;
using IdiomsService.Database.Models;
using IdiomsService.ExtensionMethods;
using IdiomsService.Protos;
using IdiomsService.Security;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdiomsService.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly Context _db;

        public UserRepository(Context db)
        {
            _db = db;
        }

        public async Task<bool> AddUserLanguage(int languageId, int userId)
        {
            if (!await _db.UserLanguages.AnyAsync(x => x.LanguageId == languageId && x.UserId == userId))
            {
                _db.UserLanguages.Add(new UserLanguage { LanguageId = languageId, UserId = userId });
                await _db.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteUserLanguage(int languageId, int userId)
        {
            var userLanguage = await _db.UserLanguages.FirstOrDefaultAsync(x => x.LanguageId == languageId && x.UserId == userId);
            if (userLanguage != null)
            {
                _db.UserLanguages.Remove(userLanguage);
                await _db.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<UserProfileReply> GetUserProfile(int userId)
        {
            var user = await _db.Users.Where(x => x.UserId == userId).Select(x =>
                new UserProfileReply
                {
                    UserId = x.UserId,
                    Email = x.Email,
                    Name = x.Name,
                    ImageUrl = x.ImageUrl,
                    DateJoined = Timestamp.FromDateTime(x.Registered.ToUniversalTime()),
                    Comments = _db.Comments.Count(x => x.UserId == userId)
                }).AsNoTracking().FirstOrDefaultAsync();
            var userIdioms = await _db.Idioms.Where(x => x.UserId == userId).Select(x => new
            {
                UpvoteCount = x.Upvotes.Where(y => y.IsUpvote).Count() -
                            x.Upvotes.Where(y => !y.IsUpvote).Count(),
                FavoritesCount = x.Favorites.Count
            }).AsNoTracking().ToListAsync();
            var userComments = await _db.Comments.Where(x => x.UserId == userId).Select(x => new
            {
                LikesCount = x.CommentLikes.Count(y => y.IsLike),
                DisLikesCount = x.CommentLikes.Count(y => !y.IsLike)
            }).AsNoTracking().ToListAsync();
            user.Comments = userComments.Count;
            user.IdiomsCount = userIdioms.Count;
            user.Upvotes = userIdioms.Sum(x => x.UpvoteCount);
            user.Favorites = userIdioms.Sum(x => x.FavoritesCount);
            user.Likes = userComments.Sum(x => x.LikesCount);
            user.Dislikes = userComments.Sum(x => x.DisLikesCount);
            user.UserLanguages.AddRange(await _db.UserLanguages.Where(x => x.UserId == userId).Select(x => x.Language.ToReply()).ToListAsync());
            return user;
        }

        public async Task<bool> ChangeUser(int userId, string name, string password, string email)
        {
            var user = await _db.Users.FirstOrDefaultAsync(x => x.UserId == userId);
            if (user != null)
            {
                user.Name = name ?? user.Name;
                user.Email = email ?? user.Email;
                user.Password = password ?? user.Password;
                _db.Users.Update(user);
                await _db.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
