﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adiministativo.CCB.Aplication.Model
{
    public class ClienteAddEditarModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int NumeroFilaEspera { get; set; }
    }
}
