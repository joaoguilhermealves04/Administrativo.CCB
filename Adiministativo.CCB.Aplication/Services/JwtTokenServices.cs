using Adiministativo.CCB.Aplication.IServices;
using Administrativo.CCB.Dominio.Entity;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Adiministativo.CCB.Aplication.Services
{
    public class JwtTokenServices : IJwtTokenService
    {
        private readonly string _secretKey;

        public JwtTokenServices(string secretkey)
        {
            _secretKey = secretkey;
        }

        public string GenerateToken(string username, ClaimsIdentity? role)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_secretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                new Claim(ClaimTypes.Name, username)
                // Adicione mais claims conforme necessário
            }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            if (role != null)
            {
                tokenDescriptor.Subject.AddClaims(role.Claims);
            }

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public bool ValidateToken(string token)
        {
            throw new NotImplementedException();
        }
    }
}
