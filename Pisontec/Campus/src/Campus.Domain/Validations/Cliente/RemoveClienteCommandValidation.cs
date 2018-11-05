using Campus.Domain.Commands.Cliente;

namespace Campus.Domain.Validations.Cliente
{
    public class RemoveClienteCommandValidation : ClienteValidation<RemoveClienteCommand>
    {
        public RemoveClienteCommandValidation()
        {
            ValidateId();
        }
    }
}