using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Adiministativo.CCB.Aplication.Model
{
    public class RegistreModel
    {
        public Guid Id { get; private set; }
        public string Username { get; private set; }
        public string PasswordHash { get; private set; }
        public string EmailAddress { get; private set; }
        public string Token { get; private set; }
        public DateTime DateOfJoining { get; private set; }
        public ClaimsIdentity? Role { get; private set; }
        public DateTime Date { get; private set; }

        public RegistreModel()
        {
            
        }
    }
}
