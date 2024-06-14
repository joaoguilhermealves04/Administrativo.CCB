using Administrativo.CCB.Dominio.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrativo.CCB.Dominio.IRepository
{
    public interface IClienteRepository
    {
        Task<Cliente> ObterPorId(Guid id);
        Task Adicionar(Cliente cliente);
        void Atualizar(Cliente cliente);
        Task Remover(Cliente cliente);
        Task<IEnumerable<Cliente>> ObterTodos();
    }
}
