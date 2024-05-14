using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrativo.CCB.Dominio.Entity
{
    public class Produto : EntityBase.EntityBase
    {
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public string Foto { get; private set; }
        public decimal Preco { get; private set; }
        public int QuantidadeEstoque { get; private set; }
    }
}
