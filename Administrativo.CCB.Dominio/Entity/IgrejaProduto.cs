using Administrativo.CCB.Dominio.Entity.EntityBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrativo.CCB.Dominio.Entity
{
    public class IgrejaProduto : EntityBase.EntityBase
    {
        public Guid IgrejaId { get; set; }
        public Igreja Igreja { get; set; }

        public Guid ProdutoId { get; set; }
        public Produto Produto { get; set; }

        public int Quantidade { get; set; }
    }
}
