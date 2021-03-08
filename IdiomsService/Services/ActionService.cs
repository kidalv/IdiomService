using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using IdiomsService.Database;
using IdiomsService.Database.Models;
using IdiomsService.ExtensionMethods;
using IdiomsService.Protos;
using IdiomsService.Repositories;
using Microsoft.Extensions.Logging;

namespace IdiomsService.Services
{
    public class ActionService : Protos.Action.ActionBase
    {
        private readonly ILogger<ActionService> _logger;
        private readonly IActionRepository _actions;

        public ActionService(ILogger<ActionService> logger, IActionRepository actions)
        {
            _logger = logger;
            _actions = actions;
        }

        public override async Task<CommentReply> AddComment(AddCommentRequest request, ServerCallContext context)
        {
            var userId = int.Parse(context.GetHttpContext().User.Identity.Name);
            var comment = new Comment
            {
                IdiomId = request.IdiomId,
                Text = request.Text,
                UserId = userId
            };
            await _actions.AddComment(comment);
            return await _actions.GetCommentReply(comment.CommentId, userId);
        }

        public override async Task<FavoriteReply> AddFavorite(AddFavoriteRequest request, ServerCallContext context)
        {
            var favorite = new Favorite
            {
                IdiomId = request.IdiomId,
                UserId = int.Parse(context.GetHttpContext().User.Identity.Name),
            };
            await _actions.AddFavorite(favorite);
            return favorite.ToReply();
        }

        public override async Task<ReportReply> AddReport(AddReportRequest request, ServerCallContext context)
        {
            var report = new Report
            {
                UserId = int.Parse(context.GetHttpContext().User.Identity.Name),
                IdiomId = request.IdiomId,
                Text = request.Text
            };
            await _actions.AddReport(report);
            return report.ToReply();
        }

        public override async Task<UpvoteReply> AddUpvote(AddUpvoteRequest request, ServerCallContext context)
        {
            var upvote = new Upvote
            {
                UserId = int.Parse(context.GetHttpContext().User.Identity.Name),
                IdiomId = request.IdiomId,
                IsUpvote = request.IsUpvote
            };
            await _actions.AddOrChangeUpvote(upvote);
            return upvote.ToReply();
        }

        public override async Task<CommentReply> ChangeComment(ChangeCommentRequest request, ServerCallContext context)
        {
            if (!await _actions.ChangeComment(request.CommentId, request.Text))
            {
                throw new RpcException(new Status(StatusCode.NotFound, "Comment not found"));
            }
            return await _actions.GetCommentReply(request.CommentId, int.Parse(context.GetHttpContext().User.Identity.Name));
        }

        public override async Task<DeleteReply> DeleteComment(DeleteCommentRequest request, ServerCallContext context)
        {
            if (!await _actions.DeleteComment(request.CommentId))
            {
                throw new RpcException(new Status(StatusCode.NotFound, "Comment not found"));
            }
            return new DeleteReply { Result = "Comment removed" };
        }

        public override async Task<DeleteReply> DeleteFavorite(DeleteFavoriteRequest request, ServerCallContext context)
        {
            if (!await _actions.DeleteFavorite(request.IdiomId, int.Parse(context.GetHttpContext().User.Identity.Name)))
            {
                throw new RpcException(new Status(StatusCode.NotFound, "Favorite not found"));
            }
            return new DeleteReply { Result = "Favorite removed" };
        }

        public override async Task<DeleteReply> DeleteUpvote(DeleteUpvoteRequest request, ServerCallContext context)
        {
            if (!await _actions.DeleteUpvote(request.IdiomId, int.Parse(context.GetHttpContext().User.Identity.Name)))
            {
                throw new RpcException(new Status(StatusCode.NotFound, "Upvote not found"));
            }
            return new DeleteReply { Result = "Upvote removed" };
        }

        public override async Task<RequestTranslationReply> RequestTranslation(RequestTranslationRequest request, ServerCallContext context)
        {
            var translationRequest = new Request
            {
                IdiomId = request.IdiomId,
                UserId = int.Parse(context.GetHttpContext().User.Identity.Name),
                LanguageId = request.LanguageId,
            };
            if (!await _actions.AddTranslationRequest(translationRequest))
            {
                throw new RpcException(new Status(StatusCode.AlreadyExists, "Request already exists"));
            }
            return translationRequest.ToReply();
        }

        public override async Task<GetAllLanguagesResponse> GetAllLanguages(GetAllLanguagesRequest request, ServerCallContext context)
        {
            return await _actions.GetAllLAnguages();
        }

        public override async Task<AddCommentLikeResponse> AddCommentLike(AddCommentLikeRequest request, ServerCallContext context)
        {
            return new AddCommentLikeResponse
            {
                IsSuccessful = await _actions.AddOrChangeCommentLike(request.CommentId, int.Parse(context.GetHttpContext().User.Identity.Name), request.IsLike)
            };

        }

        public override async Task<DeleteCommentLikeResponse> DeleteCommentLike(DeleteCommentLikeRequest request, ServerCallContext context)
        {
            var result = await _actions.DeleteCommentLike(request.CommentId, int.Parse(context.GetHttpContext().User.Identity.Name));
            if(!result)
            {
                throw new RpcException(new Status(StatusCode.NotFound, "CommentLike not found"));
            }
            return new DeleteCommentLikeResponse
            {
                IsRemoved = true
            };
        }

        public override Task<GetLinkTypesReply> GetLinkTypes(GetLinkTypesRequest request, ServerCallContext context)
        {
            var response = new GetLinkTypesReply();
            response.Links.AddRange(typeof(LinkTypes).GetEnumList<LinkReply, LinkTypes, Type>());
            return Task.FromResult(response);
        }
    }
}
