using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;


namespace MixConcreto.App.Base
{
    public partial class CadastroBase : MaterialForm
    {
        #region Declarações
        protected bool IsAlteracao = false;
        #endregion

        #region Construtor
        public CadastroBase()
        {
            InitializeComponent();
        }
        #endregion

        #region CRUD
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Deseja realmente cancelar?", @"MixConcreto",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                TabControlCadastro.SelectedIndex = 1;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewConsulta.SelectedRows.Count > 0)
            {
                if (MessageBox.Show(@"Deseja realmente excluir?", @"MixConcreto",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)dataGridViewConsulta.SelectedRows[0].Cells["Id"].Value;
                    Deletar(id);
                    CarregaGrid();
                }
            }
            else
            {
                MessageBox.Show(@"Selecione algum registro!", @"MixConcreto",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Eventos CRUD
        protected void LimpaCampos()
        {
            IsAlteracao = false;
            foreach (var control in TabPageCadastro.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }
                if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }

            }
        }

        protected virtual void CarregaGrid()
        {
        }

        protected virtual void Novo()
        {
            LimpaCampos();
            TabControlCadastro.SelectedIndex = 0;
            TabControlCadastro.Focus();
        }

        protected virtual void Salvar()
        {
        }

        protected virtual void Editar()
        {
            if (dataGridViewConsulta.SelectedRows.Count > 0)
            {
                IsAlteracao = true;
                var linha = dataGridViewConsulta.SelectedRows[0];
                CarregaRegistro(linha);
                TabControlCadastro.SelectedIndex = 0;
                TabControlCadastro.Focus();
            }
            else
            {
                MessageBox.Show(@"Selecione algum registro!", @"MixConcreto",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        protected virtual void Deletar(int id)
        {
        }
        protected virtual void CarregaRegistro(DataGridViewRow? linha)
        {

        }
        #endregion

    }
}
