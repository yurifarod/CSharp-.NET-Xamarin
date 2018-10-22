using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MinhaPrimeiraAppMVC.Models
{
    public class TarefaContexto : DbContext
    {
        public TarefaContexto() : base("TarefasContexto")
        { }

        public DbSet<Lista> Listas { get; set; }
        public DbSet<Tarefas> Tarefas { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}