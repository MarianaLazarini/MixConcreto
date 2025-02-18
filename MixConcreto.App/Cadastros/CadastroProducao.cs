using MixConcreto.App.Base;
using MixConcreto.App.Models;
using MixConcreto.Domain.Base;
using MixConcreto.Domain.Entities;
using MixConcreto.Services.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixConcreto.App.Cadastros
{
    public partial class CadastroProducao : CadastroBase
    {
        #region Declaração
        private readonly IBaseService<Producao> _producaoService;
        private readonly IBaseService<Pedido> _pedidoService;
        private readonly IBaseService<Veiculo> _veiculoService;
        private readonly IBaseService<Funcionario> _funcionarioService;

        private List<Producao>? producoes;
        #endregion

        #region Construtor
        public CadastroProducao(IBaseService<Producao> producaoService, IBaseService<Veiculo> veiculoService, 
            IBaseService<Pedido> pedidoService, IBaseService<Funcionario> funcionarioService)
        {
            _producaoService = producaoService;
            _veiculoService = veiculoService;
            _pedidoService = pedidoService;
            _funcionarioService = funcionarioService;
            InitializeComponent();
            CarregarCombo();
        }
        #endregion

        #region Metodos
        private void CarregarCombo()
        {
            cboPlaca.ValueMember = "Id";
            cboPlaca.DisplayMember = "Placa";
            cboPlaca.DataSource = _veiculoService.Get<Veiculo>().ToList();

            cboFuncionario.ValueMember = "Id";
            cboFuncionario.DisplayMember = "Nome";
            cboFuncionario.DataSource = _funcionarioService.Get<Funcionario>().ToList();

            cboIDPedido.ValueMember = "Id";
            cboIDPedido.DisplayMember = "Id";
            cboIDPedido.DataSource = _pedidoService.Get<Pedido>().ToList();

            cboQuantidade.ValueMember = "Id";
            cboQuantidade.DisplayMember = "Quantidade";
            cboQuantidade.DataSource = _pedidoService.Get<Pedido>().ToList();

        }

        private void PreencheObjeto(Producao producao)
        {
            producao.Situacao = cboSituacao.Text;

            if (DateTime.TryParse(txtDataProd.Text, out var dataProducao))
            {
                producao.DataProducao = dataProducao;
            }
            if (int.TryParse(cboFuncionario.SelectedValue.ToString(), out var idFuncionario))
            {
                var funcionario = _funcionarioService.GetById<Funcionario>(idFuncionario);
                producao.Funcionario = funcionario;
            }
            if (int.TryParse(cboPlaca.SelectedValue.ToString(), out var idVeiculo))
            {
                var veiculo = _veiculoService.GetById<Veiculo>(idVeiculo);
                producao.Veiculo = veiculo;
            }
            if (int.TryParse(cboIDPedido.SelectedValue.ToString(), out var idPedido))
            {
                var pedido = _pedidoService.GetById<Pedido>(idPedido);
                producao.Pedido = pedido;
            }

        }
        #endregion

        #region Eventos CRUD

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var producao = _producaoService.GetById<Producao>(id);
                        PreencheObjeto(producao);
                        producao = _producaoService.Update<Producao, Producao, ProducaoValidator>(producao);
                    }
                }
                else
                {
                    var producao = new Producao();
                    PreencheObjeto(producao);
                    _producaoService.Add<Producao, Producao, ProducaoValidator>(producao);
                }
                TabControlCadastro.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"MixConcreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            producoes = _producaoService.Get<Producao>(new[] { "Funcionario", "Veiculo", "Pedido" }).ToList();
            dataGridViewConsulta.DataSource = producoes;

            dataGridViewConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewConsulta.Columns["IdFuncionario"]!.Visible = false;
            dataGridViewConsulta.Columns["IdVeiculo"]!.Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            cboPlaca.Text = linha?.Cells["Placa"].Value.ToString();
            cboFuncionario.Text = linha?.Cells["Funcionario"].Value.ToString();
            cboIDPedido.Text = linha?.Cells["IdPedido"].Value.ToString();
            cboQuantidade.Text = linha?.Cells["Quantidade"].Value.ToString();
            cboSituacao.Text = linha?.Cells["Situacao"].Value.ToString();
            txtDataProd.Text = DateTime.TryParse(linha?.Cells["DataProducao"].Value.ToString(), out var dataI)
               ? dataI.ToString("g")
               : "";
        }

        #endregion
    }
}
