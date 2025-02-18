using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MixConcreto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixConcreto.Repository.Mapping
{
    public class PedidoMap : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("Pedido");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Situacao)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(prop => prop.ValorTotal)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(prop => prop.Quantidade)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(prop => prop.DataPedido)
                .IsRequired()
                .HasColumnType("DATE");

            builder.HasOne(prop => prop.Cliente);

        }

    }
}
