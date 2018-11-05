using EP.CursoMvc.Domain.Interfaces.Repository;
using EP.CursoMvc.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace EP.CursoMvc.Infra.Data.Repository
{
    public class Repository<TEntity> : IReposity<TEntity> where TEntity : class
    {
        protected CursoMvcContext db;
        protected DbSet<TEntity> DbSet;

        public Repository(CursoMvcContext context)
        {
            db = context;
            DbSet = db.Set<TEntity>();
        }

        public virtual TEntity Adicionar(TEntity obj)
        {
            return DbSet.Add(obj);            
        }

        public virtual TEntity Atualizar(TEntity obj)
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

        public virtual TEntity ObterPorId(Guid id)
        {
            return DbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> ObterTodos()
        {
            return DbSet.ToList();
        }

        public virtual void Remover(Guid Id)
        {
            DbSet.Remove(DbSet.Find(Id));
        }

        public int SaveChanges()
        {
            return db.SaveChanges();
        }
    }
}
