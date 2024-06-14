using Adiministativo.CCB.Aplication.IServices;
using Adiministativo.CCB.Aplication.Model;
using Administrativo.CCB.Dominio.Entity;
using Administrativo.CCB.Dominio.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adiministativo.CCB.Aplication.Services
{
    public class ClienteServico : IClienteServices
    {
        private readonly IClienteRepository _clienteRepositroy;
        public ClienteServico(IClienteRepository clienteRepository)
        {
            _clienteRepositroy = clienteRepository;
        }
        public async Task CadastroCliente(ClienteAddEditarModel clienteModel)
        {
            try
            {
                var clienteEntity = new Cliente(clienteModel.Nome);
                await _clienteRepositroy.Adicionar(clienteEntity);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar no banco.", ex);
            }
        }

        public async Task AtualizarCliente(ClienteAddEditarModel clienteModel)
        {
            try
            {
                var clienteEntity = await _clienteRepositroy.ObterPorId(clienteModel.Id);

                clienteEntity.AtualizarEntidadeCliente(clienteModel.Nome);

                _clienteRepositroy.Atualizar(clienteEntity);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar no banco.", ex);
            }
        }

        public async Task<ClienteModel> ObterCliente(Guid id)
        {
            try
            {
                if (id == null)
                    throw new InvalidOperationException("Id não pode ser nulo.");

                var unicoCliente = await _clienteRepositroy.ObterPorId(id);

                var InformacaoDoCliente = new ClienteModel
                {
                    Id = unicoCliente.Id,
                    Nome = unicoCliente.Nome,
                    DataCadastro = unicoCliente.Date
                };

                return InformacaoDoCliente;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar o banco.", ex);
            }
        }

        public async Task<IEnumerable<ClienteModel>> ObterClientes()
        {
            try
            {
                var clientes = await _clienteRepositroy.ObterTodos();

                var trazerCliente = new List<ClienteModel>();

                foreach (var c in clientes)
                {
                    var clienteRetorno = new ClienteModel
                    {
                        Id = c.Id,
                        Nome = c.Nome,
                        DataCadastro = c.Date
                    };

                    trazerCliente.Add(clienteRetorno);
                }

                return trazerCliente;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar no banco", ex);
            }
        }

        public Task Remover(Guid id)
        {
            try
            {
                if (id == null)
                    throw new ArgumentNullException("Id não pode ser nulo.");

                var cliente = _clienteRepositroy.ObterPorId(id);
                if (cliente == null)
                    throw new Exception("Produto não encontrado");

                _clienteRepositroy.Remover(cliente.Result);

                return Task.CompletedTask;
            }
            catch (Exception ex)
            {

                throw new Exception("Problem em remover o cliente.", ex);
            }
        }
    }
}
