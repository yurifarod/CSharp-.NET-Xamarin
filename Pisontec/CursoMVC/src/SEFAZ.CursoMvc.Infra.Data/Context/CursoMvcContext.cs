using SEFAZ.CursoMvc.Domain.Entities;
using SEFAZ.CursoMvc.Infra.Data.EntityConfig;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFAZ.CursoMvc.Infra.Data.Context
{
    public class CursoMvcContext : DbContext
    {
        public CursoMvcContext() : base("DefaultConnection")
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            //Aqui ele tá dizendo que o Campo = Nome do Tipo acompanhado da palavra Id, é campo chave
            modelBuilder.Properties().Where(p => p.Name == p.ReflectedType.Name + "Id").Configure(p => p.IsKey());
            //Configura que todo campo strig vai como varchar
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
            //O tamanho máximo dos campos do tipo string será 100
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new ClienteConfig());
            modelBuilder.Configurations.Add(new EnderecoConfig());
            base.OnModelCreating(modelBuilder);
        }


    }
}
