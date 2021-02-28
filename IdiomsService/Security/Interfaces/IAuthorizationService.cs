using IdiomsService.Protos;
using System.Threading.Tasks;

namespace IdiomsService.Security
{
    public interface IAuthorizationService
    {
        Task<UserCredentialsReply> GoogleSignIn(string jwtToken);
        Task<UserCredentialsReply> Login(string email, string password);
        Task<UserCredentialsReply> Refresh(string refreshToken);
        Task<UserCredentialsReply> Register(string email, string password, string name);
    }
}