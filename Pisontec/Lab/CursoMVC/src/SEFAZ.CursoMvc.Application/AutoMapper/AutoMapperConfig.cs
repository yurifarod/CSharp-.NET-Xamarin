using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFAZ.CursoMvc.Application.AutoMapper
{
    public class AutoMapperConfig
    {
        public void RegisterMappings()
        {
            Mapper.Initialize( x=> 
            {
                x.AddProfile<DomainToViewModelMappingProfile>();
                x.AddProfile<ViewModelToDomainMappingProfile>();
            }
            );
        }
    }
}
