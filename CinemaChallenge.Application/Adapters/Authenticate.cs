using CinemaChallenge.Application.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CinemaChallenge.Application.Adapters
{
    public class Authenticate(IConfiguration config) : IAuthenticate
    {
        private readonly string? secretKey = config["AppSettings:Key"];

        public string GenerateToken(string data)
        {   
            if (secretKey != null)
            {
                Claim[] claims = [new("data", data)];
                SymmetricSecurityKey key = new(Encoding.UTF8.GetBytes(secretKey));
                SigningCredentials signing = new(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityTokenHandler()
                    .WriteToken(
                        new JwtSecurityToken(
                            claims: claims,
                            signingCredentials: signing
                        )
                    );
                return token;
            }
            throw new Exception("secret key not found");
        }
    }
}
