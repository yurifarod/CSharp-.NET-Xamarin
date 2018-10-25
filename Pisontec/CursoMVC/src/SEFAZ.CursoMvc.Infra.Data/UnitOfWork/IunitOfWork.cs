using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFAZ.CursoMvc.Infra.Data.UnitOfWork
{
    public interface IunitOfWork
    {
        void Commit();
    }
}
