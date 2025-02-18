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
    public class FuncionarioMap : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("Funcionario");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Cpf)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.Property(prop => prop.Telefone)
                .HasColumnType("varchar(20)");

            builder.Property(prop => prop.Cargo)
                .HasColumnType("varchar(40)");

            builder.Property(prop => prop.Endereco)
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Bairro)
                .HasColumnType("varchar(50)");

            builder.Property(prop => prop.Cidade)
                .HasColumnType("varchar(50)");

            builder.Property(prop => prop.Salario)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(prop => prop.Status)
                .IsRequired()
                .HasColumnType("BINARY");

            builder.Property(prop => prop.DataAdmissao)
                .IsRequired()
                .HasColumnType("DATE");

        }
    }
}
