using IdiomsService.Protos;
using System.Threading.Tasks;

namespace IdiomsService.Repositories
{
    public interface IUserRepository
    {
        Task<bool> AddUserLanguage(int languageId, int userId);
        Task<bool> ChangeUser(int userId, string name, string password, string email);
        Task<bool> DeleteUserLanguage(int languageId, int userId);
        Task<UserProfileReply> GetUserProfile(int userId);
    }
}