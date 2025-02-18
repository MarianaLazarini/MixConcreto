using MixConcreto.App.Base;
using MixConcreto.App.Models;
using MixConcreto.Domain.Base;
using MixConcreto.Domain.Entities;
using MixConcreto.Services.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixConcreto.App.Cadastros
{
    public partial class CadastroPedido : CadastroBase
    {
        #region Declaração
        private readonly IBaseService<Pedido> _pedidoService;
        private readonly IBaseService<Cliente> _clienteService;
        private List<Pedido>? pedidos;
        #endregion

        #region Construtor

        public CadastroPedido(IBaseService<Pedido> pedidoService, IBaseService<Cliente> clienteService)
        {
            _pedidoService = pedidoService;
            _clienteService = clienteService;
            InitializeComponent();
            CarregarCombo();
        }
        #endregion

        #region Metodos
        private void CarregarCombo()
        {
            cboCliente.ValueMember = "Id";
            cboCliente.DisplayMember = "Nome";
            cboCliente.DataSource = _clienteService.Get<Cliente>().ToList();
        }

        private void PreencheObjeto(Pedido pedido)
        {
            pedido.Situacao = cboSituacao.Text;

            if (float.TryParse(txtValorTotal.Text.Replace("R$", "").Trim(), out var valorTotal))
            {
                pedido.ValorTotal = valorTotal;
            }
            if (DateTime.TryParse(txtDataPedido.Text, out var dataPedido))
            {
                pedido.DataPedido = dataPedido;
            }
            if (int.TryParse(cboCliente.SelectedValue.ToString(), out var idCliente))
            {
                var cliente = _clienteService.GetById<Cliente>(idCliente);
                pedido.Cliente = cliente;
            }
            if (float.TryParse(txtQuantidade.Text, out var quantidade))
            {
                pedido.Quantidade = quantidade;
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
                        var pedido = _pedidoService.GetById<Pedido>(id);
                        PreencheObjeto(pedido);
                        pedido = _pedidoService.Update<Pedido, Pedido, PedidoValidator>(pedido);
                    }
                }
                else
                {
                    var pedido = new Pedido();
                    PreencheObjeto(pedido);
                    _pedidoService.Add<Pedido, Pedido, PedidoValidator>(pedido);
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
            pedidos = _pedidoService.Get<Pedido>(new[] { "Cliente" }).ToList();
            dataGridViewConsulta.DataSource = pedidos;

            dataGridViewConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewConsulta.Columns["IdCliente"]!.Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            cboCliente.Text = linha?.Cells["Cliente"].Value.ToString();
            txtQuantidade.Text = linha?.Cells["Quantidade"].Value.ToString();
            txtValorTotal.Text = linha?.Cells["ValorTotal"].Value.ToString();
            cboSituacao.Text = linha?.Cells["Situacao"].Value.ToString();
            txtDataPedido.Text = DateTime.TryParse(linha?.Cells["DataPedido"].Value.ToString(), out var dataI)
               ? dataI.ToString("g")
               : "";
        }

        #endregion

    }
}
