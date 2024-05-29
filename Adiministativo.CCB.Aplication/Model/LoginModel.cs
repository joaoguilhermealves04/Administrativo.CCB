using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adiministativo.CCB.Aplication.Model
{
    public class LoginModel
    {
        public Guid Id { get;private set; }
        public string Username { get; private set; }
        public string PasswordHash { get; private set; }
    }
}
