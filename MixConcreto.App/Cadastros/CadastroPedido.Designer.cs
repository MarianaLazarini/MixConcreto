namespace MixConcreto.App.Cadastros
{
    partial class CadastroPedido
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
            txtQuantidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDataPedido = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            cboCliente = new ReaLTaiizor.Controls.MaterialComboBox();
            txtValorTotal = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            cboSituacao = new ReaLTaiizor.Controls.MaterialComboBox();
            TabControlCadastro.SuspendLayout();
            TabPageCadastro.SuspendLayout();
            TabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // TabControlCadastro
            // 
            TabControlCadastro.Size = new Size(755, 281);
            // 
            // TabPageCadastro
            // 
            TabPageCadastro.Controls.Add(cboSituacao);
            TabPageCadastro.Controls.Add(txtValorTotal);
            TabPageCadastro.Controls.Add(cboCliente);
            TabPageCadastro.Controls.Add(txtDataPedido);
            TabPageCadastro.Controls.Add(txtQuantidade);
            TabPageCadastro.Controls.Add(txtId);
            TabPageCadastro.Size = new Size(747, 246);
            TabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            TabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            TabPageCadastro.Controls.SetChildIndex(txtId, 0);
            TabPageCadastro.Controls.SetChildIndex(txtQuantidade, 0);
            TabPageCadastro.Controls.SetChildIndex(txtDataPedido, 0);
            TabPageCadastro.Controls.SetChildIndex(cboCliente, 0);
            TabPageCadastro.Controls.SetChildIndex(txtValorTotal, 0);
            TabPageCadastro.Controls.SetChildIndex(cboSituacao, 0);
            // 
            // TabPageConsulta
            // 
            TabPageConsulta.Size = new Size(747, 246);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(520, 201);
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(636, 201);
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(647, 169);
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(555, 169);
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(471, 169);
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
            txtId.Location = new Point(29, 28);
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
            txtId.Size = new Size(133, 48);
            txtId.TabIndex = 2;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtQuantidade
            // 
            txtQuantidade.AnimateReadOnly = false;
            txtQuantidade.AutoCompleteMode = AutoCompleteMode.None;
            txtQuantidade.AutoCompleteSource = AutoCompleteSource.None;
            txtQuantidade.BackgroundImageLayout = ImageLayout.None;
            txtQuantidade.CharacterCasing = CharacterCasing.Normal;
            txtQuantidade.Depth = 0;
            txtQuantidade.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQuantidade.HideSelection = true;
            txtQuantidade.Hint = "Quantidade";
            txtQuantidade.LeadingIcon = null;
            txtQuantidade.Location = new Point(29, 95);
            txtQuantidade.MaxLength = 32767;
            txtQuantidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.PasswordChar = '\0';
            txtQuantidade.PrefixSuffixText = null;
            txtQuantidade.ReadOnly = false;
            txtQuantidade.RightToLeft = RightToLeft.No;
            txtQuantidade.SelectedText = "";
            txtQuantidade.SelectionLength = 0;
            txtQuantidade.SelectionStart = 0;
            txtQuantidade.ShortcutsEnabled = true;
            txtQuantidade.Size = new Size(181, 48);
            txtQuantidade.TabIndex = 3;
            txtQuantidade.TabStop = false;
            txtQuantidade.TextAlign = HorizontalAlignment.Left;
            txtQuantidade.TrailingIcon = null;
            txtQuantidade.UseSystemPasswordChar = false;
            // 
            // txtDataPedido
            // 
            txtDataPedido.AllowPromptAsInput = true;
            txtDataPedido.AnimateReadOnly = false;
            txtDataPedido.AsciiOnly = false;
            txtDataPedido.BackgroundImageLayout = ImageLayout.None;
            txtDataPedido.BeepOnError = false;
            txtDataPedido.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataPedido.Depth = 0;
            txtDataPedido.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataPedido.HidePromptOnLeave = false;
            txtDataPedido.HideSelection = true;
            txtDataPedido.Hint = "Data do Pedido";
            txtDataPedido.InsertKeyMode = InsertKeyMode.Default;
            txtDataPedido.LeadingIcon = null;
            txtDataPedido.Location = new Point(229, 95);
            txtDataPedido.Mask = "99/99/9999";
            txtDataPedido.MaxLength = 32767;
            txtDataPedido.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataPedido.Name = "txtDataPedido";
            txtDataPedido.PasswordChar = '\0';
            txtDataPedido.PrefixSuffixText = null;
            txtDataPedido.PromptChar = '_';
            txtDataPedido.ReadOnly = false;
            txtDataPedido.RejectInputOnFirstFailure = false;
            txtDataPedido.ResetOnPrompt = true;
            txtDataPedido.ResetOnSpace = true;
            txtDataPedido.RightToLeft = RightToLeft.No;
            txtDataPedido.SelectedText = "";
            txtDataPedido.SelectionLength = 0;
            txtDataPedido.SelectionStart = 0;
            txtDataPedido.ShortcutsEnabled = true;
            txtDataPedido.Size = new Size(140, 48);
            txtDataPedido.SkipLiterals = true;
            txtDataPedido.TabIndex = 4;
            txtDataPedido.TabStop = false;
            txtDataPedido.Text = "  /  /";
            txtDataPedido.TextAlign = HorizontalAlignment.Left;
            txtDataPedido.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataPedido.TrailingIcon = null;
            txtDataPedido.UseSystemPasswordChar = false;
            txtDataPedido.ValidatingType = null;
            // 
            // cboCliente
            // 
            cboCliente.AutoResize = false;
            cboCliente.BackColor = Color.FromArgb(255, 255, 255);
            cboCliente.Depth = 0;
            cboCliente.DrawMode = DrawMode.OwnerDrawVariable;
            cboCliente.DropDownHeight = 174;
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.DropDownWidth = 121;
            cboCliente.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboCliente.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboCliente.FormattingEnabled = true;
            cboCliente.Hint = "Cliente";
            cboCliente.IntegralHeight = false;
            cboCliente.ItemHeight = 43;
            cboCliente.Location = new Point(183, 27);
            cboCliente.MaxDropDownItems = 4;
            cboCliente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(503, 49);
            cboCliente.StartIndex = 0;
            cboCliente.TabIndex = 5;
            // 
            // txtValorTotal
            // 
            txtValorTotal.AllowPromptAsInput = true;
            txtValorTotal.AnimateReadOnly = false;
            txtValorTotal.AsciiOnly = false;
            txtValorTotal.BackgroundImageLayout = ImageLayout.None;
            txtValorTotal.BeepOnError = false;
            txtValorTotal.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtValorTotal.Depth = 0;
            txtValorTotal.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtValorTotal.HidePromptOnLeave = false;
            txtValorTotal.HideSelection = true;
            txtValorTotal.Hint = "Valor Total";
            txtValorTotal.InsertKeyMode = InsertKeyMode.Default;
            txtValorTotal.LeadingIcon = null;
            txtValorTotal.Location = new Point(386, 95);
            txtValorTotal.Mask = "99,999.99";
            txtValorTotal.MaxLength = 32767;
            txtValorTotal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.PasswordChar = '\0';
            txtValorTotal.PrefixSuffixText = null;
            txtValorTotal.PromptChar = '_';
            txtValorTotal.ReadOnly = false;
            txtValorTotal.RejectInputOnFirstFailure = false;
            txtValorTotal.ResetOnPrompt = true;
            txtValorTotal.ResetOnSpace = true;
            txtValorTotal.RightToLeft = RightToLeft.No;
            txtValorTotal.SelectedText = "";
            txtValorTotal.SelectionLength = 0;
            txtValorTotal.SelectionStart = 0;
            txtValorTotal.ShortcutsEnabled = true;
            txtValorTotal.Size = new Size(140, 48);
            txtValorTotal.SkipLiterals = true;
            txtValorTotal.TabIndex = 6;
            txtValorTotal.TabStop = false;
            txtValorTotal.Text = "  .   ,";
            txtValorTotal.TextAlign = HorizontalAlignment.Left;
            txtValorTotal.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtValorTotal.TrailingIcon = null;
            txtValorTotal.UseSystemPasswordChar = false;
            txtValorTotal.ValidatingType = null;
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
            cboSituacao.Items.AddRange(new object[] { "Em Produção", "Concluído" });
            cboSituacao.Location = new Point(545, 94);
            cboSituacao.MaxDropDownItems = 4;
            cboSituacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboSituacao.Name = "cboSituacao";
            cboSituacao.Size = new Size(141, 49);
            cboSituacao.StartIndex = 0;
            cboSituacao.TabIndex = 7;
            // 
            // CadastroPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 348);
            Location = new Point(0, 0);
            Name = "CadastroPedido";
            Text = "Cadastro de Pedido";
            TabControlCadastro.ResumeLayout(false);
            TabPageCadastro.ResumeLayout(false);
            TabPageCadastro.PerformLayout();
            TabPageConsulta.ResumeLayout(false);
            TabPageConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataPedido;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtQuantidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialComboBox cboSituacao;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtValorTotal;
        private ReaLTaiizor.Controls.MaterialComboBox cboCliente;
    }
}