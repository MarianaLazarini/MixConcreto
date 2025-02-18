namespace MixConcreto.App.Cadastros
{
    partial class CadastroVeiculo
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
            txtPlaca = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtModelo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCapacidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtAno = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboSituacao = new ReaLTaiizor.Controls.MaterialComboBox();
            TabControlCadastro.SuspendLayout();
            TabPageCadastro.SuspendLayout();
            TabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // TabControlCadastro
            // 
            TabControlCadastro.Size = new Size(562, 401);
            // 
            // TabPageCadastro
            // 
            TabPageCadastro.Controls.Add(cboSituacao);
            TabPageCadastro.Controls.Add(txtAno);
            TabPageCadastro.Controls.Add(txtCapacidade);
            TabPageCadastro.Controls.Add(txtModelo);
            TabPageCadastro.Controls.Add(txtPlaca);
            TabPageCadastro.Controls.Add(txtId);
            TabPageCadastro.Size = new Size(554, 366);
            TabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            TabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            TabPageCadastro.Controls.SetChildIndex(txtId, 0);
            TabPageCadastro.Controls.SetChildIndex(txtPlaca, 0);
            TabPageCadastro.Controls.SetChildIndex(txtModelo, 0);
            TabPageCadastro.Controls.SetChildIndex(txtCapacidade, 0);
            TabPageCadastro.Controls.SetChildIndex(txtAno, 0);
            TabPageCadastro.Controls.SetChildIndex(cboSituacao, 0);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(227, 238);
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(343, 238);
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(456, 288);
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(364, 288);
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(280, 288);
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
            txtId.Location = new Point(45, 50);
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
            txtId.Size = new Size(159, 48);
            txtId.TabIndex = 2;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtPlaca
            // 
            txtPlaca.AnimateReadOnly = false;
            txtPlaca.AutoCompleteMode = AutoCompleteMode.None;
            txtPlaca.AutoCompleteSource = AutoCompleteSource.None;
            txtPlaca.BackgroundImageLayout = ImageLayout.None;
            txtPlaca.CharacterCasing = CharacterCasing.Normal;
            txtPlaca.Depth = 0;
            txtPlaca.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPlaca.HideSelection = true;
            txtPlaca.Hint = "Placa";
            txtPlaca.LeadingIcon = null;
            txtPlaca.Location = new Point(236, 50);
            txtPlaca.MaxLength = 32767;
            txtPlaca.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPlaca.Name = "txtPlaca";
            txtPlaca.PasswordChar = '\0';
            txtPlaca.PrefixSuffixText = null;
            txtPlaca.ReadOnly = false;
            txtPlaca.RightToLeft = RightToLeft.No;
            txtPlaca.SelectedText = "";
            txtPlaca.SelectionLength = 0;
            txtPlaca.SelectionStart = 0;
            txtPlaca.ShortcutsEnabled = true;
            txtPlaca.Size = new Size(250, 48);
            txtPlaca.TabIndex = 3;
            txtPlaca.TabStop = false;
            txtPlaca.TextAlign = HorizontalAlignment.Left;
            txtPlaca.TrailingIcon = null;
            txtPlaca.UseSystemPasswordChar = false;
            // 
            // txtModelo
            // 
            txtModelo.AnimateReadOnly = false;
            txtModelo.AutoCompleteMode = AutoCompleteMode.None;
            txtModelo.AutoCompleteSource = AutoCompleteSource.None;
            txtModelo.BackgroundImageLayout = ImageLayout.None;
            txtModelo.CharacterCasing = CharacterCasing.Normal;
            txtModelo.Depth = 0;
            txtModelo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtModelo.HideSelection = true;
            txtModelo.Hint = "Modelo";
            txtModelo.LeadingIcon = null;
            txtModelo.Location = new Point(45, 121);
            txtModelo.MaxLength = 32767;
            txtModelo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtModelo.Name = "txtModelo";
            txtModelo.PasswordChar = '\0';
            txtModelo.PrefixSuffixText = null;
            txtModelo.ReadOnly = false;
            txtModelo.RightToLeft = RightToLeft.No;
            txtModelo.SelectedText = "";
            txtModelo.SelectionLength = 0;
            txtModelo.SelectionStart = 0;
            txtModelo.ShortcutsEnabled = true;
            txtModelo.Size = new Size(441, 48);
            txtModelo.TabIndex = 4;
            txtModelo.TabStop = false;
            txtModelo.TextAlign = HorizontalAlignment.Left;
            txtModelo.TrailingIcon = null;
            txtModelo.UseSystemPasswordChar = false;
            // 
            // txtCapacidade
            // 
            txtCapacidade.AnimateReadOnly = false;
            txtCapacidade.AutoCompleteMode = AutoCompleteMode.None;
            txtCapacidade.AutoCompleteSource = AutoCompleteSource.None;
            txtCapacidade.BackgroundImageLayout = ImageLayout.None;
            txtCapacidade.CharacterCasing = CharacterCasing.Normal;
            txtCapacidade.Depth = 0;
            txtCapacidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCapacidade.HideSelection = true;
            txtCapacidade.Hint = "Capacidade";
            txtCapacidade.LeadingIcon = null;
            txtCapacidade.Location = new Point(45, 188);
            txtCapacidade.MaxLength = 32767;
            txtCapacidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCapacidade.Name = "txtCapacidade";
            txtCapacidade.PasswordChar = '\0';
            txtCapacidade.PrefixSuffixText = null;
            txtCapacidade.ReadOnly = false;
            txtCapacidade.RightToLeft = RightToLeft.No;
            txtCapacidade.SelectedText = "";
            txtCapacidade.SelectionLength = 0;
            txtCapacidade.SelectionStart = 0;
            txtCapacidade.ShortcutsEnabled = true;
            txtCapacidade.Size = new Size(134, 48);
            txtCapacidade.TabIndex = 5;
            txtCapacidade.TabStop = false;
            txtCapacidade.TextAlign = HorizontalAlignment.Left;
            txtCapacidade.TrailingIcon = null;
            txtCapacidade.UseSystemPasswordChar = false;
            // 
            // txtAno
            // 
            txtAno.AnimateReadOnly = false;
            txtAno.AutoCompleteMode = AutoCompleteMode.None;
            txtAno.AutoCompleteSource = AutoCompleteSource.None;
            txtAno.BackgroundImageLayout = ImageLayout.None;
            txtAno.CharacterCasing = CharacterCasing.Normal;
            txtAno.Depth = 0;
            txtAno.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAno.HideSelection = true;
            txtAno.Hint = "Ano";
            txtAno.LeadingIcon = null;
            txtAno.Location = new Point(199, 188);
            txtAno.MaxLength = 32767;
            txtAno.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtAno.Name = "txtAno";
            txtAno.PasswordChar = '\0';
            txtAno.PrefixSuffixText = null;
            txtAno.ReadOnly = false;
            txtAno.RightToLeft = RightToLeft.No;
            txtAno.SelectedText = "";
            txtAno.SelectionLength = 0;
            txtAno.SelectionStart = 0;
            txtAno.ShortcutsEnabled = true;
            txtAno.Size = new Size(122, 48);
            txtAno.TabIndex = 6;
            txtAno.TabStop = false;
            txtAno.TextAlign = HorizontalAlignment.Left;
            txtAno.TrailingIcon = null;
            txtAno.UseSystemPasswordChar = false;
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
            cboSituacao.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboSituacao.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboSituacao.FormattingEnabled = true;
            cboSituacao.Hint = "Situação";
            cboSituacao.IntegralHeight = false;
            cboSituacao.ItemHeight = 43;
            cboSituacao.Items.AddRange(new object[] { "Em Uso", "Manutenção", "Disponível" });
            cboSituacao.Location = new Point(341, 187);
            cboSituacao.MaxDropDownItems = 4;
            cboSituacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboSituacao.Name = "cboSituacao";
            cboSituacao.Size = new Size(145, 49);
            cboSituacao.StartIndex = 0;
            cboSituacao.TabIndex = 7;
            // 
            // CadastroVeiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 468);
            Location = new Point(0, 0);
            Name = "CadastroVeiculo";
            Text = "Cadastro de Veiculo";
            TabControlCadastro.ResumeLayout(false);
            TabPageCadastro.ResumeLayout(false);
            TabPageCadastro.PerformLayout();
            TabPageConsulta.ResumeLayout(false);
            TabPageConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtAno;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCapacidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtModelo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPlaca;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialComboBox cboSituacao;
    }
}