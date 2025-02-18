using Microsoft.EntityFrameworkCore;
using MixConcreto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MixConcreto.Teste
{
    [TestClass]
    public class UnitTestRepository
    {
        public partial class MyDbContext : DbContext
        {
            public DbSet<Cliente> Clientes { get; set; }
            public DbSet<Funcionario> Funcionarios { get; set; }
            public DbSet<Pedido> Pedidos { get; set; }
            public DbSet<Veiculo> Veiculos { get; set; }
            public DbSet<Producao> Producoes { get; set; }
            public DbSet<Estoque> Estoques { get; set; }

            public MyDbContext()
            {
                Database.EnsureCreated();
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                var server = "127.0.0.1";
                var port = "3306";
                var database = "MixConcreto";
                var username = "root";
                var password = "Mari040304*";
                var strCon = $"Server={server};Port={port};Database={database};" +
                    $"Uid={username};Pwd={password}";
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseMySql(strCon, ServerVersion.AutoDetect(strCon));
                }
            }
        }

        [TestMethod]

        public void TestInsertCliente()
        {
            using (var context = new MyDbContext())
            {
                var cliente = new Cliente
                {
                    Nome = "Mariana",
                    Cpf = "123456789-98",
                    Telefone = "18 99144-4444",
                    Email = "marilazarini@gmail.com",
                    Endereco = "Rua Nova",
                    Bairro = "Residencial Novo",
                    Cidade = "Birigui",
                };

                context.Clientes.Add(cliente);

                context.SaveChanges();

            }
        }

        [TestMethod]
        public void TestListCliente()
        {
            using (var context = new MyDbContext())
            {
                foreach (var cliente in context.Clientes)
                {
                    Console.WriteLine(JsonSerializer.Serialize(cliente));
                }
            }
        }

        [TestMethod]

        public void TestInsertFuncionario()
        {
            using (var context = new MyDbContext())
            {
                var funcionario = new Funcionario
                {
                    Nome = "Mariana",
                    DataAdmissao = new DateTime(2025, 02, 02),
                    Cpf = "123456789-98",
                    Telefone = "18 99144-4444",
                    Endereco = "Rua Nova",
                    Bairro = "Residencial Novo",
                    Cidade = "Birigui",
                    Cargo = "Auditor",
                    Salario = 2500.00f,
                    Status = true,
                };

                context.Funcionarios.Add(funcionario);

                context.SaveChanges();

            }
        }

        [TestMethod]
        public void TestListFuncionario()
        {
            using (var context = new MyDbContext())
            {
                foreach (var funcionario in context.Funcionarios)
                {
                    Console.WriteLine(JsonSerializer.Serialize(funcionario));
                }
            }
        }

        [TestMethod]

        public void TestInsertVeiculo()
        {
            using (var context = new MyDbContext())
            {
                var veiculo = new Veiculo
                {
                    Placa = "DRT-5898",
                    Modelo = "Caminhão Mixer - Mercedes",
                    Ano = 2023,
                    Capacidade = 10.00f,
                    Situacao = "Em uso",
                };

                context.Veiculos.Add(veiculo);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListVeiculo()
        {
            using (var context = new MyDbContext())
            {
                foreach (var veiculo in context.Veiculos)
                {
                    Console.WriteLine(JsonSerializer.Serialize(veiculo));
                }
            }
        }


        [TestMethod]

        public void TestInsertEstoque()
        {
            using (var context = new MyDbContext())
            {
                var estoque = new Estoque
                {
                    Nome = "Areia",
                    QuantidadeAtual = 10.00f,
                    Unidade = "metros cubicos",
                    PrecoUnitario = 190.00f,
                    Fornecedor = "Porto da Areia",
                };

                context.Estoques.Add(estoque);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListEstoque()
        {
            using (var context = new MyDbContext())
            {
                foreach (var estoque in context.Estoques)
                {
                    Console.WriteLine(JsonSerializer.Serialize(estoque));
                }
            }
        }

        [TestMethod]

        public void TestInsertPedido()
        {
            using (var context = new MyDbContext())
            {
                var cliente = context.Clientes.FirstOrDefault(i => i.Id == 1);

                var pedido = new Pedido
                {
                    DataPedido = new DateTime(2025, 02, 14),
                    Situacao = "Em Produção",
                    ValorTotal = 5000.00f,
                    Quantidade = 10.00f,
                    Cliente = cliente
                };

                context.Pedidos.Add(pedido);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListPedido()
        {
            using (var context = new MyDbContext())
            {
                foreach (var pedido in context.Pedidos)
                {
                    Console.WriteLine(JsonSerializer.Serialize(pedido));
                }
            }
        }

        [TestMethod]

        public void TestInsertProducao()
        {
            using (var context = new MyDbContext())
            {
                var funcionario = context.Funcionarios.FirstOrDefault(i => i.Id == 1);
                var pedido = context.Pedidos.FirstOrDefault(i => i.Id == 1);
                var veiculo = context.Veiculos.FirstOrDefault(i => i.Id == 1);

                var producao = new Producao
                {
                    DataProducao = new DateTime(2025, 02, 14),
                    Situacao = "Em Produção",
                    Pedido = pedido,
                    Funcionario = funcionario,
                    Veiculo = veiculo,
                };

                context.Producoes.Add(producao);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListProducao()
        {
            using (var context = new MyDbContext())
            {
                foreach (var producao in context.Producoes)
                {
                    Console.WriteLine(JsonSerializer.Serialize(producao));
                }
            }
        }
    }
}
