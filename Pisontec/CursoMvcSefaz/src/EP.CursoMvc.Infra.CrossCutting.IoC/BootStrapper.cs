using EP.CursoMvc.Domain.Interfaces.Repository;
using EP.CursoMvc.Domain.Interfaces.Services;
using EP.CursoMvc.Domain.Services;
using EP.CursoMvc.Infra.Data.Context;
using EP.CursoMvc.Infra.Data.Repository;
using EP.CursoMvc.Infra.Data.UnitOfWork;
using EPCursoMvc.Application.Interfaces;
using EPCursoMvc.Application.Services;
using SimpleInjector;

namespace EP.CursoMvc.Infra.CrossCutting.IoC
{
    public class BootStrapper
    {
        //Lifestyle.Transient - Uma instância para cada solicitação 
        //Lifestyle.Singleton - Uma instância única para a classe
        //Lifestyle.Scoped - Uma instância única para a request

        public static void Register(Container container)
        {
            //APP
            container.Register<IFiliacaoAppService, FiliacaoAppService>(Lifestyle.Scoped);

            //DOMAIN
            container.Register<IFiliacaoService, FiliacaoService>(Lifestyle.Scoped);

            //DATA
            container.Register<IFiliacaoRepository, FiliacaoRepository>(Lifestyle.Scoped);

            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);
            container.Register<CursoMvcContext>(Lifestyle.Scoped);
        }
    }
}
