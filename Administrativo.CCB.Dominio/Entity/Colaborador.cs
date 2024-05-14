using Administrativo.CCB.Dominio.Entity.EntityBase;
using Administrativo.CCB.Dominio.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrativo.CCB.Dominio.Entity
{
    public class Colaborador :EntityBase.EntityBase
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public Atividades Atividades { get; set; }

        public Colaborador()
        {
            
        }
    }
}
