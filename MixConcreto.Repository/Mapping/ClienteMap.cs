using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MixConcreto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixConcreto.Repository.Mapping
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Cpf)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.Property(prop => prop.Telefone)
                .HasColumnType("varchar(20)");

            builder.Property(prop => prop.Email)
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Endereco)
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Bairro)
                .HasColumnType("varchar(50)");

            builder.Property(prop => prop.Cidade)
                .HasColumnType("varchar(50)");
        }
    }
}
