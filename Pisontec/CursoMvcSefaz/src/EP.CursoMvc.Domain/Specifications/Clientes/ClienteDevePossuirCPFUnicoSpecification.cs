using System;
using DomainValidation.Interfaces.Specification;
using EP.CursoMvc.Domain.Entitites;
using EP.CursoMvc.Domain.Interfaces.Repository;

namespace EP.CursoMvc.Domain.Specifications.Clientes
{
    public class ClienteDevePossuirCPFUnicoSpecification : ISpecification<Cliente>
    {
        private readonly IFiliacaoRepository _filiacaoRepository;

        public ClienteDevePossuirCPFUnicoSpecification(IFiliacaoRepository filiacaoRepository)
        {
            _filiacaoRepository = filiacaoRepository;
        }

        public bool IsSatisfiedBy(Cliente cliente)
        {
            return _filiacaoRepository.ObterPorCpf(cliente.CPF.Numero) == null;
        }
    }
}
