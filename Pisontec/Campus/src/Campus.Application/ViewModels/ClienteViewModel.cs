using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Campus.Application.ViewModels
{
    public class ClienteViewModel
    {

        public ClienteViewModel()
        {
            Id = Guid.NewGuid();
            Pedidos = new List<PedidoViewModel>();
        }
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nome Requerido!")]
        [MinLength(2)]
        [MaxLength(100)]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Email Requerido")]
        [EmailAddress]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Data de Nascimento requerida")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        [DisplayName("Data Nascimento")]
        public DateTime DataNascimento { get; set; }

        public virtual ICollection<PedidoViewModel>
            Pedidos
        { get; set; }
    }
}
