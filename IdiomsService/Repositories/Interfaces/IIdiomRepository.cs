using IdiomsService.Database.Models;
using IdiomsService.Protos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IdiomsService.Repositories
{
    public interface IIdiomRepository
    {
        Task<bool> AddIdiom(Database.Models.Idiom idiom, List<IdiomLinkRequest> links);
        Task<bool> ChangeIdiom(int idiomId, string text, string meaning, string usage, int languageId);
        Task<bool> DeleteIdiom(int idiomId);
        Task<GetIdiomInfoReply> GetIdiomInfo(int idiomId, int currentUserId);
        Task<IEnumerable<IdiomReply>> GetIdiomList(int skip, int count, int currentUserId, string search, string sort, IEnumerable<int> languages, bool isFavorites, bool translatedInAll);
        Task<IdiomLinkReply> AddIdiomLink(int currentIdiom, int linkIdiom);
        Task AddLinksBatch(IEnumerable<Link> links);
        Task<IEnumerable<IdiomReply>> FastSearch(string name);
    }
}