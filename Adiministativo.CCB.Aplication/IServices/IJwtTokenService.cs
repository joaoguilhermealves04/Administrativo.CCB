using Administrativo.CCB.Dominio.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Adiministativo.CCB.Aplication.IServices
{
    public interface IJwtTokenService
    {
        string GenerateToken(string username, ClaimsIdentity? role);
        bool ValidateToken(string token);
    }
}
