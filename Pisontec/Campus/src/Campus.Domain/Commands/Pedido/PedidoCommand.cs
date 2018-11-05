using Campus.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campus.Domain.Commands.Pedido
{
    public abstract class PedidoCommand : Command
    {
        public Guid Id { get; protected set; }

        public DateTime Data { get; protected set; }

        public decimal Valor { get; protected set; }

        //public Cliente Cliente { get; set; }

    }
}
