using Campus.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campus.Application.Interfaces
{
    public interface IItensAppService : IDisposable
    {
        IEnumerable<ItensViewModel> GetItensPedido(Guid idPedido);

        void Register(ItensViewModel itensViewModel);

        ItensViewModel GetById(Guid id);

        void Update(ItensViewModel itensViewModel);

        void Remove(Guid id);
    }
}
