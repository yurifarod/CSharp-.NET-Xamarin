using System;
using Campus.Domain.Core.Events;

namespace Campus.Domain.Events.Cliente
{
    public class ClienteRemovedEvent : Event
    {
        public ClienteRemovedEvent(Guid id)
        {
            Id = id;
            AggregateId = id;
        }

        public Guid Id { get; set; }
    }
}