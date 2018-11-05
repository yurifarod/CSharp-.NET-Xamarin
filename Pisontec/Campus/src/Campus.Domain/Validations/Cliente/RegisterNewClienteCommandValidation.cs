using Campus.Domain.Commands.Cliente;

namespace Campus.Domain.Validations.Cliente
{
    public class RegisterNewClienteCommandValidation : ClienteValidation<RegisterNewClienteCommand>
    {
        public RegisterNewClienteCommandValidation()
        {
            ValidateNome();
            ValidateDataNascimento();
            ValidateEmail();
        }
    }
}