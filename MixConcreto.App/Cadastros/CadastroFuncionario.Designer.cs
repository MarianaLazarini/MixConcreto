namespace MixConcreto.App.Cadastros
{
    partial class CadastroFuncionario
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
            txtCpf = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtTelefone = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtCargo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtSalario = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtEndereco = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtBairro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            chkStatus = new ReaLTaiizor.Controls.MaterialCheckBox();
            txtDataAdmissao = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            TabControlCadastro.SuspendLayout();
            TabPageCadastro.SuspendLayout();
            TabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // TabControlCadastro
            // 
            TabControlCadastro.Size = new Size(670, 494);
            // 
            // TabPageCadastro
            // 
            TabPageCadastro.Controls.Add(txtDataAdmissao);
            TabPageCadastro.Controls.Add(chkStatus);
            TabPageCadastro.Controls.Add(txtCidade);
            TabPageCadastro.Controls.Add(txtBairro);
            TabPageCadastro.Controls.Add(txtEndereco);
            TabPageCadastro.Controls.Add(txtSalario);
            TabPageCadastro.Controls.Add(txtCargo);
            TabPageCadastro.Controls.Add(txtTelefone);
            TabPageCadastro.Controls.Add(txtNome);
            TabPageCadastro.Controls.Add(txtCpf);
            TabPageCadastro.Controls.Add(txtId);
            TabPageCadastro.Size = new Size(673, 456);
            TabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            TabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            TabPageCadastro.Controls.SetChildIndex(txtId, 0);
            TabPageCadastro.Controls.SetChildIndex(txtCpf, 0);
            TabPageCadastro.Controls.SetChildIndex(txtNome, 0);
            TabPageCadastro.Controls.SetChildIndex(txtTelefone, 0);
            TabPageCadastro.Controls.SetChildIndex(txtCargo, 0);
            TabPageCadastro.Controls.SetChildIndex(txtSalario, 0);
            TabPageCadastro.Controls.SetChildIndex(txtEndereco, 0);
            TabPageCadastro.Controls.SetChildIndex(txtBairro, 0);
            TabPageCadastro.Controls.SetChildIndex(txtCidade, 0);
            TabPageCadastro.Controls.SetChildIndex(chkStatus, 0);
            TabPageCadastro.Controls.SetChildIndex(txtDataAdmissao, 0);
            // 
            // TabPageConsulta
            // 
            TabPageConsulta.Size = new Size(662, 459);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(441, 411);
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(555, 411);
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(563, 404);
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(471, 404);
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(387, 404);
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "ID";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(32, 25);
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
            txtId.Size = new Size(127, 48);
            txtId.TabIndex = 0;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtCpf
            // 
            txtCpf.AllowPromptAsInput = true;
            txtCpf.AnimateReadOnly = false;
            txtCpf.AsciiOnly = false;
            txtCpf.BackgroundImageLayout = ImageLayout.None;
            txtCpf.BeepOnError = false;
            txtCpf.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtCpf.Depth = 0;
            txtCpf.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCpf.HidePromptOnLeave = false;
            txtCpf.HideSelection = true;
            txtCpf.Hint = "CPF";
            txtCpf.InsertKeyMode = InsertKeyMode.Default;
            txtCpf.LeadingIcon = null;
            txtCpf.Location = new Point(32, 91);
            txtCpf.Mask = "999,999,999-99";
            txtCpf.MaxLength = 32767;
            txtCpf.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCpf.Name = "txtCpf";
            txtCpf.PasswordChar = '\0';
            txtCpf.PrefixSuffixText = null;
            txtCpf.PromptChar = '_';
            txtCpf.ReadOnly = false;
            txtCpf.RejectInputOnFirstFailure = false;
            txtCpf.ResetOnPrompt = true;
            txtCpf.ResetOnSpace = true;
            txtCpf.RightToLeft = RightToLeft.No;
            txtCpf.SelectedText = "";
            txtCpf.SelectionLength = 0;
            txtCpf.SelectionStart = 0;
            txtCpf.ShortcutsEnabled = true;
            txtCpf.Size = new Size(272, 48);
            txtCpf.SkipLiterals = true;
            txtCpf.TabIndex = 2;
            txtCpf.TabStop = false;
            txtCpf.Text = "   .   .   -";
            txtCpf.TextAlign = HorizontalAlignment.Left;
            txtCpf.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtCpf.TrailingIcon = null;
            txtCpf.UseSystemPasswordChar = false;
            txtCpf.ValidatingType = null;
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(185, 25);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(435, 48);
            txtNome.TabIndex = 1;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtTelefone
            // 
            txtTelefone.AllowPromptAsInput = true;
            txtTelefone.AnimateReadOnly = false;
            txtTelefone.AsciiOnly = false;
            txtTelefone.BackgroundImageLayout = ImageLayout.None;
            txtTelefone.BeepOnError = false;
            txtTelefone.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtTelefone.Depth = 0;
            txtTelefone.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTelefone.HidePromptOnLeave = false;
            txtTelefone.HideSelection = true;
            txtTelefone.Hint = "Telefone";
            txtTelefone.InsertKeyMode = InsertKeyMode.Default;
            txtTelefone.LeadingIcon = null;
            txtTelefone.Location = new Point(348, 91);
            txtTelefone.Mask = "(99) 99999-9999";
            txtTelefone.MaxLength = 32767;
            txtTelefone.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PasswordChar = '\0';
            txtTelefone.PrefixSuffixText = null;
            txtTelefone.PromptChar = '_';
            txtTelefone.ReadOnly = false;
            txtTelefone.RejectInputOnFirstFailure = false;
            txtTelefone.ResetOnPrompt = true;
            txtTelefone.ResetOnSpace = true;
            txtTelefone.RightToLeft = RightToLeft.No;
            txtTelefone.SelectedText = "";
            txtTelefone.SelectionLength = 0;
            txtTelefone.SelectionStart = 0;
            txtTelefone.ShortcutsEnabled = true;
            txtTelefone.Size = new Size(272, 48);
            txtTelefone.SkipLiterals = true;
            txtTelefone.TabIndex = 3;
            txtTelefone.TabStop = false;
            txtTelefone.Text = "(  )      -";
            txtTelefone.TextAlign = HorizontalAlignment.Left;
            txtTelefone.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtTelefone.TrailingIcon = null;
            txtTelefone.UseSystemPasswordChar = false;
            txtTelefone.ValidatingType = null;
            // 
            // txtCargo
            // 
            txtCargo.AnimateReadOnly = false;
            txtCargo.AutoCompleteMode = AutoCompleteMode.None;
            txtCargo.AutoCompleteSource = AutoCompleteSource.None;
            txtCargo.BackgroundImageLayout = ImageLayout.None;
            txtCargo.CharacterCasing = CharacterCasing.Normal;
            txtCargo.Depth = 0;
            txtCargo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCargo.HideSelection = true;
            txtCargo.Hint = "Cargo";
            txtCargo.LeadingIcon = null;
            txtCargo.Location = new Point(264, 222);
            txtCargo.MaxLength = 32767;
            txtCargo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCargo.Name = "txtCargo";
            txtCargo.PasswordChar = '\0';
            txtCargo.PrefixSuffixText = null;
            txtCargo.ReadOnly = false;
            txtCargo.RightToLeft = RightToLeft.No;
            txtCargo.SelectedText = "";
            txtCargo.SelectionLength = 0;
            txtCargo.SelectionStart = 0;
            txtCargo.ShortcutsEnabled = true;
            txtCargo.Size = new Size(184, 48);
            txtCargo.TabIndex = 7;
            txtCargo.TabStop = false;
            txtCargo.TextAlign = HorizontalAlignment.Left;
            txtCargo.TrailingIcon = null;
            txtCargo.UseSystemPasswordChar = false;
            // 
            // txtSalario
            // 
            txtSalario.AllowPromptAsInput = true;
            txtSalario.AnimateReadOnly = false;
            txtSalario.AsciiOnly = false;
            txtSalario.BackgroundImageLayout = ImageLayout.None;
            txtSalario.BeepOnError = false;
            txtSalario.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtSalario.Depth = 0;
            txtSalario.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSalario.HidePromptOnLeave = false;
            txtSalario.HideSelection = true;
            txtSalario.Hint = "Salário";
            txtSalario.InsertKeyMode = InsertKeyMode.Default;
            txtSalario.LeadingIcon = null;
            txtSalario.Location = new Point(463, 222);
            txtSalario.Mask = "999,999.99";
            txtSalario.MaxLength = 32767;
            txtSalario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtSalario.Name = "txtSalario";
            txtSalario.PasswordChar = '\0';
            txtSalario.PrefixSuffixText = null;
            txtSalario.PromptChar = '_';
            txtSalario.ReadOnly = false;
            txtSalario.RejectInputOnFirstFailure = false;
            txtSalario.ResetOnPrompt = true;
            txtSalario.ResetOnSpace = true;
            txtSalario.RightToLeft = RightToLeft.No;
            txtSalario.SelectedText = "";
            txtSalario.SelectionLength = 0;
            txtSalario.SelectionStart = 0;
            txtSalario.ShortcutsEnabled = true;
            txtSalario.Size = new Size(157, 48);
            txtSalario.SkipLiterals = true;
            txtSalario.TabIndex = 8;
            txtSalario.TabStop = false;
            txtSalario.Text = "   .   ,";
            txtSalario.TextAlign = HorizontalAlignment.Left;
            txtSalario.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtSalario.TrailingIcon = null;
            txtSalario.UseSystemPasswordChar = false;
            txtSalario.ValidatingType = null;
            // 
            // txtEndereco
            // 
            txtEndereco.AnimateReadOnly = false;
            txtEndereco.AutoCompleteMode = AutoCompleteMode.None;
            txtEndereco.AutoCompleteSource = AutoCompleteSource.None;
            txtEndereco.BackgroundImageLayout = ImageLayout.None;
            txtEndereco.CharacterCasing = CharacterCasing.Normal;
            txtEndereco.Depth = 0;
            txtEndereco.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEndereco.HideSelection = true;
            txtEndereco.Hint = "Endereço";
            txtEndereco.LeadingIcon = null;
            txtEndereco.Location = new Point(32, 157);
            txtEndereco.MaxLength = 32767;
            txtEndereco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.PasswordChar = '\0';
            txtEndereco.PrefixSuffixText = null;
            txtEndereco.ReadOnly = false;
            txtEndereco.RightToLeft = RightToLeft.No;
            txtEndereco.SelectedText = "";
            txtEndereco.SelectionLength = 0;
            txtEndereco.SelectionStart = 0;
            txtEndereco.ShortcutsEnabled = true;
            txtEndereco.Size = new Size(355, 48);
            txtEndereco.TabIndex = 4;
            txtEndereco.TabStop = false;
            txtEndereco.TextAlign = HorizontalAlignment.Left;
            txtEndereco.TrailingIcon = null;
            txtEndereco.UseSystemPasswordChar = false;
            // 
            // txtBairro
            // 
            txtBairro.AnimateReadOnly = false;
            txtBairro.AutoCompleteMode = AutoCompleteMode.None;
            txtBairro.AutoCompleteSource = AutoCompleteSource.None;
            txtBairro.BackgroundImageLayout = ImageLayout.None;
            txtBairro.CharacterCasing = CharacterCasing.Normal;
            txtBairro.Depth = 0;
            txtBairro.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBairro.HideSelection = true;
            txtBairro.Hint = "Bairro";
            txtBairro.LeadingIcon = null;
            txtBairro.Location = new Point(405, 157);
            txtBairro.MaxLength = 32767;
            txtBairro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBairro.Name = "txtBairro";
            txtBairro.PasswordChar = '\0';
            txtBairro.PrefixSuffixText = null;
            txtBairro.ReadOnly = false;
            txtBairro.RightToLeft = RightToLeft.No;
            txtBairro.SelectedText = "";
            txtBairro.SelectionLength = 0;
            txtBairro.SelectionStart = 0;
            txtBairro.ShortcutsEnabled = true;
            txtBairro.Size = new Size(215, 48);
            txtBairro.TabIndex = 5;
            txtBairro.TabStop = false;
            txtBairro.TextAlign = HorizontalAlignment.Left;
            txtBairro.TrailingIcon = null;
            txtBairro.UseSystemPasswordChar = false;
            // 
            // txtCidade
            // 
            txtCidade.AnimateReadOnly = false;
            txtCidade.AutoCompleteMode = AutoCompleteMode.None;
            txtCidade.AutoCompleteSource = AutoCompleteSource.None;
            txtCidade.BackgroundImageLayout = ImageLayout.None;
            txtCidade.CharacterCasing = CharacterCasing.Normal;
            txtCidade.Depth = 0;
            txtCidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCidade.HideSelection = true;
            txtCidade.Hint = "Cidade";
            txtCidade.LeadingIcon = null;
            txtCidade.Location = new Point(32, 222);
            txtCidade.MaxLength = 32767;
            txtCidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCidade.Name = "txtCidade";
            txtCidade.PasswordChar = '\0';
            txtCidade.PrefixSuffixText = null;
            txtCidade.ReadOnly = false;
            txtCidade.RightToLeft = RightToLeft.No;
            txtCidade.SelectedText = "";
            txtCidade.SelectionLength = 0;
            txtCidade.SelectionStart = 0;
            txtCidade.ShortcutsEnabled = true;
            txtCidade.Size = new Size(215, 48);
            txtCidade.TabIndex = 6;
            txtCidade.TabStop = false;
            txtCidade.TextAlign = HorizontalAlignment.Left;
            txtCidade.TrailingIcon = null;
            txtCidade.UseSystemPasswordChar = false;
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.Depth = 0;
            chkStatus.Location = new Point(229, 293);
            chkStatus.Margin = new Padding(0);
            chkStatus.MouseLocation = new Point(-1, -1);
            chkStatus.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            chkStatus.Name = "chkStatus";
            chkStatus.ReadOnly = false;
            chkStatus.Ripple = true;
            chkStatus.Size = new Size(75, 37);
            chkStatus.TabIndex = 10;
            chkStatus.Text = "Ativo ";
            chkStatus.UseAccentColor = false;
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // txtDataAdmissao
            // 
            txtDataAdmissao.AllowPromptAsInput = true;
            txtDataAdmissao.AnimateReadOnly = false;
            txtDataAdmissao.AsciiOnly = false;
            txtDataAdmissao.BackgroundImageLayout = ImageLayout.None;
            txtDataAdmissao.BeepOnError = false;
            txtDataAdmissao.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataAdmissao.Depth = 0;
            txtDataAdmissao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataAdmissao.HidePromptOnLeave = false;
            txtDataAdmissao.HideSelection = true;
            txtDataAdmissao.Hint = "Data Admissão";
            txtDataAdmissao.InsertKeyMode = InsertKeyMode.Default;
            txtDataAdmissao.LeadingIcon = null;
            txtDataAdmissao.Location = new Point(32, 287);
            txtDataAdmissao.Mask = "99/99/9999";
            txtDataAdmissao.MaxLength = 32767;
            txtDataAdmissao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataAdmissao.Name = "txtDataAdmissao";
            txtDataAdmissao.PasswordChar = '\0';
            txtDataAdmissao.PrefixSuffixText = null;
            txtDataAdmissao.PromptChar = '_';
            txtDataAdmissao.ReadOnly = false;
            txtDataAdmissao.RejectInputOnFirstFailure = false;
            txtDataAdmissao.ResetOnPrompt = true;
            txtDataAdmissao.ResetOnSpace = true;
            txtDataAdmissao.RightToLeft = RightToLeft.No;
            txtDataAdmissao.SelectedText = "";
            txtDataAdmissao.SelectionLength = 0;
            txtDataAdmissao.SelectionStart = 0;
            txtDataAdmissao.ShortcutsEnabled = true;
            txtDataAdmissao.Size = new Size(157, 48);
            txtDataAdmissao.SkipLiterals = true;
            txtDataAdmissao.TabIndex = 9;
            txtDataAdmissao.TabStop = false;
            txtDataAdmissao.Text = "  /  /";
            txtDataAdmissao.TextAlign = HorizontalAlignment.Left;
            txtDataAdmissao.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataAdmissao.TrailingIcon = null;
            txtDataAdmissao.UseSystemPasswordChar = false;
            txtDataAdmissao.ValidatingType = null;
            // 
            // CadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 562);
            Location = new Point(0, 0);
            Name = "CadastroFuncionario";
            Text = "Cadastro de Funcionario";
            TabControlCadastro.ResumeLayout(false);
            TabPageCadastro.ResumeLayout(false);
            TabPageCadastro.PerformLayout();
            TabPageConsulta.ResumeLayout(false);
            TabPageConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtCpf;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCargo;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtTelefone;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtSalario;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBairro;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEndereco;
        private ReaLTaiizor.Controls.MaterialCheckBox chkStatus;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataAdmissao;
    }
}