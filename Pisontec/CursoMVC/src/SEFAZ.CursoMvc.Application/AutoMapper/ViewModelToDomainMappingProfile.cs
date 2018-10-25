using AutoMapper;
using SEFAZ.CursoMvc.Application.ViewModels;
using SEFAZ.CursoMvc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFAZ.CursoMvc.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            /*CreateMap<ClienteViewModel, Cliente>()
                .ForMember(dest => dest.Email, opt => opt.ResolveUsing(model => new Email() { Endereco = model.Email }));*/

            CreateMap<ClienteEnderecoViewModel, Cliente>();
            CreateMap<EnderecoViewModel, Endereco>();
            CreateMap<ClienteEnderecoViewModel, Endereco>();
        }

        /*private class Email
        {
            public Email()
            {
            }

            public string Endereco { get; set; }
        }*/
    }
}
