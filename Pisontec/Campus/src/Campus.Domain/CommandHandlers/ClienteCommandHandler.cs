using System;
using System.Threading;
using System.Threading.Tasks;
using Campus.Domain.Commands.Cliente;
using Campus.Domain.Core.Bus;
using Campus.Domain.Core.Notifications;
using Campus.Domain.Events.Cliente;
using Campus.Domain.Interfaces;
using Campus.Domain.Models;
using MediatR;

namespace Campus.Domain.CommandHandlers
{
    public class ClienteCommandHandler : CommandHandler,
        IRequestHandler<RegisterNewClienteCommand>,
        IRequestHandler<UpdateClienteCommand>,
        IRequestHandler<RemoveClienteCommand>
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMediatorHandler Bus;

        public ClienteCommandHandler(IClienteRepository clienteRepository, 
                                      IUnitOfWork uow,
                                      IMediatorHandler bus,
                                      INotificationHandler<DomainNotification> notifications) :base(uow, bus, notifications)
        {
            _clienteRepository = clienteRepository;
            Bus = bus;
        }

        public Task Handle(RegisterNewClienteCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid())
            {
                NotifyValidationErrors(message);
                return Task.CompletedTask;
            }

            var cliente = new Cliente(Guid.NewGuid(), message.Nome, message.Email, message.DataNascimento);

            if (_clienteRepository.GetByEmail(cliente.Email) != null)
            {
                Bus.RaiseEvent(new DomainNotification(message.MessageType, "O e-mail do cliente já foi obtido."));
                return Task.CompletedTask;
            }

            _clienteRepository.Add(cliente);

            if (Commit())
            {
                Bus.RaiseEvent(new ClienteRegisteredEvent(cliente.Id, cliente.Nome, cliente.Email, cliente.DataNascimento));
            }

            return Task.CompletedTask;
        }

        public Task Handle(UpdateClienteCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid())
            {
                NotifyValidationErrors(message);
                return Task.CompletedTask;
            }

            var cliente = new Cliente(message.Id, message.Nome, message.Email, message.DataNascimento);
            var existingCliente = _clienteRepository.GetByEmail(cliente.Email);

            if (existingCliente != null && existingCliente.Id != cliente.Id)
            {
                if (!existingCliente.Equals(cliente))
                {
                    Bus.RaiseEvent(new DomainNotification(message.MessageType,"O e-mail do cliente ja foi obtido."));
                    return Task.CompletedTask;
                }
            }

            _clienteRepository.Update(cliente);

            if (Commit())
            {
                Bus.RaiseEvent(new ClienteUpdatedEvent(cliente.Id, cliente.Nome, cliente.Email, cliente.DataNascimento));
            }

            return Task.CompletedTask;
        }

        public Task Handle(RemoveClienteCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid())
            {
                NotifyValidationErrors(message);
                return Task.CompletedTask;
            }

            _clienteRepository.Remove(message.Id);

            if (Commit())
            {
                Bus.RaiseEvent(new ClienteRemovedEvent(message.Id));
            }

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _clienteRepository.Dispose();
        }
    }
}