using Adiministativo.CCB.Aplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adiministativo.CCB.Aplication.IServices
{
    public interface IClienteServices
    {
        Task CadastroCliente(ClienteAddEditarModel cliente);
        Task AtualizarCliente(ClienteAddEditarModel cliente);
        Task<IEnumerable<ClienteModel>> ObterClientes();
        Task<ClienteModel> ObterCliente(Guid id);
        Task Remover(Guid id);
    }
}
