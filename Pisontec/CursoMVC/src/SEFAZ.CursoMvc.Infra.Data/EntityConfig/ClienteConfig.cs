using SEFAZ.CursoMvc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFAZ.CursoMvc.Infra.Data.EntityConfig
{
    public class ClienteConfig : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfig()
        {
            HasKey(c => c.ClienteId);
            Property(c => c.Nome).IsRequired().HasMaxLength(150).HasColumnType("varchar");
            Property(c => c.CPF).IsRequired().HasMaxLength(11).HasColumnType("varchar").IsFixedLength();
            Property(c => c.Email).IsRequired().HasMaxLength(150).HasColumnType("varchar");
            Property(c => c.DataNascimento).IsRequired();

            ToTable("Clientes");

        }
    }
}
