using MixConcreto.App.Base;
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
    public partial class CadastroVeiculo : CadastroBase
    {
        #region Declaração
        private readonly IBaseService<Veiculo> _veiculoService;
        private List<Veiculo>? veiculos;
        #endregion

        #region Construtor
        public CadastroVeiculo(IBaseService<Veiculo> veiculoService)
        {
            _veiculoService = veiculoService;
            InitializeComponent();
        }
        #endregion

        #region Método
        private void PreencheObjeto(Veiculo veiculo)
        {
            veiculo.Placa = txtPlaca.Text;
            veiculo.Modelo = txtModelo.Text;
            veiculo.Situacao = cboSituacao.Text;
            if (float.TryParse(txtCapacidade.Text, out var capacidade))
            {
                veiculo.Capacidade = capacidade;
            }
            if (int.TryParse(txtAno.Text, out var ano))
            {
                veiculo.Ano = ano;
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
                        var veiculo = _veiculoService.GetById<Veiculo>(id);
                        PreencheObjeto(veiculo);
                        veiculo = _veiculoService.Update<Veiculo, Veiculo, VeiculoValidator>(veiculo);
                    }
                }
                else
                {
                    var veiculo = new Veiculo();
                    PreencheObjeto(veiculo);
                    _veiculoService.Add<Veiculo, Veiculo, VeiculoValidator>(veiculo);
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
                _veiculoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"MixConcreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            veiculos = _veiculoService.Get<Veiculo>().ToList();
            dataGridViewConsulta.DataSource = veiculos;
            dataGridViewConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtPlaca.Text = linha?.Cells["Placa"].Value.ToString();
            txtModelo.Text = linha?.Cells["Modelo"].Value.ToString();
            txtAno.Text = linha?.Cells["Ano"].Value.ToString();
            txtCapacidade.Text = linha?.Cells["Capacidade"].Value.ToString();
            cboSituacao.Text = linha?.Cells["Situacao"].Value.ToString();

        }
        #endregion



    }
}
