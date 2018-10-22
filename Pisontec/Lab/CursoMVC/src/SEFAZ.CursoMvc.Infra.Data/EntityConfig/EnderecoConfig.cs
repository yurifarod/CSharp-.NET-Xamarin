using SEFAZ.CursoMvc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFAZ.CursoMvc.Infra.Data.EntityConfig
{
    class EnderecoConfig : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfig()
        {
            HasKey(e => e.EnderecoId);

            Property(e => e.Logradouro).IsRequired().HasMaxLength(200).HasColumnType("varchar");
            Property(e => e.Numero).IsRequired().HasMaxLength(10).HasColumnType("varchar");
            Property(e => e.CEP).IsRequired().HasMaxLength(8).HasColumnType("varchar").IsFixedLength();
            Property(e => e.Bairro).IsRequired().HasMaxLength(200).HasColumnType("varchar");
            Property(e => e.Cidade).IsRequired().HasMaxLength(200).HasColumnType("varchar");
            Property(e => e.Estado).IsRequired().HasMaxLength(50).HasColumnType("varchar");

            HasRequired(e => e.Cliente).WithMany(c => c.Enderecos).HasForeignKey(e => e.ClienteId);

            ToTable("Endereco");
        }
    }
}
