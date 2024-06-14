using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrativo.CCB.Dominio.Entity
{
    public class Cliente : EntityBase.EntityBase
    {
        public string Nome { get; private set; }

        public List<Compra> Compras { get; private set; }

        private Cliente() { }

        public Cliente(string nome)
        {
            SetNome(nome);
        }

        public void AtualizarEntidadeCliente(string nome)
        {
            SetNome(nome);
        }

        private void SetNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
                throw new Exception("Por favor! Preencha o nome");

            Nome = nome;
        }
    }
}
