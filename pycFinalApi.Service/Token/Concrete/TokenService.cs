using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using NHibernate;

using pycFinalApi.Base;
using pycFinalApi.Data;
using Serilog;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace pycFinalApi.Service
{
    public class TokenService : ITokenService
    {

        protected readonly ISession session;
        protected readonly IHibernateRepository<User> hibernateRepository;
        private readonly JwtConfig jwtConfig;

        public TokenService(ISession session,  IOptionsMonitor<JwtConfig> jwtConfig)
        {
            this.session = session;
            this.jwtConfig = jwtConfig.CurrentValue;
            hibernateRepository = new HibernateRepository<User>(session);
        }



        public BaseResponse<TokenResponse> GenerateToken(TokenRequest tokenRequest)
        {
            try
            {
                if (tokenRequest is null)
                {
                    return new BaseResponse<TokenResponse>("Please enter valid informations.");
                }

                var account = hibernateRepository.Where(x => x.UserName.Equals(tokenRequest.UserName)).FirstOrDefault();
                if (account is null)
                {
                    return new BaseResponse<TokenResponse>("Please validate your informations that you provided.");
                }

                if (!account.Password.Equals(tokenRequest.Password))
                {
                    return new BaseResponse<TokenResponse>("Please validate your informations that you provided.");
                }

                DateTime now = DateTime.Now;
                string token = GetToken(account, now);

                try
                {
                    account.LastActivity = now;

                    hibernateRepository.BeginTransaction();
                    hibernateRepository.Update(account);
                    hibernateRepository.Commit();
                    hibernateRepository.CloseTransaction();
                }
                catch (Exception ex)
                {
                    Log.Error("GenerateToken Update Account LastActivity:", ex);
                    hibernateRepository.Rollback();
                    hibernateRepository.CloseTransaction();
                }

                TokenResponse tokenResponse = new TokenResponse
                {
                    AccessToken = token,
                    ExpireTime = now.AddMinutes(jwtConfig.AccessTokenExpiration),
                 
                    UserName = account.UserName,
                    SessionTimeInSecond = jwtConfig.AccessTokenExpiration * 60
                };

                return new BaseResponse<TokenResponse>(tokenResponse);
            }
            catch (Exception ex)
            {
                Log.Error("GenerateToken :", ex);
                return new BaseResponse<TokenResponse>("GenerateToken Error");
            }
        }


        private string GetToken(User account, DateTime date)
        {
            Claim[] claims = GetClaims(account);
            byte[] secret = Encoding.ASCII.GetBytes(jwtConfig.Secret);

            var shouldAddAudienceClaim = string.IsNullOrWhiteSpace(claims?.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Aud)?.Value);

            var jwtToken = new JwtSecurityToken(
                jwtConfig.Issuer,
                shouldAddAudienceClaim ? jwtConfig.Audience : string.Empty,
                claims,
                expires: date.AddMinutes(jwtConfig.AccessTokenExpiration),
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(secret), SecurityAlgorithms.HmacSha256Signature));

            var accessToken = new JwtSecurityTokenHandler().WriteToken(jwtToken);

            return accessToken;
        }

        private Claim[] GetClaims(User account)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, account.Id.ToString()),
                new Claim(ClaimTypes.Name, account.UserName),
                new Claim("AccountId", account.Id.ToString()),
                new Claim("Email",account.Email)
            };

            return claims;
        }
    }
}
