using System;
using Campus.Domain.Validations.Cliente;

namespace Campus.Domain.Commands.Cliente
{
    public class RegisterNewClienteCommand : ClienteCommand
    {
        public RegisterNewClienteCommand(string nome, string email, DateTime dataNascimento)
        {
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
        }

        public override bool IsValid()
        {
            ValidationResult = new RegisterNewClienteCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}