using Campus.Domain.Commands.Pedido;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campus.Domain.Validations.Pedido
{
    public class 
        RegisterNewPedidoCommandValidation
        : PedidoValidation<RegisterNewPedidoCommand>
    {
        public RegisterNewPedidoCommandValidation()
        {
            ValidateId();
            ValidateData();
        }
    }
}
