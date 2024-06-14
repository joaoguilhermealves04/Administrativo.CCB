using Administrativo.CCB.Dominio.Entity;
using Administrativo.CCB.Dominio.IRepository;
using FundoBiblicoSite.CCB.Repository.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundoBiblicoSite.CCB.Repository.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly FundoBiblicoContext _contexto;
        public ClienteRepository(FundoBiblicoContext context)
        {
            _contexto = context;
        }

        public async Task Adicionar(Cliente cliente)
        {
            await _contexto.AddAsync(cliente);
            _contexto.SaveChanges();
        }

        public void Atualizar(Cliente cliente)
        {
            _contexto.Update(cliente);
            _contexto.SaveChanges();
        }

        public async Task<Cliente> ObterPorId(Guid id)
        {
            return await _contexto.Set<Cliente>().FirstAsync(c => c.Id == id);
        }

        public async Task<IEnumerable<Cliente>> ObterTodos()
        {
            return await _contexto.Set<Cliente>().ToListAsync();
        }

        public async Task Remover(Cliente cliente)
        {
            _contexto.Remove(cliente);
            _contexto.SaveChanges();
        }
    }
}
