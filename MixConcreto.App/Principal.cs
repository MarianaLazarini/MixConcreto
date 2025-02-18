using Microsoft.Extensions.DependencyInjection;
using MixConcreto.App.Cadastros;
using MixConcreto.App.Infra;
using ReaLTaiizor.Forms;

namespace MixConcreto.App
{
    public partial class Principal : MaterialForm
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroCliente>();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroFuncionario>();
        }

        private void veículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroVeiculo>();

        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroEstoque>();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroPedido>();
        }

        private void produçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroProducao>();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExibeFormulario<TFormulario>() where TFormulario : Form
        {
            var cad = ConfigureDI.ServiceProvider!.GetService<TFormulario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }
    }
}
