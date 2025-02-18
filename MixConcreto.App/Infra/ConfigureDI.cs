using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MixConcreto.App.Cadastros;
using MixConcreto.App.Models;
using MixConcreto.Domain.Base;
using MixConcreto.Domain.Entities;
using MixConcreto.Repository.Context;
using MixConcreto.Repository.Repository;
using MixConcreto.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixConcreto.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? Services;

        public static IServiceProvider? ServiceProvider;

        public static void ConfigureServices()
        {
            Services = new ServiceCollection();
            var strCon = File.ReadAllText(@"Config\ConfigBanco.txt");

            #region Banco de dados
            Services.AddDbContext<MySqlContext>(options =>
            {
                options.LogTo(Console.WriteLine).EnableSensitiveDataLogging();

                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(100);
                    opt.EnableRetryOnFailure();
                });
            });
            #endregion

            #region Repositórios
            Services.AddScoped<IBaseRepository<Cliente>, BaseRepository<Cliente>>();
            Services.AddScoped<IBaseRepository<Funcionario>, BaseRepository<Funcionario>>();
            Services.AddScoped<IBaseRepository<Veiculo>, BaseRepository<Veiculo>>();
            Services.AddScoped<IBaseRepository<Estoque>, BaseRepository<Estoque>>();
            Services.AddScoped<IBaseRepository<Pedido>, BaseRepository<Pedido>>();
            Services.AddScoped<IBaseRepository<Producao>, BaseRepository<Producao>>();
            #endregion

            #region Serviços 
            Services.AddScoped<IBaseService<Cliente>, BaseService<Cliente>>();
            Services.AddScoped<IBaseService<Funcionario>, BaseService<Funcionario>>();
            Services.AddScoped<IBaseService<Veiculo>, BaseService<Veiculo>>();
            Services.AddScoped<IBaseService<Estoque>, BaseService<Estoque>>();
            Services.AddScoped<IBaseService<Pedido>, BaseService<Pedido>>();
            Services.AddScoped<IBaseService<Producao>, BaseService<Producao>>();
            #endregion

            #region Formularios 
            Services.AddTransient<CadastroCliente, CadastroCliente>();
            Services.AddTransient<CadastroFuncionario, CadastroFuncionario>();
            Services.AddTransient<CadastroVeiculo, CadastroVeiculo>();
            Services.AddTransient<CadastroEstoque, CadastroEstoque>();
            Services.AddTransient<CadastroPedido, CadastroPedido>();
            Services.AddTransient<CadastroProducao, CadastroProducao>();
            #endregion

            #region Mapping
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Funcionario, FuncionarioModel>();

                config.CreateMap<Cliente, ClienteModel>();

                config.CreateMap<Estoque, EstoqueModel>();

                config.CreateMap<Veiculo, VeiculoModel>();

                config.CreateMap<Pedido, PedidoModel>()
                .ForMember(p => p.Cliente, p => p.MapFrom(x => $"{x.Cliente!.Nome}"))
                .ForMember(a => a.IdCliente, a => a.MapFrom(x => $"{x.Cliente!.Id}"));


                config.CreateMap<Producao, ProducaoModel>()
                .ForMember(p => p.Funcionario, p => p.MapFrom(x => $"{x.Funcionario!.Nome}"))
                .ForMember(a => a.IdFuncionario, a => a.MapFrom(x => $"{x.Funcionario!.Id}"))
                .ForMember(p => p.Veiculo, p => p.MapFrom(x => $"{x.Veiculo!.Placa}"))
                .ForMember(a => a.IdVeiculo, a => a.MapFrom(x => $"{x.Veiculo!.Id}"))
                .ForMember(p => p.Pedido, p => p.MapFrom(x => $"{x.Pedido!.Quantidade}"))
                .ForMember(a => a.IdPedido, a => a.MapFrom(x => $"{x.Pedido!.Id}"));


            }).CreateMapper());
            #endregion

            ServiceProvider = Services.BuildServiceProvider();

        }
    }
}
