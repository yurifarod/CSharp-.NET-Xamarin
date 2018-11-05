using Campus.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campus.Infra.Data.Mappings
{
    public class PedidoMap :
        IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.Property(p => p.Id)
                .HasColumnName("Id");

            builder.Property(p => p.Valor)
                .HasColumnName("ValorTotal");
                
        }
    }
}
