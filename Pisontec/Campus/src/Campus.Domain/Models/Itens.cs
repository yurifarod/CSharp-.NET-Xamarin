using Campus.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campus.Domain.Models
{
    public class Itens : Entity
    {
        public Itens(Guid id, 
            Pedido pedido, 
            int quantidade,
            string produto,
            decimal valorUnitario)
        {
            Id = id;
            Pedido = pedido;
            Quantidade = quantidade;
            Produto = produto;
            ValorUnitario = valorUnitario;
        }

        protected Itens() {}

        public virtual Pedido Pedido { get; set; }

        public int Quantidade { get; set; }

        public string Produto { get; set; }

        public decimal ValorUnitario { get; set; }

    }
}
