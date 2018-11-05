using Campus.Domain.Validations.Pedido;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campus.Domain.Commands.Pedido
{
    public class RegisterNewPedidoCommand : PedidoCommand
    {
        public RegisterNewPedidoCommand(
            Guid id, 
            DateTime data, 
            decimal valor)
        {
            Id = id;
            Data = data;
            Valor = valor;
        }

        public override bool IsValid()
        {
            ValidationResult = 
                new 
                RegisterNewPedidoCommandValidation()
                .Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
