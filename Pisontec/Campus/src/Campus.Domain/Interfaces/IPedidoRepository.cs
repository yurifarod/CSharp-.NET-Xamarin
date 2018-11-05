using Campus.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campus.Domain.Interfaces
{
    public interface IPedidoRepository : IRepository<Pedido>
    {
        Pedido ObterPedido(Guid id);

        DateTime ObterDataPedido(Guid id);
    }
}
