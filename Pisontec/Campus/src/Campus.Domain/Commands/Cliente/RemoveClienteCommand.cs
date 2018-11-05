using System;
using Campus.Domain.Validations.Cliente;

namespace Campus.Domain.Commands.Cliente
{
    public class RemoveClienteCommand : ClienteCommand
    {
        public RemoveClienteCommand(Guid id)
        {
            Id = id;
            AggregateId = id;
        }

        public override bool IsValid()
        {
            ValidationResult = new RemoveClienteCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}