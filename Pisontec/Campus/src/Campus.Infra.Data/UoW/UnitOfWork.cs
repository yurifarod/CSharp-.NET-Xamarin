using Campus.Domain.Interfaces;
using Campus.Infra.Data.Context;

namespace Campus.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CampusContext _context;

        public UnitOfWork(CampusContext context)
        {
            _context = context;
        }

        public bool Commit()
        {
            return _context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
