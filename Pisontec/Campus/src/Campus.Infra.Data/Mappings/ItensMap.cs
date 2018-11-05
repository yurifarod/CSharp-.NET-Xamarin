using Campus.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campus.Infra.Data.Mappings
{
    public class ItensMap :
        IEntityTypeConfiguration<Itens>
    {
        public void Configure
            (EntityTypeBuilder<Itens> builder)
        {
            builder.Property(i => i.Id)
                .HasColumnName("Id");

            builder.Property(i => i.Produto)
                .HasColumnType("varchar(100)")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(i => i.Quantidade)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(i => i.ValorUnitario)
                .IsRequired();
        }
    }
}
