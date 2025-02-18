using Microsoft.EntityFrameworkCore;
using MixConcreto.Domain.Entities;
using MixConcreto.Repository.Mapping;
using System.Diagnostics.Contracts;


namespace MixConcreto.Repository.Context
{
    public class MySqlContext :DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
            Database.EnsureCreated(); // Cria o banco caso não exista
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Estoque> Estoques { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Producao> Producaos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cliente>(new ClienteMap().Configure);
            modelBuilder.Entity<Funcionario>(new FuncionarioMap().Configure);
            modelBuilder.Entity<Veiculo>(new VeiculoMap().Configure);
            modelBuilder.Entity<Estoque>(new EstoqueMap().Configure);
            modelBuilder.Entity<Pedido>(new PedidoMap().Configure);
            modelBuilder.Entity<Producao>(new ProducaoMap().Configure);

        }
    }
}
