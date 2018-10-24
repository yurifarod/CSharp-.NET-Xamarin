using SEFAZ.CursoMvc.Domain.Interfaces.Repository;
using SEFAZ.CursoMvc.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SEFAZ.CursoMvc.Infra.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity :class
    {
        protected CursoMvcContext db;
        protected DbSet<TEntity> DbSet;

        public Repository(CursoMvcContext context)
        {
            db = context;
            DbSet = db.Set<TEntity>();
        }

        public TEntity Adicionar(TEntity obj)
        {
            return DbSet.Add(obj);
        }

        public TEntity Atualizar(TEntity obj)
        {
            var entry = db.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;
            return obj;
        }

        public IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public void Dispose()
        {
            db.Dispose();
            GC.SuppressFinalize(this);
        }

        public TEntity ObterPorId(Guid guid)
        {
            return DbSet.Find(guid);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return DbSet.ToList();
        }

        public void Remover(Guid Id)
        {
            DbSet.Remove(DbSet.Find(Id));
        }

        public int SaveChanges()
        {
            return db.SaveChanges();
        }
    }
}
