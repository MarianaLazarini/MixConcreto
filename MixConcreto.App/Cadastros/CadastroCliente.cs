using MixConcreto.App.Base;
using MixConcreto.Domain.Base;
using MixConcreto.Domain.Entities;
using MixConcreto.Services.Validators;


namespace MixConcreto.App.Cadastros
{
    public partial class CadastroCliente : CadastroBase
    {
        #region Declaração
        private readonly IBaseService<Cliente> _clienteService;
        private List<Cliente>? clientes;
        #endregion

        #region Construtor
        public CadastroCliente(IBaseService<Cliente> clienteService)
        {
            _clienteService = clienteService;
            InitializeComponent();
        }
        #endregion

        #region Método
        private void PreencheObjeto(Cliente cliente)
        {
            cliente.Nome = txtNome.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Cpf = txtCpf.Text;
            cliente.Email = txtEmail.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Bairro = txtBairro.Text;
            cliente.Cidade = txtCidade.Text;
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
                        var cliente = _clienteService.GetById<Cliente>(id);
                        PreencheObjeto(cliente);
                        cliente = _clienteService.Update<Cliente, Cliente, ClienteValidator>(cliente);
                    }
                }
                else
                {
                    var cliente = new Cliente();
                    PreencheObjeto(cliente);
                    _clienteService.Add<Cliente, Cliente, ClienteValidator>(cliente);
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
                _clienteService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"MixConcreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            clientes = _clienteService.Get<Cliente>().ToList();
            dataGridViewConsulta.DataSource = clientes;
            dataGridViewConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtTelefone.Text = linha?.Cells["Telefone"].Value.ToString();
            txtCpf.Text = linha?.Cells["Cpf"].Value.ToString();
            txtEmail.Text = linha?.Cells["Email"].Value.ToString();
            txtEndereco.Text = linha?.Cells["Endereco"].Value.ToString();
            txtBairro.Text = linha?.Cells["Bairro"].Value.ToString();
            txtCidade.Text = linha?.Cells["Cidade"].Value.ToString();
        }
        #endregion

    }
}
