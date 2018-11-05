using Campus.Domain.Events.Pedido;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Campus.Domain.EventHandlers
{
    public class PedidoEventHandler
        : INotificationHandler<PedidoRegisteredEvent>,
          INotificationHandler<PedidoUpdatedEvent>,
          INotificationHandler<PedidoRemovedEvent>
    {
        public Task Handle(PedidoRemovedEvent notification, 
            CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(PedidoUpdatedEvent notification, 
            CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(PedidoRegisteredEvent notification, 
            CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
