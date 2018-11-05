﻿using System;
using System.Collections.Generic;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Campus.Application.EventSourcedNormalizers;
using Campus.Application.Interfaces;
using Campus.Application.ViewModels;
using Campus.Domain.Commands.Cliente;
using Campus.Domain.Core.Bus;
using Campus.Domain.Interfaces;
using Campus.Infra.Data.Repository.EventSourcing;

namespace Campus.Application.Services
{
    public class ClienteAppService : IClienteAppService
    {
        private readonly IMapper _mapper;
        private readonly IClienteRepository _clienteRepository;
        private readonly IEventStoreRepository _eventStoreRepository;
        private readonly IMediatorHandler Bus;

        public ClienteAppService(IMapper mapper,
                                  IClienteRepository clienteRepository,
                                  IMediatorHandler bus,
                                  IEventStoreRepository eventStoreRepository)
        {
            _mapper = mapper;
            _clienteRepository = clienteRepository;
            Bus = bus;
            _eventStoreRepository = eventStoreRepository;
        }

        public IEnumerable<ClienteViewModel> GetAll()
        {
            return _clienteRepository.GetAll().ProjectTo<ClienteViewModel>();
        }

        public ClienteViewModel GetById(Guid id)
        {
            return _mapper.Map<ClienteViewModel>(_clienteRepository.GetById(id));
        }

        public void Register(ClienteViewModel clienteViewModel)
        {
            var registerCommand = _mapper.Map<RegisterNewClienteCommand>(clienteViewModel);
            Bus.SendCommand(registerCommand);
        }

        public void Update(ClienteViewModel clienteViewModel)
        {
            var updateCommand = _mapper.Map<UpdateClienteCommand>(clienteViewModel);
            Bus.SendCommand(updateCommand);
        }

        public void Remove(Guid id)
        {
            var removeCommand = new RemoveClienteCommand(id);
            Bus.SendCommand(removeCommand);
        }

        public IList<ClienteHistoryData> GetAllHistory(Guid id)
        {
            return ClienteHistory.ToJavaScriptClienteHistory(_eventStoreRepository.All(id));
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
