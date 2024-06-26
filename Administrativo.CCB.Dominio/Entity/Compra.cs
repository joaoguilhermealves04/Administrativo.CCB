﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrativo.CCB.Dominio.Entity
{
    public class Compra : EntityBase.EntityBase
    {
        public Guid ClienteId { get; private set; }
        public Cliente Cliente { get; private set; }

        public Guid IgrejaId { get; private set; }
        public Igreja igreja { get; private set; }

        public Guid ProdutoId { get; private set; }
        public Produto Produto { get; private set; }

        public decimal ValorProduto { get; private set; }

        public DateTime DataCompra { get; private set; }

        public int Quantidade { get; private set; }
    }
}
