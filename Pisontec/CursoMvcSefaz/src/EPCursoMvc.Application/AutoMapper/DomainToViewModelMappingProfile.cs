using AutoMapper;
using EP.CursoMvc.Domain.Entitites;
using EPCursoMvc.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPCursoMvc.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Cliente, ClienteViewModel>()
                .ForMember(dest => dest.CPF, opt => opt.MapFrom(src => src.CPF.Numero))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email.Endereco));

            CreateMap<Cliente, ClienteEnderecoViewModel>();
            CreateMap<Endereco, EnderecoViewModel>();
            CreateMap<Endereco, ClienteEnderecoViewModel>();
        }
    }
}
