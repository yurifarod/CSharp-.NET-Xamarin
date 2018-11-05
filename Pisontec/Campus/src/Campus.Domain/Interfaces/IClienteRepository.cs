using Campus.Domain.Models;

namespace Campus.Domain.Interfaces
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Cliente GetByEmail(string email);
    }
}