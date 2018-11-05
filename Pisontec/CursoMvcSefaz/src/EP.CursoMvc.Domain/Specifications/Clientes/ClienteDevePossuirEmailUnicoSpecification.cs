using DomainValidation.Interfaces.Specification;
using EP.CursoMvc.Domain.Entitites;
using EP.CursoMvc.Domain.Interfaces.Repository;

namespace EP.CursoMvc.Domain.Specifications.Clientes
{
    public class ClienteDevePossuirEmailUnicoSpecification : ISpecification<Cliente>
    {
        private readonly IFiliacaoRepository _filiacaoRepository;

        public ClienteDevePossuirEmailUnicoSpecification(IFiliacaoRepository filiacaoRepository)
        {
            _filiacaoRepository = filiacaoRepository;
        }

        public bool IsSatisfiedBy(Cliente cliente)
        {
            return _filiacaoRepository.ObterPorEmail(cliente.Email.Endereco) == null;
        }
    }
}
