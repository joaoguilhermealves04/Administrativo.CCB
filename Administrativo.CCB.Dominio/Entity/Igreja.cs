using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrativo.CCB.Dominio.Entity
{
    public class Igreja : EntityBase.EntityBase
    {
        public string Nome { get; private set; }
        public string UF { get; private set; }
        public string Setor { get; private set; }
    }
}
