using IdiomsService.Database.Models;
using IdiomsService.Protos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IdiomsService.Repositories
{
    public interface IActionRepository
    {
        Task<bool> AddComment(Comment comment);
        Task<bool> AddFavorite(Favorite favorite);
        Task<bool> AddReport(Report report);
        Task<bool> AddTranslationRequest(Request request);
        Task<bool> AddOrChangeUpvote(Upvote upvote);
        Task<bool> ChangeComment(int commentId, string text);
        Task<bool> DeleteComment(int commentId);
        Task<bool> DeleteFavorite(int idiomId, int userId);
        Task<bool> DeleteUpvote(int idiomId, int userId);
        Task<CommentReply> GetCommentReply(int commentId);
        Task<GetAllLanguagesResponse> GetAlllAnguages();
    }
}