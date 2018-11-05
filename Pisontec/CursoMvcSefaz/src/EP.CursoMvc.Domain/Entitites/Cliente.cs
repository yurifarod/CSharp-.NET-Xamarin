using DomainValidation.Validation;
using EP.CursoMvc.Domain.Validations.Clientes;
using EP.CursoMvc.Domain.Value_Objects;
using System;
using System.Collections.Generic;

namespace EP.CursoMvc.Domain.Entitites
{
    public class Cliente
    {
        public Cliente()
        {
            this.ClienteId = Guid.NewGuid();
            Enderecos = new List<Endereco>();
        }

        public Guid ClienteId { get; set; }

        public string Nome { get; set; }

        public CPF CPF { get; set; }

        public Email Email { get; set; }

        public DateTime DataNascimento { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        public virtual ICollection<Endereco> Enderecos { get; set; }

        public ValidationResult ValidationResult { get; set; }

        public bool EhValido()
        {
            ValidationResult = new ClienteEstaConsistenteValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
