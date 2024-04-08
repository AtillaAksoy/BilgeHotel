using BilgeHotel.Application.Repositories.Token;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Persistence.Repositories.Token
{
    public class TokenHandler : ITokenHandler
    {
        private readonly IConfiguration _configuration;
        public TokenHandler(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public Application.Dtos.Token CreateAccessToken(int day)
        {
           Application.Dtos.Token token= new();
            //security key in simetriğini alıyoruz
            SymmetricSecurityKey securityKey = new(Encoding.UTF8.GetBytes("nereden bulaştım bu yazılıma ulan..."));

            //şifrelenmiş kimliği oluşturuyoruz
            SigningCredentials signingCredentials = new(securityKey, SecurityAlgorithms.HmacSha256);

            //oluşturulacak Token ayarlarını veriyoruz.
            token.Expiration = DateTime.UtcNow.AddDays(day);
            JwtSecurityToken securityToken = new(audience: _configuration["Token:Audience"],
                issuer: _configuration["Token:Issuer"],
                expires : token.Expiration,
                notBefore : DateTime.UtcNow,
                signingCredentials : signingCredentials
                );
            //token oluşturucu sınıftan örnek
            JwtSecurityTokenHandler tokenHandler = new();
            token.AccessToken = tokenHandler.WriteToken(securityToken);

            return token;
        }
    }
}
