using IdiomsService.Database;
using IdiomsService.Database.Models;
using IdiomsService.ExtensionMethods;
using IdiomsService.Protos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdiomsService.Repositories
{
    public class ActionRepository : IActionRepository
    {
        private readonly Context _db;

        public ActionRepository(Context db)
        {
            _db = db;
        }

        public async Task<bool> AddComment(Comment comment)
        {
            comment.DateAdded = DateTime.UtcNow;
            _db.Comments.Add(comment);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> AddFavorite(Favorite favorite)
        {
            if (!await _db.Favorites.AnyAsync(x => x.IdiomId == favorite.IdiomId && x.UserId == favorite.UserId))
            {
                _db.Favorites.Add(favorite);
                await _db.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> AddOrChangeUpvote(Upvote upvote)
        {
            var check = await _db.Upvotes.FirstOrDefaultAsync(x => x.IdiomId == upvote.IdiomId && x.UserId == upvote.UserId);
            if (check == null)
            {
                _db.Upvotes.Add(upvote);
                await _db.SaveChangesAsync();
            }
            else
            {
                check.IsUpvote = upvote.IsUpvote;
                _db.Upvotes.Update(check);
                await _db.SaveChangesAsync();
            }
            return true;
        }

        public async Task<bool> AddReport(Report report)
        {
            if (!await _db.Reports.AnyAsync(x => x.UserId == report.UserId && x.IdiomId == report.IdiomId))
            {
                _db.Reports.Add(report);
                await _db.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> ChangeComment(int commentId, string text)
        {
            var comment = await _db.Comments.FirstOrDefaultAsync(x => x.CommentId == commentId);
            if (comment != null)
            {
                comment.Text = text;
                _db.Comments.Update(comment);
                await _db.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteComment(int commentId)
        {
            var comment = await _db.Comments.FirstOrDefaultAsync(x => x.CommentId == commentId);
            if (comment != null)
            {
                _db.Comments.Remove(comment);
                await _db.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteUpvote(int idiomId, int userId)
        {
            var upvote = await _db.Upvotes.FirstOrDefaultAsync(x => x.UserId == userId && x.IdiomId == idiomId);
            if (upvote != null)
            {
                _db.Upvotes.Remove(upvote);
                await _db.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteFavorite(int idiomId, int userId)
        {
            var favorite = await _db.Favorites.FirstOrDefaultAsync(x => x.UserId == userId && x.IdiomId == idiomId);
            if (favorite != null)
            {
                _db.Favorites.Remove(favorite);
                await _db.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> AddTranslationRequest(Request request)
        {
            if (!await _db.Requests.AnyAsync(x => x.IdiomId == request.IdiomId && x.LanguageId == request.LanguageId && x.UserId == request.UserId))
            {
                _db.Requests.Add(request);
                await _db.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<CommentReply> GetCommentReply(int commentId, int currentUserId)
        {
            return await _db.Comments.Where(x => x.CommentId == commentId).Include(x => x.User).Include(x => x.CommentLikes).Select(x => x.ToReply(currentUserId)).FirstOrDefaultAsync();
        }

        public async Task<GetAllLanguagesResponse> GetAllLAnguages()
        {
            var result = new GetAllLanguagesResponse();
            result.Languages.Add(await _db.Languages.Select(x => x.ToReply()).ToListAsync());
            return result;
        }

        public async Task<bool> AddOrChangeCommentLike(int commentId, int userId, bool isLike)
        {
            var commentLike = await _db.CommentLikes.FirstOrDefaultAsync(x => x.CommentId == commentId && x.UserId == userId);
            if (commentLike != null)
            {
                commentLike.IsLike = isLike;
                _db.CommentLikes.Update(commentLike);
            }
            else
            {
                _db.CommentLikes.Add(new CommentLike
                {
                    CommentId = commentId,
                    UserId = userId,
                    IsLike = isLike
                });
            }
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteCommentLike(int commentId, int userId)
        {
            var commentLike = await _db.CommentLikes.FirstOrDefaultAsync(x => x.CommentId == commentId && x.UserId == userId);
            if (commentLike != null) 
            {
                _db.CommentLikes.Remove(commentLike);
                await _db.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
