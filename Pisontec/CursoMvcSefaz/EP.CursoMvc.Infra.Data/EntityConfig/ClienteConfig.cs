using EP.CursoMvc.Domain.Entitites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.CursoMvc.Infra.Data.EntityConfig
{
    //Fluent API

    public class ClienteConfig : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfig()
        {
            HasKey(c => c.ClienteId);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnType("varchar");

            Property(c => c.CPF.Numero)
                .HasColumnName("CPF")
                .IsRequired()
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_CPF") { IsUnique = true }));

            Property(c => c.Email.Endereco)
                .HasColumnName("Email")
                .IsRequired()
                .HasMaxLength(100);

            Property(c => c.DataNascimento)
                .IsRequired();

            Property(c => c.Ativo)
                .IsRequired();

            Ignore(c => c.ValidationResult);

            ToTable("Clientes", "Sistema");

        }
    }
}
