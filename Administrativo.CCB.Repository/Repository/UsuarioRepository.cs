using Administrativo.CCB.Dominio.Entity;
using Administrativo.CCB.Dominio.IRepository;
using Administrativo.CCB.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrativo.CCB.Repository.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AdministrativoContext _administrativoContext;
        public UsuarioRepository(AdministrativoContext administrativoContext)
        {
            _administrativoContext = administrativoContext;
        }
        public async Task AddUserAsync(Usuario user)
        {
           await _administrativoContext.Usuarios.AddAsync(user);
           await _administrativoContext.SaveChangesAsync();
        }

        public async Task<Usuario> GetUserByUsernameAsync(string username)
        {
            return await _administrativoContext.Usuarios.SingleOrDefaultAsync(u => u.Username == username);
        }

        public async Task UpdateUserAsync(Usuario user)
        {
             _administrativoContext.Usuarios.Update(user);
            await _administrativoContext.SaveChangesAsync();
        }
    }
}
