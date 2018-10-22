using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MinhaPrimeiraAppMVC.Models
{
    public class Usuarios
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public int Ativo { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Lista> Listas { get; set; }

    }
}