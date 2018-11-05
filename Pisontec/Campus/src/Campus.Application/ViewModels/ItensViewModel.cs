using Campus.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Campus.Application.ViewModels
{
    public class ItensViewModel
    {
        public ItensViewModel()
        {
            Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Quantidade Requerida")]

        public int Quantidade { get; set; }

        [Required(ErrorMessage = "Preencha Descrição do Produto")]
        public string Produto { get; set; }

        [Required(ErrorMessage = "Valor Unitário Requerido!")]
        public decimal ValorUnitario { get; set; }

        [ScaffoldColumn(false)]
        public Guid PedidoId { get; set; }
    }
}
