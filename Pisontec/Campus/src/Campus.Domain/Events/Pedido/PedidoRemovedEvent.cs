using Campus.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campus.Domain.Events.Pedido
{
    public class PedidoRemovedEvent
        :Event
    {
        public PedidoRemovedEvent(Guid id)
        {
            Id = id;
            AggregateId = id;
        }

        public Guid Id { get; set; }
    }
}
