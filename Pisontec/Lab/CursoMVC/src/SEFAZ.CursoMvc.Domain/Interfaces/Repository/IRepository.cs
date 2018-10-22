using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFAZ.CursoMvc.Domain.Interfaces.Repository
{
    public interface IRepository <TEntity> : IDisposable where TEntity : class
    {
        TEntity Adcionar(TEntity obj);
        TEntity GetEntity();
        TEntity Editar(TEntity obj);
        TEntity Remover(TEntity obj);
    }
}
