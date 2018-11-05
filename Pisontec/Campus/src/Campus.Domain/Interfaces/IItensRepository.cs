using Campus.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campus.Domain.Interfaces
{
    public interface IItensRepository : IRepository<Itens>
    {
        Itens ObterPorId(Guid Id);
    }
}
