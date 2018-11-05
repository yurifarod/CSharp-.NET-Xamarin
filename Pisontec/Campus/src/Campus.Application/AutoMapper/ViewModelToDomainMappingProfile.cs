using AutoMapper;
using Campus.Application.ViewModels;
using Campus.Domain.Commands.Cliente;
using Campus.Domain.Models;

namespace Campus.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ClienteViewModel, RegisterNewClienteCommand>()
                .ConstructUsing(c => new RegisterNewClienteCommand(c.Nome, c.Email, c.DataNascimento));
            CreateMap<ClienteViewModel, UpdateClienteCommand>()
                .ConstructUsing(c => new UpdateClienteCommand(c.Id, c.Nome, c.Email, c.DataNascimento));
            CreateMap<PedidoViewModel, Pedido>();
            CreateMap<ItensViewModel, Itens>();
        }
    }
}
