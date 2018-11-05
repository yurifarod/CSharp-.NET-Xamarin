using Campus.Domain.Commands.Pedido;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campus.Domain.Validations.Pedido
{
    public class PedidoValidation<T> 
        : AbstractValidator<T>
        where T : PedidoCommand
    {
        protected void ValidateId()
        {
            RuleFor(p => p.Id)
                .NotEqual(Guid.Empty);
        }

        protected void ValidateData()
        {
            RuleFor(p => p.Data)
                .NotEmpty()
                .WithMessage("Preencha Campo Data!");
        }
    }
}
