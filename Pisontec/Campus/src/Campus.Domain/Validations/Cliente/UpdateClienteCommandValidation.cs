using Campus.Domain.Commands.Cliente;

namespace Campus.Domain.Validations.Cliente
{
    public class UpdateClienteCommandValidation : ClienteValidation<UpdateClienteCommand>
    {
        public UpdateClienteCommandValidation()
        {
            ValidateId();
            ValidateNome();
            ValidateDataNascimento();
            ValidateEmail();
        }
    }
}