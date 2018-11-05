using Campus.Domain.Validations.Pedido;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campus.Domain.Commands.Pedido
{
    public class UpdatePedidoCommand
        : PedidoCommand
    {
        public UpdatePedidoCommand(Guid id, 
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
                UpdatePedidoCommandValidation()
                .Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
