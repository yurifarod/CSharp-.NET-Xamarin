using AutoMapper;
using AutoMapper.QueryableExtensions;
using Campus.Application.Interfaces;
using Campus.Application.ViewModels;
using Campus.Domain.Commands.Pedido;
using Campus.Domain.Core.Bus;
using Campus.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campus.Application.Services
{
    public class PedidoAppService : IPedidoAppService
    {
        private readonly IMapper _mapper;
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IMediatorHandler bus;

        public PedidoAppService(
            IMapper map,
            IPedidoRepository pedidoRepository,
            IMediatorHandler bus)
        {
            _mapper = map;
            _pedidoRepository = pedidoRepository;
            this.bus = bus;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<PedidoViewModel> GetAll()
        {
            return _pedidoRepository.
                GetAll().
                ProjectTo<PedidoViewModel>();
        }

        public PedidoViewModel GetById(Guid id)
        {
            return _mapper
                .Map<PedidoViewModel>
                (_pedidoRepository.GetById(id));
        }

        public void Register(PedidoViewModel pedidoViewModel)
        {
            var registerCommand = _mapper.
                Map<RegisterNewPedidoCommand>(pedidoViewModel);
            bus.SendCommand(registerCommand);
        }

        public void Remove(Guid id)
        {
            var registerCommand = new RemovePedidoCommand(id);
            bus.SendCommand(registerCommand);
        }

        public void Update(PedidoViewModel pedidoViewModel)
        {
            var registerCommand = _mapper.
                Map<UpdatePedidoCommand>(pedidoViewModel);
            bus.SendCommand(registerCommand);
        }
    }
}
