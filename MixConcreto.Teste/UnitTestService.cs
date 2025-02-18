using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MixConcreto.Domain.Base;
using MixConcreto.Domain.Entities;
using MixConcreto.Repository.Context;
using MixConcreto.Repository.Repository;
using MixConcreto.Services.Services;
using MixConcreto.Services.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MixConcreto.Teste
{
    [TestClass]
    public class UnitTestService
    {
        private ServiceCollection? services;

        public ServiceProvider ConfigureServices()
        {
            services = new ServiceCollection();
            services.AddDbContext<MySqlContext>(options =>
            {
                var server = "127.0.0.1";
                var port = "3306";
                var database = "MixConcreto";
                var username = "root";
                var password = "BE2505";
                var strCon = $"Server={server}; Port={port}; Database = {database};" +
                    $"Uid={username}; Pwd={password}";

                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);
                });
            });

            services.AddScoped<IBaseRepository<Cliente>, BaseRepository<Cliente>>();
            services.AddScoped<IBaseService<Cliente>, BaseService<Cliente>>();

            services.AddScoped<IBaseRepository<Funcionario>, BaseRepository<Funcionario>>();
            services.AddScoped<IBaseService<Funcionario>, BaseService<Funcionario>>();

            services.AddScoped<IBaseRepository<Estoque>, BaseRepository<Estoque>>();
            services.AddScoped<IBaseService<Estoque>, BaseService<Estoque>>();

            services.AddScoped<IBaseRepository<Veiculo>, BaseRepository<Veiculo>>();
            services.AddScoped<IBaseService<Veiculo>, BaseService<Veiculo>>();

            services.AddScoped<IBaseRepository<Pedido>, BaseRepository<Pedido>>();
            services.AddScoped<IBaseService<Pedido>, BaseService<Pedido>>();

            services.AddScoped<IBaseRepository<Producao>, BaseRepository<Producao>>();
            services.AddScoped<IBaseService<Producao>, BaseService<Producao>>();

            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Cliente, Cliente>();
            }).CreateMapper());

            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Funcionario, Funcionario>();
            }).CreateMapper());

            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Estoque, Estoque>();
            }).CreateMapper());

            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Veiculo, Veiculo>();
            }).CreateMapper());

            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Pedido, Pedido>();
            }).CreateMapper());

            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Producao, Producao>();
            }).CreateMapper());

            return services.BuildServiceProvider();
        }

        [TestMethod]

        public void TestInsertEstoque()
        {
            var sp = ConfigureServices();
            var estoqueService = sp.GetService<IBaseService<Estoque>>();
            var estoque = new Estoque
            {
                Nome = "Areia",
                QuantidadeAtual = 10,
                Unidade = "metros cubicos",
                PrecoUnitario = 190.00f,
                Fornecedor = "Porto da Areia"
            };

            var result = estoqueService.Add<Estoque, Estoque, EstoqueValidator>(estoque);
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]

        public void TestInsertVeiculo()
        {
            var sp = ConfigureServices();
            var veiculoService = sp.GetService<IBaseService<Veiculo>>();
            var veiculo = new Veiculo
            {
                Placa = "DRT-5898",
                Modelo = "Caminhão Mixer - Mercedes",
                Ano = 2023,
                Capacidade = 10,
                Situacao = "Em uso"
            };

            var result = veiculoService.Add<Veiculo, Veiculo, VeiculoValidator>(veiculo);
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]

        public void TestInsertCliente()
        {
            var sp = ConfigureServices();
            var clienteService = sp.GetService<IBaseService<Cliente>>();
            var cliente = new Cliente
            {
                Nome = "Mariana",
                Cpf = "123456789-98",
                Telefone = "18 99144-4444",
                Email = "marilazarini@gmail.com",
                Endereco = "Rua Nova",
                Bairro = "Residencial Novo",
                Cidade = "Birigui"
            };

            var result = clienteService.Add<Cliente, Cliente, ClienteValidator>(cliente);
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]

        public void TestInsertFuncionario()
        {
            var sp = ConfigureServices();
            var funcionarioService = sp.GetService<IBaseService<Funcionario>>();
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
                Status = true
            };

            var result = funcionarioService.Add<Funcionario, Funcionario, FuncionarioValidator>(funcionario);
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]

        public void TestInsertPedido()
        {
            var sp = ConfigureServices();
            var clienteService = sp.GetService<IBaseService<Cliente>>();
            var cliente = clienteService.Get<Cliente>().FirstOrDefault(c => c.Id >= 1);
            var pedidoService = sp.GetService<IBaseService<Pedido>>();
            var pedido = new Pedido
            {
                DataPedido = new DateTime(2025, 02, 14),
                Situacao = "Em Produção",
                ValorTotal = 5000.00f,
                Quantidade = 10.00f,
                Cliente = cliente
            };

            var result = pedidoService.Add<Pedido, Pedido, PedidoValidator>(pedido);
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestInsertProducao()
        {
            var sp = ConfigureServices();
            var pedidoService = sp.GetService<IBaseService<Pedido>>();
            var pedido = pedidoService.Get<Pedido>().FirstOrDefault(i => i.Id >= 1);

            var funcionarioService = sp.GetService<IBaseService<Funcionario>>();
            var funcionario = funcionarioService.Get<Funcionario>().FirstOrDefault(i => i.Id >= 1);

            var veiculoService = sp.GetService<IBaseService<Veiculo>>();
            var veiculo = veiculoService.Get<Veiculo>().FirstOrDefault(p => p.Id >= 1);

            var producaoService = sp.GetService<IBaseService<Producao>>();
            var producao = new Producao
            {
                DataProducao = new DateTime(2025, 02, 14),
                Situacao = "Em Produção",
                Pedido = pedido,
                Funcionario = funcionario,
                Veiculo = veiculo
            };

            var result = producaoService.Add<Producao, Producao, ProducaoValidator>(producao);
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestSelectEstoque()
        {
            var sp = ConfigureServices();
            var estoqueService = sp.GetService<IBaseService<Estoque>>();

            var result = estoqueService.Get<Estoque>();
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestSelectVeiculo()
        {
            var sp = ConfigureServices();
            var veiculoService = sp.GetService<IBaseService<Veiculo>>();

            var result = veiculoService.Get<Veiculo>();
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestSelectCliente()
        {
            var sp = ConfigureServices();
            var clienteService = sp.GetService<IBaseService<Cliente>>();

            var result = clienteService.Get<Cliente>();
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestSelectFuncionario()
        {
            var sp = ConfigureServices();
            var funcionarioService = sp.GetService<IBaseService<Funcionario>>();

            var result = funcionarioService.Get<Funcionario>();
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestSelectPedido()
        {
            var sp = ConfigureServices();
            var pedidoService = sp.GetService<IBaseService<Pedido>>();

            var result = pedidoService.Get<Pedido>();
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestSelectProducao()
        {
            var sp = ConfigureServices();
            var producaoService = sp.GetService<IBaseService<Producao>>();

            var result = producaoService.Get<Producao>();
            Console.Write(JsonSerializer.Serialize(result));
        }
    }
}
