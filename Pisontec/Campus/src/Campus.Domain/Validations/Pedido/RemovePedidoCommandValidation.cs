using Campus.Domain.Commands.Pedido;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campus.Domain.Validations.Pedido
{
    public class 
        RemovePedidoCommandValidation
        : PedidoValidation<RemovePedidoCommand>
    {
        public RemovePedidoCommandValidation()
        {
            ValidateId();
        }
    }
}
