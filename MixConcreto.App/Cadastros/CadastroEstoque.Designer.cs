namespace MixConcreto.App.Cadastros
{
    partial class CadastroEstoque
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
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtFornecedor = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtQtdAtual = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtUnidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPrecoUnit = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            TabControlCadastro.SuspendLayout();
            TabPageCadastro.SuspendLayout();
            TabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // TabControlCadastro
            // 
            TabControlCadastro.Size = new Size(607, 385);
            // 
            // TabPageCadastro
            // 
            TabPageCadastro.Controls.Add(txtPrecoUnit);
            TabPageCadastro.Controls.Add(txtUnidade);
            TabPageCadastro.Controls.Add(txtQtdAtual);
            TabPageCadastro.Controls.Add(txtFornecedor);
            TabPageCadastro.Controls.Add(txtNome);
            TabPageCadastro.Controls.Add(txtId);
            TabPageCadastro.Size = new Size(599, 350);
            TabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            TabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            TabPageCadastro.Controls.SetChildIndex(txtId, 0);
            TabPageCadastro.Controls.SetChildIndex(txtNome, 0);
            TabPageCadastro.Controls.SetChildIndex(txtFornecedor, 0);
            TabPageCadastro.Controls.SetChildIndex(txtQtdAtual, 0);
            TabPageCadastro.Controls.SetChildIndex(txtUnidade, 0);
            TabPageCadastro.Controls.SetChildIndex(txtPrecoUnit, 0);
            // 
            // TabPageConsulta
            // 
            TabPageConsulta.Size = new Size(599, 350);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(258, 109);
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(374, 109);
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(385, 77);
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(293, 77);
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(209, 77);
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
            txtId.Location = new Point(32, 27);
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
            txtId.Size = new Size(144, 48);
            txtId.TabIndex = 2;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
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
            txtNome.Location = new Point(205, 27);
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
            txtNome.Size = new Size(365, 48);
            txtNome.TabIndex = 3;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtFornecedor
            // 
            txtFornecedor.AnimateReadOnly = false;
            txtFornecedor.AutoCompleteMode = AutoCompleteMode.None;
            txtFornecedor.AutoCompleteSource = AutoCompleteSource.None;
            txtFornecedor.BackgroundImageLayout = ImageLayout.None;
            txtFornecedor.CharacterCasing = CharacterCasing.Normal;
            txtFornecedor.Depth = 0;
            txtFornecedor.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtFornecedor.HideSelection = true;
            txtFornecedor.Hint = "Fornecedor";
            txtFornecedor.LeadingIcon = null;
            txtFornecedor.Location = new Point(32, 100);
            txtFornecedor.MaxLength = 32767;
            txtFornecedor.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtFornecedor.Name = "txtFornecedor";
            txtFornecedor.PasswordChar = '\0';
            txtFornecedor.PrefixSuffixText = null;
            txtFornecedor.ReadOnly = false;
            txtFornecedor.RightToLeft = RightToLeft.No;
            txtFornecedor.SelectedText = "";
            txtFornecedor.SelectionLength = 0;
            txtFornecedor.SelectionStart = 0;
            txtFornecedor.ShortcutsEnabled = true;
            txtFornecedor.Size = new Size(538, 48);
            txtFornecedor.TabIndex = 4;
            txtFornecedor.TabStop = false;
            txtFornecedor.TextAlign = HorizontalAlignment.Left;
            txtFornecedor.TrailingIcon = null;
            txtFornecedor.UseSystemPasswordChar = false;
            // 
            // txtQtdAtual
            // 
            txtQtdAtual.AnimateReadOnly = false;
            txtQtdAtual.AutoCompleteMode = AutoCompleteMode.None;
            txtQtdAtual.AutoCompleteSource = AutoCompleteSource.None;
            txtQtdAtual.BackgroundImageLayout = ImageLayout.None;
            txtQtdAtual.CharacterCasing = CharacterCasing.Normal;
            txtQtdAtual.Depth = 0;
            txtQtdAtual.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQtdAtual.HideSelection = true;
            txtQtdAtual.Hint = "Quantidade Atual";
            txtQtdAtual.LeadingIcon = null;
            txtQtdAtual.Location = new Point(32, 167);
            txtQtdAtual.MaxLength = 32767;
            txtQtdAtual.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtQtdAtual.Name = "txtQtdAtual";
            txtQtdAtual.PasswordChar = '\0';
            txtQtdAtual.PrefixSuffixText = null;
            txtQtdAtual.ReadOnly = false;
            txtQtdAtual.RightToLeft = RightToLeft.No;
            txtQtdAtual.SelectedText = "";
            txtQtdAtual.SelectionLength = 0;
            txtQtdAtual.SelectionStart = 0;
            txtQtdAtual.ShortcutsEnabled = true;
            txtQtdAtual.Size = new Size(187, 48);
            txtQtdAtual.TabIndex = 5;
            txtQtdAtual.TabStop = false;
            txtQtdAtual.TextAlign = HorizontalAlignment.Left;
            txtQtdAtual.TrailingIcon = null;
            txtQtdAtual.UseSystemPasswordChar = false;
            // 
            // txtUnidade
            // 
            txtUnidade.AnimateReadOnly = false;
            txtUnidade.AutoCompleteMode = AutoCompleteMode.None;
            txtUnidade.AutoCompleteSource = AutoCompleteSource.None;
            txtUnidade.BackgroundImageLayout = ImageLayout.None;
            txtUnidade.CharacterCasing = CharacterCasing.Normal;
            txtUnidade.Depth = 0;
            txtUnidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUnidade.HideSelection = true;
            txtUnidade.Hint = "Unidade";
            txtUnidade.LeadingIcon = null;
            txtUnidade.Location = new Point(237, 167);
            txtUnidade.MaxLength = 32767;
            txtUnidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtUnidade.Name = "txtUnidade";
            txtUnidade.PasswordChar = '\0';
            txtUnidade.PrefixSuffixText = null;
            txtUnidade.ReadOnly = false;
            txtUnidade.RightToLeft = RightToLeft.No;
            txtUnidade.SelectedText = "";
            txtUnidade.SelectionLength = 0;
            txtUnidade.SelectionStart = 0;
            txtUnidade.ShortcutsEnabled = true;
            txtUnidade.Size = new Size(142, 48);
            txtUnidade.TabIndex = 6;
            txtUnidade.TabStop = false;
            txtUnidade.TextAlign = HorizontalAlignment.Left;
            txtUnidade.TrailingIcon = null;
            txtUnidade.UseSystemPasswordChar = false;
            // 
            // txtPrecoUnit
            // 
            txtPrecoUnit.AllowPromptAsInput = true;
            txtPrecoUnit.AnimateReadOnly = false;
            txtPrecoUnit.AsciiOnly = false;
            txtPrecoUnit.BackgroundImageLayout = ImageLayout.None;
            txtPrecoUnit.BeepOnError = false;
            txtPrecoUnit.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtPrecoUnit.Depth = 0;
            txtPrecoUnit.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrecoUnit.HidePromptOnLeave = false;
            txtPrecoUnit.HideSelection = true;
            txtPrecoUnit.Hint = "Preço Unitário";
            txtPrecoUnit.InsertKeyMode = InsertKeyMode.Default;
            txtPrecoUnit.LeadingIcon = null;
            txtPrecoUnit.Location = new Point(401, 167);
            txtPrecoUnit.Mask = "9,999.99";
            txtPrecoUnit.MaxLength = 32767;
            txtPrecoUnit.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPrecoUnit.Name = "txtPrecoUnit";
            txtPrecoUnit.PasswordChar = '\0';
            txtPrecoUnit.PrefixSuffixText = null;
            txtPrecoUnit.PromptChar = '_';
            txtPrecoUnit.ReadOnly = false;
            txtPrecoUnit.RejectInputOnFirstFailure = false;
            txtPrecoUnit.ResetOnPrompt = true;
            txtPrecoUnit.ResetOnSpace = true;
            txtPrecoUnit.RightToLeft = RightToLeft.No;
            txtPrecoUnit.SelectedText = "";
            txtPrecoUnit.SelectionLength = 0;
            txtPrecoUnit.SelectionStart = 0;
            txtPrecoUnit.ShortcutsEnabled = true;
            txtPrecoUnit.Size = new Size(169, 48);
            txtPrecoUnit.SkipLiterals = true;
            txtPrecoUnit.TabIndex = 7;
            txtPrecoUnit.TabStop = false;
            txtPrecoUnit.Text = " .   ,";
            txtPrecoUnit.TextAlign = HorizontalAlignment.Left;
            txtPrecoUnit.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtPrecoUnit.TrailingIcon = null;
            txtPrecoUnit.UseSystemPasswordChar = false;
            txtPrecoUnit.ValidatingType = null;
            // 
            // CadastroEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 452);
            Location = new Point(0, 0);
            Name = "CadastroEstoque";
            Text = "Cadastro de Estoque";
            TabControlCadastro.ResumeLayout(false);
            TabPageCadastro.ResumeLayout(false);
            TabPageCadastro.PerformLayout();
            TabPageConsulta.ResumeLayout(false);
            TabPageConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtFornecedor;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtUnidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtQtdAtual;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtPrecoUnit;
    }
}