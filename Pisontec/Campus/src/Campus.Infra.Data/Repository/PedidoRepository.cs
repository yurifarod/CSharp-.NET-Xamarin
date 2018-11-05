using Campus.Domain.Interfaces;
using Campus.Domain.Models;
using Campus.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campus.Infra.Data.Repository
{
    public class PedidoRepository :
        Repository<Pedido>, IPedidoRepository
    {
        public PedidoRepository
            (CampusContext context)
            :base(context)
        {

        }


        public DateTime ObterDataPedido(Guid id)
        {
            throw new NotImplementedException();
        }

        public Pedido ObterPedido(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
