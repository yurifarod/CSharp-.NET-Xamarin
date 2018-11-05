using Campus.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campus.Domain.Events.Pedido
{
    public class PedidoUpdatedEvent : Event
    {
        public PedidoUpdatedEvent(
            Guid id,
            DateTime data,
            decimal valor)
        {
            Id = id;
            Data = data;
            Valor = valor;
            AggregateId = id;
        }

        public Guid Id { get; set; }

        public DateTime Data { get; set; }

        public decimal Valor { get; set; }
    }
}
