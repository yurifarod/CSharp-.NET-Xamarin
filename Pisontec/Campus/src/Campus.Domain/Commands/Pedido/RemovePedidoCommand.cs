using Campus.Domain.Validations.Pedido;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campus.Domain.Commands.Pedido
{
    public class RemovePedidoCommand
        : PedidoCommand
    {
        public RemovePedidoCommand(Guid id)
        {
            Id = id;
        }

        public override bool IsValid()
        {
            ValidationResult =
                new RemovePedidoCommandValidation()
                .Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
