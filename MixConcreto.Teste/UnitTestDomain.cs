using MixConcreto.Domain.Entities;
using System.Diagnostics;
using System.Text.Json;

namespace MixConcreto.Teste
{
    [TestClass]

    public class UnitTestDomain
    {

        [TestMethod]

        public void TestCliente()
        {
            Cliente cliente = new Cliente(1, "Mariana", "123456789-23", "18 99744-4466", "marilazarini@gmail.com", "Rua Azul", "Residencial Novo",  "Birigui");

            Debug.WriteLine(JsonSerializer.Serialize(cliente));

            Assert.AreEqual(cliente.Nome, "Mariana");
            Assert.AreEqual(cliente.Cpf, "123456789-23");
            Assert.AreEqual(cliente.Telefone, "18 99744-4466");
            Assert.AreEqual(cliente.Endereco, "Rua Azul");
            Assert.AreEqual(cliente.Bairro, "Residencial Novo");
            Assert.AreEqual(cliente.Email, "marilazarini@gmail.com");
            Assert.AreEqual(cliente.Cidade, "Birigui");
        }

        [TestMethod]

        public void TestFuncionario()
        {
            DateTime dataAdmissao = new DateTime(2025, 01, 02);

            Funcionario funcionario = new Funcionario(1, "Mariana", "123456789-23", "18 99744-4466", "Rua Azul", "Residencial Novo", "Birigui", "Auditor", 2500.00f, true, dataAdmissao);

            Debug.WriteLine(JsonSerializer.Serialize(funcionario));

            Assert.AreEqual(funcionario.Nome, "Mariana");
            Assert.AreEqual(funcionario.Cpf, "123456789-23");
            Assert.AreEqual(funcionario.Telefone, "18 99744-4466");
            Assert.AreEqual(funcionario.Endereco, "Rua Azul");
            Assert.AreEqual(funcionario.Bairro, "Residencial Novo");
            Assert.AreEqual(funcionario.Cidade, "Birigui");
            Assert.AreEqual(funcionario.Cargo, "Auditor");
            Assert.AreEqual(funcionario.Salario, 2500.00f);
            Assert.AreEqual(funcionario.Status, true);
            Assert.AreEqual(funcionario.DataAdmissao, dataAdmissao);

        }

        [TestMethod]

        public void Veiculo()
        {
            Veiculo veiculo = new Veiculo(1, "DRT-5898", "Caminhão Mixer - Mercedes", 2023, 3, "Em uso");

            Debug.WriteLine(JsonSerializer.Serialize(veiculo));

            Assert.AreEqual(veiculo.Placa, "DRT-5898");
            Assert.AreEqual(veiculo.Modelo, "Caminhão Mixer - Mercedes");
            Assert.AreEqual(veiculo.Ano, 2023);
            Assert.AreEqual(veiculo.Capacidade, 3);
            Assert.AreEqual(veiculo.Situacao, "Em uso");
        }

        [TestMethod]

        public void Pedido()
        {
            DateTime dataPedido = new DateTime(2025, 01, 15);

            var cliente = new Cliente();
            cliente.Nome = "Mariana";
            cliente.Cpf = "123456789-23";
            cliente.Telefone = "18 99744-4466";
            cliente.Endereco = "Rua Azul";
            cliente.Bairro = "Residencial Novo";

            Pedido pedido = new Pedido(1, dataPedido, "Em Produção", 5000, 10.00f, cliente);

            Debug.WriteLine(JsonSerializer.Serialize(pedido));

            Assert.AreEqual(pedido.DataPedido, dataPedido);
            Assert.AreEqual(pedido.Situacao, "Em Produção");
            Assert.AreEqual(pedido.ValorTotal, 5000);
            Assert.AreEqual(pedido.Quantidade, 10.00f);
            Assert.AreEqual(pedido.Cliente, cliente);
        }

        [TestMethod]

        public void Estoque()
        {
            Estoque estoque = new Estoque(1, "Areia", 10, "metros cubicos", 190.00f, "Porto da Areia");

            Debug.WriteLine(JsonSerializer.Serialize(estoque));

            Assert.AreEqual(estoque.Nome, "Areia");
            Assert.AreEqual(estoque.QuantidadeAtual, 10);
            Assert.AreEqual(estoque.Unidade, "metros cubicos");
            Assert.AreEqual(estoque.PrecoUnitario, 190.00f);
            Assert.AreEqual(estoque.Fornecedor, "Porto da Areia");

        }

        [TestMethod]

        public void Producao()
        {
            DateTime dataProducao = new DateTime(2025, 01, 16);

            var pedido = new Pedido();
            var funcionario = new Funcionario();
            var veiculo = new Veiculo();

            funcionario.Nome = "Joao";
            veiculo.Modelo = "Bitoneira Mercedes";
            veiculo.Id = 1;
            pedido.Id = 1;
            pedido.Quantidade = 10.00f;

            Producao producao = new Producao(1, dataProducao, "Em Produção", pedido, funcionario, veiculo);

            Debug.WriteLine(JsonSerializer.Serialize(producao));

            Assert.AreEqual(producao.DataProducao, dataProducao);
            Assert.AreEqual(producao.Situacao, "Em Produção");
            Assert.AreEqual(producao.Pedido, pedido);
            Assert.AreEqual(producao.Funcionario, funcionario);
            Assert.AreEqual(producao.Veiculo, veiculo);
        }
    }
}
