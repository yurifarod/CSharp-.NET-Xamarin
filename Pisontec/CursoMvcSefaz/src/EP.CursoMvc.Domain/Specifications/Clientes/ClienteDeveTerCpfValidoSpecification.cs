using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainValidation.Interfaces.Specification;
using EP.CursoMvc.Domain.Entitites;

namespace EP.CursoMvc.Domain.Specifications.Clientes
{
    public class ClienteDeveTerCpfValidoSpecification : ISpecification<Cliente>
    {
        public bool IsSatisfiedBy(Cliente cliente)
        {
            return cliente.CPF.Validar();
        }
    }
}
