using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MinhaPrimeiraAppMVC.Models
{
    public class Lista
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Ativa { get; set; }
        public Usuarios Usuario { get; set; }
        public int UsuarioId { get; set; }
        public ICollection<Tarefas> Tarefas { get; set; }
        public DateTime? Prazo { get; set; } 
    }
}