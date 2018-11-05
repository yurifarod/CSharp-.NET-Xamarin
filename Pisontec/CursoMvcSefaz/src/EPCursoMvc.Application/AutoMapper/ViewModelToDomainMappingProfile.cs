using AutoMapper;
using EP.CursoMvc.Domain.Entitites;
using EP.CursoMvc.Domain.Value_Objects;
using EPCursoMvc.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPCursoMvc.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<ClienteViewModel, Cliente>()
                .ForMember(dest => dest.CPF, opt => opt.ResolveUsing(model => new CPF() { Numero = model.CPF }))
                .ForMember(dest => dest.Email, opt => opt.ResolveUsing(model => new Email() { Endereco = model.Email }));

            CreateMap<ClienteEnderecoViewModel, Cliente>();
            CreateMap<EnderecoViewModel, Endereco>();
            CreateMap<ClienteEnderecoViewModel, Endereco>();
        }
    }   
}
