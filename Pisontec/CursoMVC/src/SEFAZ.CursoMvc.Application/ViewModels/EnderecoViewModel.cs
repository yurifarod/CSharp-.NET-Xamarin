using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFAZ.CursoMvc.Application.ViewModels
{
    public class EnderecoViewModel
    {
        public EnderecoViewModel()
        {
            EnderecoId = Guid.NewGuid();
        }

        [Key]
        public Guid EnderecoId { get; set; }
        [Required(ErrorMessage ="Logradouro Requerido")]
        public string Logradouro { get; set; }
        [Required(ErrorMessage = "Número Requerido")]
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        [ScaffoldColumn(false)]
        public Guid ClienteId { get; set; }
        public virtual ClienteViewModel Cliente { get; set; }
    }
}
