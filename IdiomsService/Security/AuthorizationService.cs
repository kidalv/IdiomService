using Google.Apis.Auth;
using IdiomsService.Database;
using IdiomsService.Database.Models;
using IdiomsService.Protos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IdiomsService.Security
{
    public class AuthorizationService : IAuthorizationService
    {
        private readonly Context _db;
        private readonly IPasswordHasher _hasher;
        private readonly AppSettings _appSettings;

        public AuthorizationService(Context db, IPasswordHasher hasher, IOptions<AppSettings> appSettings)
        {
            _db = db;
            _hasher = hasher;
            _appSettings = appSettings.Value;
        }

        public async Task<UserCredentialsReply> Login(string email, string password)
        {
            var user = await _db.Users.FirstOrDefaultAsync(x => x.Email == email && !x.IsGoogle);

            if (user == null || !_hasher.Check(user.Password, password))
                return null;

            return await LoginUser(user);
        }

        public async Task<UserCredentialsReply> Register(string email, string password, string name)
        {
            if (await _db.Users.AnyAsync(x => x.Email == email))
            {
                return null;
            }

            return await RegisterUser(email, password, name, false);
        }

        public async Task<UserCredentialsReply> Refresh(string refreshToken)
        {
            var token = await _db.Tokens.FirstOrDefaultAsync(x => x.Token == refreshToken);
            if (token == null || token.ExpiryDate > DateTime.UtcNow)
            {
                return null;
            }
            RefreshOldToken(token);
            _db.Update(token);
            await _db.SaveChangesAsync();

            return new UserCredentialsReply
            {
                UserId = token.UserId,
                Token = CreateToken(token.UserId),
                RefreshToken = token.Token
            };
        }

        public async Task<UserCredentialsReply> GoogleSignIn(string jwtToken)
        {
            try
            {
                var payload = await GoogleJsonWebSignature.ValidateAsync(jwtToken);
                if (payload != null)
                {
                    var userCheck = await _db.Users.FirstOrDefaultAsync(x => x.Email == payload.Email && x.IsGoogle);
                    if (userCheck == null)
                    {
                        return await RegisterUser(payload.Email, "", payload.Name, true, payload.Picture);
                    }
                    else
                    {
                        return await LoginUser(userCheck);
                    }
                }
                return null;
            }
            catch (InvalidJwtException)
            {
                return null;
            }
        }

        private string CreateToken(int userId)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, userId.ToString()),
                    //new Claim(ClaimTypes.Role, user.Role)
                }),
                Expires = DateTime.UtcNow.AddDays(3),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }

        private RefreshToken GenerateRefreshToken(int userId)
        {
            using (var rngCryptoServiceProvider = new RNGCryptoServiceProvider())
            {
                var randomBytes = new byte[64];
                rngCryptoServiceProvider.GetBytes(randomBytes);
                return new RefreshToken
                {
                    Token = Convert.ToBase64String(randomBytes),
                    ExpiryDate = DateTime.UtcNow.AddDays(30),
                    UserId = userId
                };
            }
        }

        private void RefreshOldToken(RefreshToken token)
        {
            using (var rngCryptoServiceProvider = new RNGCryptoServiceProvider())
            {
                var randomBytes = new byte[64];
                rngCryptoServiceProvider.GetBytes(randomBytes);
                token.Token = Convert.ToBase64String(randomBytes);
                token.ExpiryDate = DateTime.UtcNow.AddDays(30);
            }
        }

        private async Task<UserCredentialsReply> RegisterUser(string email, string password, string name, bool isGoogle, string imageUrl = null)
        {
            var user = new Database.Models.User
            {
                Email = email,
                Name = name,
                Password = isGoogle ? "" : _hasher.Hash(password),
                Registered = DateTime.UtcNow,
                IsGoogle = isGoogle,
                ImageUrl = imageUrl,
                RoleId = (int)Roles.User
            };

            _db.Users.Add(user);
            await _db.SaveChangesAsync();

            var refreshToken = GenerateRefreshToken(user.UserId);
            _db.Tokens.Add(refreshToken);

            await _db.SaveChangesAsync();
            return new UserCredentialsReply
            {
                UserId = user.UserId,
                Email = user.Email,
                Name = user.Name,
                Token = CreateToken(user.UserId),
                RefreshToken = refreshToken.Token,
                IsGoogle = user.IsGoogle,
                RoleId = user.RoleId
            };
        }

        private async Task<UserCredentialsReply> LoginUser(Database.Models.User user)
        {
            var oldToken = await _db.Tokens.FirstOrDefaultAsync(x => x.UserId == user.UserId);

            RefreshOldToken(oldToken);
            _db.Update(oldToken);
            await _db.SaveChangesAsync();

            return new UserCredentialsReply
            {
                UserId = user.UserId,
                Email = user.Email,
                Name = user.Name,
                Token = CreateToken(user.UserId),
                RefreshToken = oldToken.Token,
                IsGoogle = user.IsGoogle,
                RoleId = user.RoleId
            };
        }
    }
}
