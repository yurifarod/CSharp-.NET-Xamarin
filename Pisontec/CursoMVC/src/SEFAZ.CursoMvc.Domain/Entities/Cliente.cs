using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFAZ.CursoMvc.Domain.Entities
{
    public class Cliente
    {
        public Cliente()
        {
            ClienteId = Guid.NewGuid();
            Enderecos = new List<Endereco>();
        }

        public Guid ClienteId { set; get; }
        public string Nome { set; get; }
        public string CPF { set; get; }
        public string Email { set; get; }
        public DateTime DataCadastro { set; get; }
        public DateTime DataNascimento { set; get; }
        public bool Ativo { set; get; }
        public virtual ICollection<Endereco> Enderecos { get; set; }

    }
}
