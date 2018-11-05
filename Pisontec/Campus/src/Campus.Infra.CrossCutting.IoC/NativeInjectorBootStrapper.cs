using Campus.Application.Interfaces;
using Campus.Application.Services;
using Campus.Domain.CommandHandlers;
using Campus.Domain.Commands.Cliente;
using Campus.Domain.Core.Bus;
using Campus.Domain.Core.Events;
using Campus.Domain.Core.Notifications;
using Campus.Domain.EventHandlers;
using Campus.Domain.Events.Cliente;
using Campus.Domain.Interfaces;
using Campus.Infra.CrossCutting.Bus;
using Campus.Infra.CrossCutting.Identity.Authorization;
using Campus.Infra.CrossCutting.Identity.Models;
using Campus.Infra.CrossCutting.Identity.Services;
using Campus.Infra.Data.Context;
using Campus.Infra.Data.EventSourcing;
using Campus.Infra.Data.Repository;
using Campus.Infra.Data.Repository.EventSourcing;
using Campus.Infra.Data.UoW;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Campus.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // ASP.NET HttpContext dependency
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            // Domain Bus (Mediator)
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            // ASP.NET Authorization Polices
            services.AddSingleton<IAuthorizationHandler, ClaimsRequirementHandler>();

            // Application
            services.AddScoped<IClienteAppService, ClienteAppService>();
            services.AddScoped<IPedidoAppService, PedidoAppService>();

            // Domain - Events
            services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();
            services.AddScoped<INotificationHandler<ClienteRegisteredEvent>, ClienteEventHandler>();
            services.AddScoped<INotificationHandler<ClienteUpdatedEvent>, ClienteEventHandler>();
            services.AddScoped<INotificationHandler<ClienteRemovedEvent>, ClienteEventHandler>();

            // Domain - Commands
            services.AddScoped<IRequestHandler<RegisterNewClienteCommand>, ClienteCommandHandler>();
            services.AddScoped<IRequestHandler<UpdateClienteCommand>, ClienteCommandHandler>();
            services.AddScoped<IRequestHandler<RemoveClienteCommand>, ClienteCommandHandler>();

            // Infra - Data
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();
            services.AddScoped<IItensRepository, ItensRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<CampusContext>();

            // Infra - Data EventSourcing
            services.AddScoped<IEventStoreRepository, EventStoreSQLRepository>();
            services.AddScoped<IEventStore, SqlEventStore>();
            services.AddScoped<EventStoreSQLContext>();

            // Infra - Identity Services
            services.AddTransient<IEmailSender, AuthEmailMessageSender>();
            services.AddTransient<ISmsSender, AuthSMSMessageSender>();

            // Infra - Identity
            services.AddScoped<IUser, AspNetUser>();
        }
    }
}