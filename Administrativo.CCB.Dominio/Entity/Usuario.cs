using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrativo.CCB.Dominio.Entity
{
    public class Usuario : EntityBase.EntityBase
    {
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }
        public string ConfirmaSenha { get; set; }
    }
}
