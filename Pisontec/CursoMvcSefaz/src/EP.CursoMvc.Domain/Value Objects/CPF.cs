using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.CursoMvc.Domain.Value_Objects
{
    public class CPF
    {
        public string Numero { get; set; }

        public bool Validar()
        {
            return Validar(this.Numero);
        }

        public bool Validar(string cpf)
        {
            if (cpf.Length < 11) return false;

            return true;
        }
    }
}
