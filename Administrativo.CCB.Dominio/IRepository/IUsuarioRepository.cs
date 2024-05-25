using Administrativo.CCB.Dominio.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrativo.CCB.Dominio.IRepository
{
    public interface IUsuarioRepository
    {
        Task<Usuario> GetUserByUsernameAsync(string username);
        Task AddUserAsync(Usuario user);
        Task UpdateUserAsync(Usuario user);
    }
}
