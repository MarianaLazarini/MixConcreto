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
    public class ProducaoMap : IEntityTypeConfiguration<Producao>
    {
        public void Configure(EntityTypeBuilder<Producao> builder)
        {
            builder.ToTable("Producao");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Situacao)
               .IsRequired()
               .HasColumnType("varchar(30)");

            builder.Property(prop => prop.DataProducao)
               .IsRequired()
               .HasColumnType("DATE");

            builder.HasOne(prop => prop.Pedido);

            builder.HasOne(prop => prop.Funcionario);

            builder.HasOne(prop => prop.Veiculo);
        }
    }
}
