using Adiministativo.CCB.Aplication.Model;
using Administrativo.CCB.Dominio.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adiministativo.CCB.Aplication.IServices
{
    public interface IUsuarioServices
    {
        Task<Usuario> RegisterUserAsync(RegistreModel model);
        Task<Usuario> AuthenticateUserAsync(LoginModel model);
    }
}
