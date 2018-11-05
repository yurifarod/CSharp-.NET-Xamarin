using DomainValidation.Validation;
using EP.CursoMvc.Domain.Entitites;
using EP.CursoMvc.Domain.Interfaces.Repository;
using EP.CursoMvc.Domain.Specifications.Clientes;

namespace EP.CursoMvc.Domain.Validations.Clientes
{
    public class ClienteAptoParaCadastroValidation : Validator<Cliente>
    {
        public ClienteAptoParaCadastroValidation(IFiliacaoRepository filiacaoRepository)
        {
            var cpfDuplicado = new ClienteDevePossuirCPFUnicoSpecification(filiacaoRepository);
            var emailDuplicado = new ClienteDevePossuirEmailUnicoSpecification(filiacaoRepository);

            base.Add("cpfDuplicado", new Rule<Cliente>(cpfDuplicado, "CPF já cadastrado! Esqueceu sua senha?"));
            base.Add("emailDuplicado", new Rule<Cliente>(emailDuplicado, "E-mail já cadastrado! Esqueceu sua senha?"));
        }
    }
}
