using Grpc.Core;
using IdiomsService.Protos;
using IdiomsService.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdiomsService.Services
{
    public class IdiomService : Idiom.IdiomBase
    {
        private readonly ILogger<IdiomService> _logger;
        private readonly IIdiomRepository _idioms;
        public IdiomService(ILogger<IdiomService> logger, IIdiomRepository idioms)
        {
            _logger = logger;
            _idioms = idioms;
        }

        [Authorize]
        public override async Task<GetIdiomInfoReply> GetIdiomInfo(GetIdiomInfoRequest request, ServerCallContext context)
        {
            return await _idioms.GetIdiomInfo(request.IdiomId, int.Parse(context.GetHttpContext().User.Identity.Name));
        }

        public override async Task<GetIdiomListReply> GetIdiomList(GetIdiomListRequest request, ServerCallContext context)
        {
            var result = new GetIdiomListReply();
            result.Idioms.AddRange(await _idioms.GetIdiomList(request.Skip, request.Count, int.Parse(context.GetHttpContext().User.Identity.Name)));
            return result;
        }

        [Authorize]
        public override async Task<GetIdiomInfoReply> AddIdiom(AddIdiomRequest request, ServerCallContext context)
        {
            var idiom = new Database.Models.Idiom
            {
                Text = request.Text,
                Meaning = request.Meaning,
                Usage = request.Usage,
                LanguageId = request.LanguageId,
                UserId = int.Parse(context.GetHttpContext().User.Identity.Name)
            };
            var result = await _idioms.AddIdiom(idiom);
            if (!result)
            {
                throw new RpcException(new Status(StatusCode.AlreadyExists, "Idiom with this text already exist"));
            }
            var links = request.Links.Select(x => new Database.Models.Link { RootId = idiom.IdiomId, RelatedId = x.IdiomId, LinkTypeId = x.LinkTypeId });
            if (links.Count() != 0)
            {
                await _idioms.AddLinksBatch(links);
            }
            return await _idioms.GetIdiomInfo(idiom.IdiomId, int.Parse(context.GetHttpContext().User.Identity.Name));
        }

        public override async Task<GetIdiomInfoReply> ChangeIdiom(ChangeIdiomRequest request, ServerCallContext context)
        {
            if (!await _idioms.ChangeIdiom(request.IdiomId, request.Text, request.Meaning, request.Usage, request.LanguageId))
            {
                throw new RpcException(new Status(StatusCode.NotFound, "Idiom was not found"));
            }
            return await _idioms.GetIdiomInfo(request.IdiomId, int.Parse(context.GetHttpContext().User.Identity.Name));
        }

        public override async Task<DeleteIdiomReply> DeleteIdiom(DeleteIdiomRequest request, ServerCallContext context)
        {
            if (!await _idioms.DeleteIdiom(request.IdiomId))
            {
                throw new RpcException(new Status(StatusCode.NotFound, "Idiom was not found"));
            }
            return new DeleteIdiomReply { Result = "Idiom removed" };
        }

        public override async Task<IdiomLinkReply> Addlink(AddIdiomLinkRequest request, ServerCallContext context)
        {
            var result = await _idioms.AddIdiomLink(request.CurrentIdiomId, request.LinkIdiomId, request.LinkTypeId, int.Parse(context.GetHttpContext().User.Identity.Name));
            if (result == null)
            {
                throw new RpcException(new Status(StatusCode.NotFound, "Idiom was not found"));
            }
            return result;
        }

        public override async Task<FastSearchReply> FastSearch(FastSearchRequest request, ServerCallContext context)
        {
            var result = new FastSearchReply();
            result.Idioms.AddRange(await _idioms.FastSearch(request.IdiomName));
            return result;
        }
    }
}
