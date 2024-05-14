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
    }
}
