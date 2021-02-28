using Google.Protobuf.WellKnownTypes;
using IdiomsService.Database.Models;
using IdiomsService.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdiomsService.ExtensionMethods
{
    public static class MapperExtensions
    {
        public static LanguageReply ToReply(this Language language) => new LanguageReply 
        {
            LanguageId = language.LanguageId,
            Locale = language.Locale,
            Name = language.Name,
            Region = language.RegionCode,
            NativeName = language.NativeName,
        };

        public static UserReply ToReply(this Database.Models.User user) => new UserReply { UserId = user.UserId, Name = user.Name };

        public static ReportReply ToReply(this Report report) => new ReportReply { ReportId = report.ReportId, UserId = report.UserId, IdiomId = report.IdiomId, Text = report.Text };

        public static UpvoteReply ToReply(this Upvote upvote) => new UpvoteReply { UpvoteId = upvote.UpvoteId, IdiomId = upvote.IdiomId, IsUpvote = upvote.IsUpvote, UserId = upvote.UserId };

        public static RequestTranslationReply ToReply(this Request request) => new RequestTranslationReply { RequestId = request.RequestId, IdiomId = request.IdiomId, LanguageId = request.LanguageId, UserId = request.UserId };

        public static FavoriteReply ToReply(this Favorite favorite) => new FavoriteReply { FavoriteId = favorite.FavoriteId, UserId = favorite.UserId, IdiomId = favorite.IdiomId };

        public static CommentReply ToReply(this Comment comment) => new CommentReply
        {
            CommentId = comment.CommentId,
            Text = comment.Text,
            Date = Timestamp.FromDateTime(comment.DateAdded.ToUniversalTime()),
            User = comment.User.ToReply()
        };
    }
}
