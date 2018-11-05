using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using Campus.Application.Interfaces;
using Campus.Application.ViewModels;
using Campus.Domain.Core.Bus;
using Campus.Domain.Interfaces;
using Campus.Domain.Models;

namespace Campus.Application.Services
{
    public class ItensAppService : IItensAppService
    {
        private readonly IMapper _mapper;
        private readonly IItensRepository _itensRepository;
        private readonly IMediatorHandler bus;

        public ItensAppService(IMapper map,
            IItensRepository itensRepository,
            IMediatorHandler bus)
        {
            _mapper = map;
            _itensRepository = itensRepository;
            this.bus = bus;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public ItensViewModel GetById(Guid id)
        {
            return _mapper
                .Map<ItensViewModel>
                    (_itensRepository.GetById(id));
        }

        public IEnumerable<ItensViewModel> GetItensPedido(Guid idPedido)
        {
            yield return _mapper.Map<ItensViewModel>(_itensRepository.GetAll().Where(i => i.Pedido.Id == idPedido));
        }

        public void Register(ItensViewModel itensViewModel)
        {

            var itens = _mapper.Map<Itens>(itensViewModel);
            _itensRepository.Add(itens);
        }

        public void Remove(Guid id)
        {
            _itensRepository.Remove(id);
        }

        public void Update(ItensViewModel itensViewModel)
        {
            var itens = _mapper.Map<Itens>(itensViewModel);
            _itensRepository.Update(itens);
        }
    }
}
