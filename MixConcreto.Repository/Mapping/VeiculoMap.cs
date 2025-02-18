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
    public class VeiculoMap : IEntityTypeConfiguration<Veiculo>
    {
        public void Configure(EntityTypeBuilder<Veiculo> builder)
        {
            builder.ToTable("Veiculo");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Placa)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.Property(prop => prop.Modelo)
               .IsRequired()
               .HasColumnType("varchar(40)");

            builder.Property(prop => prop.Capacidade)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(prop => prop.Ano)
               .IsRequired()
               .HasColumnType("int");

            builder.Property(prop => prop.Situacao)
               .IsRequired()
               .HasColumnType("varchar(30)");
        }

    }
}
