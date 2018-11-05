using System;
using Campus.Domain.Commands.Cliente;
using FluentValidation;

namespace Campus.Domain.Validations.Cliente
{
    public abstract class ClienteValidation<T> : AbstractValidator<T> where T : ClienteCommand
    {
        protected void ValidateNome()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor preencha o Nome")
                .Length(2, 150).WithMessage("O nome deve estar entre 2 e 150 caracteres");
        }

        protected void ValidateDataNascimento()
        {
            RuleFor(c => c.DataNascimento)
                .NotEmpty()
                .Must(HaveMinimumAge)
                .WithMessage("O cliente deve ter 18 anos no mínimo");
        }

        protected void ValidateEmail()
        {
            RuleFor(c => c.Email)
                .NotEmpty()
                .EmailAddress();
        }

        protected void ValidateId()
        {
            RuleFor(c => c.Id)
                .NotEqual(Guid.Empty);
        }

        protected static bool HaveMinimumAge(DateTime birthDate)
        {
            return birthDate <= DateTime.Now.AddYears(-18);
        }
    }
}