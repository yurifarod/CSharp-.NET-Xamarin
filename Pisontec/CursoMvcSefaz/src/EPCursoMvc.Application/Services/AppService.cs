using EP.CursoMvc.Infra.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPCursoMvc.Application.Services
{
    public class AppService
    {
        private readonly IUnitOfWork _uow;

        public AppService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        protected void Commit()
        {
            _uow.Commit();
        }
    }
}
