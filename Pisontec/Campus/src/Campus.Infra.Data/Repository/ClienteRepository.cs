using System.Linq;
using Campus.Domain.Interfaces;
using Campus.Domain.Models;
using Campus.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Campus.Infra.Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(CampusContext context)
            : base(context)
        {

        }

        public Cliente GetByEmail(string email)
        {
            return DbSet.AsNoTracking().FirstOrDefault(c => c.Email == email);
        }
    }
}
