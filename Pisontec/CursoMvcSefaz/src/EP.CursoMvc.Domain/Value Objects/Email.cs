using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.CursoMvc.Domain.Value_Objects
{
    public class Email
    {
        public string Endereco { get; set; }

        public bool Validar()
        {
            return Validar(Endereco);          
        }

        public bool Validar(string email)
        {
            if(!email.Contains("@")) return false;

            return true;
        }
    }
}
