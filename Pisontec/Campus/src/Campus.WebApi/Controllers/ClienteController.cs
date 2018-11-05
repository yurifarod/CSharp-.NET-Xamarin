using System;
using Campus.Application.Interfaces;
using Campus.Application.ViewModels;
using Campus.Domain.Core.Bus;
using Campus.Domain.Core.Notifications;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Campus.WebApi.Controllers
{
    [Authorize]
    public class ClienteController : ApiController
    {
        private readonly IClienteAppService _clienteAppService;

        public ClienteController(
            IClienteAppService clienteAppService,
            INotificationHandler<DomainNotification> notifications,
            IMediatorHandler mediator) : base(notifications, mediator)
        {
            _clienteAppService = clienteAppService;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("cliente-management")]
        public IActionResult Get()
        {
            return Response(_clienteAppService.GetAll());
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("cliente-management/{id:guid}")]
        public IActionResult Get(Guid id)
        {
            var clienteViewModel = _clienteAppService.GetById(id);

            return Response(clienteViewModel);
        }     

        [HttpPost]
        [Authorize(Policy = "CanWriteClienteData")]
        [Route("cliente-management")]
        public IActionResult Post([FromBody]ClienteViewModel clienteViewModel)
        {
            if (!ModelState.IsValid)
            {
                NotifyModelStateErrors();
                return Response(clienteViewModel);
            }

            _clienteAppService.Register(clienteViewModel);

            return Response(clienteViewModel);
        }
        
        [HttpPut]
        [Authorize(Policy = "CanWriteClienteData")]
        [Route("cliente-management")]
        public IActionResult Put([FromBody]ClienteViewModel clienteViewModel)
        {
            if (!ModelState.IsValid)
            {
                NotifyModelStateErrors();
                return Response(clienteViewModel);
            }

            _clienteAppService.Update(clienteViewModel);

            return Response(clienteViewModel);
        }

        [HttpDelete]
        [Authorize(Policy = "CanRemoveClienteData")]
        [Route("cliente-management")]
        public IActionResult Delete(Guid id)
        {
            _clienteAppService.Remove(id);
            
            return Response();
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("cliente-management/history/{id:guid}")]
        public IActionResult History(Guid id)
        {
            var clienteHistoryData = _clienteAppService.GetAllHistory(id);
            return Response(clienteHistoryData);
        }
    }
}
