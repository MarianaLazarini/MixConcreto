namespace MixConcreto.App
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            funcionárioToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            veículoToolStripMenuItem = new ToolStripMenuItem();
            estoqueToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            pedidoToolStripMenuItem = new ToolStripMenuItem();
            produçãoToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(3, 64);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(794, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clienteToolStripMenuItem, funcionárioToolStripMenuItem, toolStripMenuItem1, veículoToolStripMenuItem, estoqueToolStripMenuItem, toolStripMenuItem2, pedidoToolStripMenuItem, produçãoToolStripMenuItem });
            cadastrosToolStripMenuItem.Image = Properties.Resources.Cadastros;
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(87, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Image = Properties.Resources.ClienteIcon;
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(137, 22);
            clienteToolStripMenuItem.Text = "Cliente";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // funcionárioToolStripMenuItem
            // 
            funcionárioToolStripMenuItem.Image = Properties.Resources.FuncionarioIcon;
            funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            funcionárioToolStripMenuItem.Size = new Size(137, 22);
            funcionárioToolStripMenuItem.Text = "Funcionário";
            funcionárioToolStripMenuItem.Click += funcionárioToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(134, 6);
            // 
            // veículoToolStripMenuItem
            // 
            veículoToolStripMenuItem.Image = Properties.Resources.VeiculoIcon;
            veículoToolStripMenuItem.Name = "veículoToolStripMenuItem";
            veículoToolStripMenuItem.Size = new Size(137, 22);
            veículoToolStripMenuItem.Text = "Veículo";
            veículoToolStripMenuItem.Click += veículoToolStripMenuItem_Click;
            // 
            // estoqueToolStripMenuItem
            // 
            estoqueToolStripMenuItem.Image = Properties.Resources.EstoqueIcon;
            estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            estoqueToolStripMenuItem.Size = new Size(137, 22);
            estoqueToolStripMenuItem.Text = "Estoque";
            estoqueToolStripMenuItem.Click += estoqueToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(134, 6);
            // 
            // pedidoToolStripMenuItem
            // 
            pedidoToolStripMenuItem.Image = Properties.Resources.PedidoIcon;
            pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            pedidoToolStripMenuItem.Size = new Size(137, 22);
            pedidoToolStripMenuItem.Text = "Pedido";
            pedidoToolStripMenuItem.Click += pedidoToolStripMenuItem_Click;
            // 
            // produçãoToolStripMenuItem
            // 
            produçãoToolStripMenuItem.Image = Properties.Resources.ProducaoIcon;
            produçãoToolStripMenuItem.Name = "produçãoToolStripMenuItem";
            produçãoToolStripMenuItem.Size = new Size(137, 22);
            produçãoToolStripMenuItem.Text = "Produção";
            produçãoToolStripMenuItem.Click += produçãoToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema MixConcreto";
            WindowState = FormWindowState.Maximized;
            FormClosing += Principal_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem funcionárioToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem veículoToolStripMenuItem;
        private ToolStripMenuItem estoqueToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem pedidoToolStripMenuItem;
        private ToolStripMenuItem produçãoToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}
