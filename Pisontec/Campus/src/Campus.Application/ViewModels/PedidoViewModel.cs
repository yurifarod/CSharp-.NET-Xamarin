using Campus.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Campus.Application.ViewModels
{
    public class PedidoViewModel
    {
        public PedidoViewModel()
        {
            Id = Guid.NewGuid();
            Itens = new List<ItensViewModel>();
        }
        [Key]
        public Guid Id { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime Data { get; set; }
                                       
        [Required(ErrorMessage = "Valor não foi contabilizado")]
        public decimal Valor { get; set; }

        public virtual ICollection<ItensViewModel>
            Itens
        { get; set; }

        [ScaffoldColumn(false)]
        public Guid ClienteId { get; set; }

        public List<Cliente> Cliente { get; set; }

    }
}
