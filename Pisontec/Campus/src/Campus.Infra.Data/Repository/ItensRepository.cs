using Campus.Domain.Interfaces;
using Campus.Domain.Models;
using Campus.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campus.Infra.Data.Repository
{
    public class ItensRepository : Repository<Itens>,
        IItensRepository
    {
        public ItensRepository(CampusContext context)
            :base(context)
        {

        }

        public Itens ObterPorId(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
