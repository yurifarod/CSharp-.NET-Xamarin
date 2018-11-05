using System;
using System.Collections.Generic;
using Campus.Domain.Core.Models;

namespace Campus.Domain.Models
{
    public class Cliente : Entity
    {
        public Cliente(Guid id, string nome, string email, DateTime dataNascimento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            Pedidos = new List<Pedido>();
        }

        // Empty constructor for EF
        protected Cliente() { }

        public string Nome { get; private set; }

        public string Email { get; private set; }

        public DateTime DataNascimento { get; private set; }

        //adicionar depois antes da parte final da aplicação

        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}