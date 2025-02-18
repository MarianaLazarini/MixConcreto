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
    public partial class CadastroEstoque : CadastroBase
    {
        #region Declaração
        private readonly IBaseService<Estoque> _estoqueService;
        private List<Estoque>? estoques;
        #endregion

        #region Construtor
        public CadastroEstoque(IBaseService<Estoque> estoqueService)
        {
            _estoqueService = estoqueService;
            InitializeComponent();
        }
        #endregion

        #region Método
        private void PreencheObjeto(Estoque estoque)
        {
            estoque.Nome = txtNome.Text;
            estoque.Unidade = txtUnidade.Text;
            estoque.Fornecedor = txtFornecedor.Text;
            if (float.TryParse(txtPrecoUnit.Text, out var precoUnitario))
            {
                estoque.PrecoUnitario = precoUnitario;
            }
            if (float.TryParse(txtQtdAtual.Text, out var qtdAtual))
            {
                estoque.QuantidadeAtual = qtdAtual;
            }
        }
        #endregion

        #region CRUD

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var estoque = _estoqueService.GetById<Estoque>(id);
                        PreencheObjeto(estoque);
                        estoque = _estoqueService.Update<Estoque, Estoque, EstoqueValidator>(estoque);
                    }
                }
                else
                {
                    var estoque = new Estoque();
                    PreencheObjeto(estoque);
                    _estoqueService.Add<Estoque, Estoque, EstoqueValidator>(estoque);
                }
                TabControlCadastro.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"MixConcreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _estoqueService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"MixConcreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            estoques = _estoqueService.Get<Estoque>().ToList();
            dataGridViewConsulta.DataSource = estoques;
            dataGridViewConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtUnidade.Text = linha?.Cells["Unidade"].Value.ToString();
            txtQtdAtual.Text = linha?.Cells["QuantidadeAtual"].Value.ToString();
            txtPrecoUnit.Text = linha?.Cells["PrecoUnitario"].Value.ToString();
            txtFornecedor.Text = linha?.Cells["Fornecedor"].Value.ToString();

        }
        #endregion







    }
}
