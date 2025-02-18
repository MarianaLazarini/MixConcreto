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
    public class EstoqueMap : IEntityTypeConfiguration<Estoque>
    {
        public void Configure(EntityTypeBuilder<Estoque> builder)
        {
            builder.ToTable("Estoque");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(prop => prop.QuantidadeAtual)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(prop => prop.Unidade)
               .IsRequired()
               .HasColumnType("varchar(20)");

            builder.Property(prop => prop.PrecoUnitario)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(prop => prop.Fornecedor)
               .IsRequired()
               .HasColumnType("varchar(50)");

        }
    }
}
