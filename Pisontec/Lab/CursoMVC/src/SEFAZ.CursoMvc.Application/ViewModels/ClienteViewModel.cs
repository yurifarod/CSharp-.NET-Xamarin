using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFAZ.CursoMvc.Application.ViewModels
{
    public class ClienteViewModel
    {
        public ClienteViewModel()
        {
            ClienteId = Guid.NewGuid();
            Enderecos = new List<EnderecoViewModel>();
        }

        [Key]
        public Guid ClienteId { set; get; }
        [Required(ErrorMessage ="Campo NOME requerido, meu parça!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo CPF requerido, meu parça!"), StringLength(11, ErrorMessage = "Tamanho do CPF Incorreto")]
        public string CPF { get; set; }
        [Required(ErrorMessage = "Campo EMAIL requerido, meu parça!"), DisplayName("E-mail")]
        public string Email { get; set; }
        public virtual ICollection<EnderecoViewModel> Enderecos { get; set; }
        [DataType(DataType.Date, ErrorMessage ="O campo não respeita o formato data")]
        public DateTime DataCadastro { get; set; }
        [DataType(DataType.Date), Required(ErrorMessage = "Campo Data de Nascimento requerido, meu parça!")]
        public DateTime DataNascimento { get; set; }
        public bool Ativo { get; set; }
    }
}
