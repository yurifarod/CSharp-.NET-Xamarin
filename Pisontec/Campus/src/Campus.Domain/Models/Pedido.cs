using Campus.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campus.Domain.Models
{
    public class Pedido : Entity
    {
        public Pedido(Guid id, 
            Cliente cliente, 
            DateTime data,
            decimal valor)
        {
            Id = id;
            Cliente = cliente;
            Data = data;
            Valor = valor;
        }

        protected Pedido()
        {}
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public Guid ClienteId { get; set; }

        public virtual Cliente Cliente { get; set; }


    }
}
