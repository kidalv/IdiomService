using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdiomsService.Protos;
using IdiomsService.Repositories;
using IdiomsService.Security;
using Google.Apis.Auth;

namespace IdiomsService.Services
{
    public class UserService : User.UserBase
    {
        private readonly ILogger<UserService> _logger;
        private readonly IUserRepository _users;
        private readonly IAuthorizationService _authorization;

        public UserService(ILogger<UserService> logger, IUserRepository users, IAuthorizationService authorization)
        {
            _logger = logger;
            _users = users;
            _authorization = authorization;
        }

        public override async Task<UserProfileReply> GetUserProfile(GetUserProfileRequest request, ServerCallContext context)
        {
            if(request.UserId == 0)
            {
                return await _users.GetUserProfile(int.Parse(context.GetHttpContext().User.Identity.Name));
            }
            return await _users.GetUserProfile(request.UserId);
        }

        public override async Task<UserCredentialsReply> Login(LoginRequest request, ServerCallContext context)
        {
            var user = await _authorization.Login(request.Email, request.Password);
            if (user == null)
            {
                throw new RpcException(new Status(StatusCode.NotFound, "Wrong credentials"));
            }
            return user;
        }

        public override Task<UserCredentialsReply> Register(RegisterRequest request, ServerCallContext context)
        {
            var user = _authorization.Register(request.Email, request.Password, request.Name);
            if (user == null)
            {
                throw new RpcException(new Status(StatusCode.AlreadyExists, "Email already used"));
            }
            return user;
        }

        public override async Task<UserCredentialsReply> GoogleSignIn(GoogleSignInRequest request, ServerCallContext context)
        {
            return await _authorization.GoogleSignIn(request.JwtToken);
        }

        public override Task<UserProfileReply> ChangeUser(ChangeUserRequest request, ServerCallContext context)
        {
            return base.ChangeUser(request, context);
        }

        public override async Task<UserProfileReply> AddUserLangueage(AddUserLanguageRequest request, ServerCallContext context)
        {
            var currentUserId = int.Parse(context.GetHttpContext().User.Identity.Name);
            if (!await _users.AddUserLanguage(request.LanguageId, currentUserId))
            {
                throw new RpcException(new Status(StatusCode.AlreadyExists, "UserLanguage already exist"));
            }
            return await _users.GetUserProfile(currentUserId);
        }

        public override async Task<UserProfileReply> DeleteUserLanguage(DeleteUserLanguageRequest request, ServerCallContext context)
        {
            var currentUserId = int.Parse(context.GetHttpContext().User.Identity.Name);
            if (!await _users.DeleteUserLanguage(request.LanguageId, currentUserId))
            {
                throw new RpcException(new Status(StatusCode.NotFound, "UserLanguage not found"));
            }
            return await _users.GetUserProfile(currentUserId);
        }
    }
}
