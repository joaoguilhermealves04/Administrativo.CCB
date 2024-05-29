using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Administrativo.CCB.Dominio.Entity
{
    public class Usuario : EntityBase.EntityBase
    {
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string EmailAddress { get; set; }
        public string Token { get; set; }
        public DateTime DateOfJoining { get; set; }
        public ClaimsIdentity? Role { get; set; }

    }
}
