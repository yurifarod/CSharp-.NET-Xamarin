using System;
using System.Collections.Generic;
using Campus.Application.EventSourcedNormalizers;
using Campus.Application.ViewModels;

namespace Campus.Application.Interfaces
{
    public interface IClienteAppService : IDisposable
    {
        void Register(ClienteViewModel clienteViewModel);
        IEnumerable<ClienteViewModel> GetAll();
        ClienteViewModel GetById(Guid id);
        void Update(ClienteViewModel clienteViewModel);
        void Remove(Guid id);
        IList<ClienteHistoryData> GetAllHistory(Guid id);
    }
}
