using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrativo.CCB.Dominio.Entity.EntityBase
{
    public class EntityBase
    {
        public Guid Id { get; set; }

        public DateTime Date { get; set; }

        public EntityBase()
        {
            Date = DateTime.Now;
        }
    }
}
