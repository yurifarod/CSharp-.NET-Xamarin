using AutoMapper;
using Campus.Application.ViewModels;
using Campus.Domain.Models;

namespace Campus.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<Pedido, PedidoViewModel>();
            CreateMap<Itens, ItensViewModel>();
        }
    }
}
