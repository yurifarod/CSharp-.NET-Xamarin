using DomainValidation.Validation;
using EP.CursoMvc.Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.CursoMvc.Domain.Validations.Clientes
{
    public class ClienteEstaConsistenteValidation : Validator<Cliente>
    {
        public ClienteEstaConsistenteValidation()
        {
            var CPFValido = new Specifications.Clientes.ClienteDeveTerCpfValidoSpecification();
            var clienteEmail = new Specifications.Clientes.ClienteDeveTerEmailValidoSpecification();
            var clienteMaioridade = new Specifications.Clientes.ClienteDeveSerMaiorDeIdadeSpecification();

            this.Add("CPFValido", new Rule<Cliente>(CPFValido, "CPF inválido."));
            this.Add("clienteEmail", new Rule<Cliente>(clienteEmail, "E-mail inválido."));
            this.Add("clienteMaioridade", new Rule<Cliente>(clienteMaioridade, "Menor de idade."));
        }
    }
}
