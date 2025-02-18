using MixConcreto.App.Base;
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
    public partial class CadastroFuncionario : CadastroBase
    {
        #region Declaração
        private readonly IBaseService<Funcionario> _funcionarioService;
        private List<Funcionario>? funcionarios;
        #endregion

        #region Construtor
        public CadastroFuncionario(IBaseService<Funcionario> funcionarioService)
        {
            _funcionarioService = funcionarioService;
            InitializeComponent();
        }
        #endregion

        #region Método
        private void PreencheObjeto(Funcionario funcionario)
        {
            funcionario.Nome = txtNome.Text;
            funcionario.Telefone = txtTelefone.Text;
            funcionario.Cpf = txtCpf.Text;
            funcionario.Endereco = txtEndereco.Text;
            funcionario.Bairro = txtBairro.Text;
            funcionario.Cidade = txtCidade.Text;
            funcionario.Cargo = txtCargo.Text;
            funcionario.Status = chkStatus.Checked;
            if (float.TryParse(txtSalario.Text, out var salario))
            {
                funcionario.Salario = salario;
            }
            if (DateTime.TryParse(txtDataAdmissao.Text, out var dataAdmissao))
            {
                funcionario.DataAdmissao = dataAdmissao;
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
                        var funcionario = _funcionarioService.GetById<Funcionario>(id);
                        PreencheObjeto(funcionario);
                        funcionario = _funcionarioService.Update<Funcionario, Funcionario, FuncionarioValidator>(funcionario);
                    }
                }
                else
                {
                    var funcionario = new Funcionario();
                    PreencheObjeto(funcionario);
                    _funcionarioService.Add<Funcionario, Funcionario, FuncionarioValidator>(funcionario);
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
                _funcionarioService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"MixConcreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            funcionarios = _funcionarioService.Get<Funcionario>().ToList();
            dataGridViewConsulta.DataSource = funcionarios;
            dataGridViewConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtTelefone.Text = linha?.Cells["Telefone"].Value.ToString();
            txtCpf.Text = linha?.Cells["Cpf"].Value.ToString();
            txtCargo.Text = linha?.Cells["Cargo"].Value.ToString();
            txtEndereco.Text = linha?.Cells["Endereco"].Value.ToString();
            txtBairro.Text = linha?.Cells["Bairro"].Value.ToString();
            txtCidade.Text = linha?.Cells["Cidade"].Value.ToString();
            txtDataAdmissao.Text = DateTime.TryParse(linha?.Cells["DataAdmissao"].Value.ToString(), out var dataI)
               ? dataI.ToString("g")
               : "";
            chkStatus.Checked = (bool)(linha?.Cells["Status"].Value ?? false);
            txtSalario.Text = linha?.Cells["Salario"].Value.ToString();
        }
        #endregion

    }
}
