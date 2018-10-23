using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SEFAZ.CursoMvc.Domain.Interfaces.Repository
{
    public interface IRepository <TEntity> : IDisposable where TEntity : class
    {
        TEntity Adicionar(TEntity obj);
        TEntity ObterPorId(Guid guid);
        TEntity Atualizar(TEntity obj);
        IEnumerable<TEntity> ObterTodos();
        void Remover(Guid guid);
        IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate);
        int SaveChanges();
    }
}
