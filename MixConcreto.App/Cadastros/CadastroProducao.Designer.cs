namespace MixConcreto.App.Cadastros
{
    partial class CadastroProducao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboSituacao = new ReaLTaiizor.Controls.MaterialComboBox();
            txtDataProd = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            cboFuncionario = new ReaLTaiizor.Controls.MaterialComboBox();
            cboPlaca = new ReaLTaiizor.Controls.MaterialComboBox();
            cboQuantidade = new ReaLTaiizor.Controls.MaterialComboBox();
            cboIDPedido = new ReaLTaiizor.Controls.MaterialComboBox();
            TabControlCadastro.SuspendLayout();
            TabPageCadastro.SuspendLayout();
            TabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // TabControlCadastro
            // 
            TabControlCadastro.Size = new Size(639, 410);
            // 
            // TabPageCadastro
            // 
            TabPageCadastro.Controls.Add(cboIDPedido);
            TabPageCadastro.Controls.Add(cboQuantidade);
            TabPageCadastro.Controls.Add(cboPlaca);
            TabPageCadastro.Controls.Add(cboFuncionario);
            TabPageCadastro.Controls.Add(txtDataProd);
            TabPageCadastro.Controls.Add(cboSituacao);
            TabPageCadastro.Controls.Add(txtId);
            TabPageCadastro.Size = new Size(631, 375);
            TabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            TabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            TabPageCadastro.Controls.SetChildIndex(txtId, 0);
            TabPageCadastro.Controls.SetChildIndex(cboSituacao, 0);
            TabPageCadastro.Controls.SetChildIndex(txtDataProd, 0);
            TabPageCadastro.Controls.SetChildIndex(cboFuncionario, 0);
            TabPageCadastro.Controls.SetChildIndex(cboPlaca, 0);
            TabPageCadastro.Controls.SetChildIndex(cboQuantidade, 0);
            TabPageCadastro.Controls.SetChildIndex(cboIDPedido, 0);
            // 
            // TabPageConsulta
            // 
            TabPageConsulta.Size = new Size(631, 375);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(404, 330);
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(520, 330);
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(531, 298);
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(439, 298);
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(355, 298);
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "ID";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(39, 29);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(146, 48);
            txtId.TabIndex = 2;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // cboSituacao
            // 
            cboSituacao.AutoResize = false;
            cboSituacao.BackColor = Color.FromArgb(255, 255, 255);
            cboSituacao.Depth = 0;
            cboSituacao.DrawMode = DrawMode.OwnerDrawVariable;
            cboSituacao.DropDownHeight = 174;
            cboSituacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSituacao.DropDownWidth = 121;
            cboSituacao.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboSituacao.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboSituacao.FormattingEnabled = true;
            cboSituacao.Hint = "Situação";
            cboSituacao.IntegralHeight = false;
            cboSituacao.ItemHeight = 43;
            cboSituacao.Items.AddRange(new object[] { "Não Iniciado", "Em Produção", "Concluído" });
            cboSituacao.Location = new Point(381, 29);
            cboSituacao.MaxDropDownItems = 4;
            cboSituacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboSituacao.Name = "cboSituacao";
            cboSituacao.Size = new Size(214, 49);
            cboSituacao.StartIndex = 0;
            cboSituacao.TabIndex = 3;
            // 
            // txtDataProd
            // 
            txtDataProd.AllowPromptAsInput = true;
            txtDataProd.AnimateReadOnly = false;
            txtDataProd.AsciiOnly = false;
            txtDataProd.BackgroundImageLayout = ImageLayout.None;
            txtDataProd.BeepOnError = false;
            txtDataProd.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataProd.Depth = 0;
            txtDataProd.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataProd.HidePromptOnLeave = false;
            txtDataProd.HideSelection = true;
            txtDataProd.Hint = "Data Produção";
            txtDataProd.InsertKeyMode = InsertKeyMode.Default;
            txtDataProd.LeadingIcon = null;
            txtDataProd.Location = new Point(213, 29);
            txtDataProd.Mask = "99/99/9999";
            txtDataProd.MaxLength = 32767;
            txtDataProd.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataProd.Name = "txtDataProd";
            txtDataProd.PasswordChar = '\0';
            txtDataProd.PrefixSuffixText = null;
            txtDataProd.PromptChar = '_';
            txtDataProd.ReadOnly = false;
            txtDataProd.RejectInputOnFirstFailure = false;
            txtDataProd.ResetOnPrompt = true;
            txtDataProd.ResetOnSpace = true;
            txtDataProd.RightToLeft = RightToLeft.No;
            txtDataProd.SelectedText = "";
            txtDataProd.SelectionLength = 0;
            txtDataProd.SelectionStart = 0;
            txtDataProd.ShortcutsEnabled = true;
            txtDataProd.Size = new Size(144, 48);
            txtDataProd.SkipLiterals = true;
            txtDataProd.TabIndex = 4;
            txtDataProd.TabStop = false;
            txtDataProd.Text = "  /  /";
            txtDataProd.TextAlign = HorizontalAlignment.Left;
            txtDataProd.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataProd.TrailingIcon = null;
            txtDataProd.UseSystemPasswordChar = false;
            txtDataProd.ValidatingType = null;
            // 
            // cboFuncionario
            // 
            cboFuncionario.AutoResize = false;
            cboFuncionario.BackColor = Color.FromArgb(255, 255, 255);
            cboFuncionario.Depth = 0;
            cboFuncionario.DrawMode = DrawMode.OwnerDrawVariable;
            cboFuncionario.DropDownHeight = 174;
            cboFuncionario.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFuncionario.DropDownWidth = 121;
            cboFuncionario.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboFuncionario.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboFuncionario.FormattingEnabled = true;
            cboFuncionario.Hint = "Funcionário";
            cboFuncionario.IntegralHeight = false;
            cboFuncionario.ItemHeight = 43;
            cboFuncionario.Location = new Point(39, 103);
            cboFuncionario.MaxDropDownItems = 4;
            cboFuncionario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboFuncionario.Name = "cboFuncionario";
            cboFuncionario.Size = new Size(556, 49);
            cboFuncionario.StartIndex = 0;
            cboFuncionario.TabIndex = 5;
            // 
            // cboPlaca
            // 
            cboPlaca.AutoResize = false;
            cboPlaca.BackColor = Color.FromArgb(255, 255, 255);
            cboPlaca.Depth = 0;
            cboPlaca.DrawMode = DrawMode.OwnerDrawVariable;
            cboPlaca.DropDownHeight = 174;
            cboPlaca.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlaca.DropDownWidth = 121;
            cboPlaca.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboPlaca.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboPlaca.FormattingEnabled = true;
            cboPlaca.Hint = "Veículo - Placa";
            cboPlaca.IntegralHeight = false;
            cboPlaca.ItemHeight = 43;
            cboPlaca.Location = new Point(381, 176);
            cboPlaca.MaxDropDownItems = 4;
            cboPlaca.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboPlaca.Name = "cboPlaca";
            cboPlaca.Size = new Size(214, 49);
            cboPlaca.StartIndex = 0;
            cboPlaca.TabIndex = 6;
            // 
            // cboQuantidade
            // 
            cboQuantidade.AutoResize = false;
            cboQuantidade.BackColor = Color.FromArgb(255, 255, 255);
            cboQuantidade.Depth = 0;
            cboQuantidade.DrawMode = DrawMode.OwnerDrawVariable;
            cboQuantidade.DropDownHeight = 174;
            cboQuantidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cboQuantidade.DropDownWidth = 121;
            cboQuantidade.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboQuantidade.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboQuantidade.FormattingEnabled = true;
            cboQuantidade.Hint = "Quantidade";
            cboQuantidade.IntegralHeight = false;
            cboQuantidade.ItemHeight = 43;
            cboQuantidade.Location = new Point(213, 175);
            cboQuantidade.MaxDropDownItems = 4;
            cboQuantidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboQuantidade.Name = "cboQuantidade";
            cboQuantidade.Size = new Size(144, 49);
            cboQuantidade.StartIndex = 0;
            cboQuantidade.TabIndex = 7;
            // 
            // cboIDPedido
            // 
            cboIDPedido.AutoResize = false;
            cboIDPedido.BackColor = Color.FromArgb(255, 255, 255);
            cboIDPedido.Depth = 0;
            cboIDPedido.DrawMode = DrawMode.OwnerDrawVariable;
            cboIDPedido.DropDownHeight = 174;
            cboIDPedido.DropDownStyle = ComboBoxStyle.DropDownList;
            cboIDPedido.DropDownWidth = 121;
            cboIDPedido.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboIDPedido.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboIDPedido.FormattingEnabled = true;
            cboIDPedido.Hint = "ID Pedido";
            cboIDPedido.IntegralHeight = false;
            cboIDPedido.ItemHeight = 43;
            cboIDPedido.Location = new Point(39, 175);
            cboIDPedido.MaxDropDownItems = 4;
            cboIDPedido.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboIDPedido.Name = "cboIDPedido";
            cboIDPedido.Size = new Size(146, 49);
            cboIDPedido.StartIndex = 0;
            cboIDPedido.TabIndex = 8;
            // 
            // CadastroProducao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 477);
            Location = new Point(0, 0);
            Name = "CadastroProducao";
            Text = "Cadastro de Produção";
            TabControlCadastro.ResumeLayout(false);
            TabPageCadastro.ResumeLayout(false);
            TabPageCadastro.PerformLayout();
            TabPageConsulta.ResumeLayout(false);
            TabPageConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataProd;
        private ReaLTaiizor.Controls.MaterialComboBox cboSituacao;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialComboBox cboPlaca;
        private ReaLTaiizor.Controls.MaterialComboBox cboFuncionario;
        private ReaLTaiizor.Controls.MaterialComboBox cboIDPedido;
        private ReaLTaiizor.Controls.MaterialComboBox cboQuantidade;
    }
}