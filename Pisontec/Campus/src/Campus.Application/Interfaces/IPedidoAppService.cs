using Campus.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campus.Application.Interfaces
{
    public interface IPedidoAppService : IDisposable
    {
        void Register(PedidoViewModel pedidoViewModel);
        
        IEnumerable<PedidoViewModel> GetAll();

        PedidoViewModel GetById(Guid id);

        void Update(PedidoViewModel pedidoViewModel);

        void Remove(Guid id);
    }
}
