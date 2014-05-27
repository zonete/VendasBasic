namespace Vendas
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saídaReqToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaNFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devoluçãoDevToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoSaldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saldoNaDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasNoMêsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.movimentaçãoToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(434, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtoToolStripMenuItem1,
            this.clienteToolStripMenuItem1,
            this.usuárioToolStripMenuItem1});
            this.cadastroToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cadastroToolStripMenuItem.Image = global::Vendas.Properties.Resources.User_Files_icon;
            this.cadastroToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(100, 28);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // produtoToolStripMenuItem1
            // 
            this.produtoToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.produtoToolStripMenuItem1.Image = global::Vendas.Properties.Resources.produtos;
            this.produtoToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.produtoToolStripMenuItem1.Name = "produtoToolStripMenuItem1";
            this.produtoToolStripMenuItem1.Size = new System.Drawing.Size(160, 30);
            this.produtoToolStripMenuItem1.Text = "Produto";
            this.produtoToolStripMenuItem1.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.clienteToolStripMenuItem1.Image = global::Vendas.Properties.Resources.cliente;
            this.clienteToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(160, 30);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            this.clienteToolStripMenuItem1.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // usuárioToolStripMenuItem1
            // 
            this.usuárioToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.usuárioToolStripMenuItem1.Image = global::Vendas.Properties.Resources.Places_user_identity_icon;
            this.usuárioToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usuárioToolStripMenuItem1.Name = "usuárioToolStripMenuItem1";
            this.usuárioToolStripMenuItem1.Size = new System.Drawing.Size(160, 30);
            this.usuárioToolStripMenuItem1.Text = "Usuário";
            this.usuárioToolStripMenuItem1.Click += new System.EventHandler(this.usuárioToolStripMenuItem_Click);
            // 
            // movimentaçãoToolStripMenuItem
            // 
            this.movimentaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saídaReqToolStripMenuItem,
            this.entradaNFToolStripMenuItem,
            this.devoluçãoDevToolStripMenuItem});
            this.movimentaçãoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.movimentaçãoToolStripMenuItem.Image = global::Vendas.Properties.Resources.move;
            this.movimentaçãoToolStripMenuItem.Name = "movimentaçãoToolStripMenuItem";
            this.movimentaçãoToolStripMenuItem.Size = new System.Drawing.Size(128, 28);
            this.movimentaçãoToolStripMenuItem.Text = "Movimentação";
            // 
            // saídaReqToolStripMenuItem
            // 
            this.saídaReqToolStripMenuItem.Image = global::Vendas.Properties.Resources.Cart_icon;
            this.saídaReqToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saídaReqToolStripMenuItem.Name = "saídaReqToolStripMenuItem";
            this.saídaReqToolStripMenuItem.Size = new System.Drawing.Size(194, 30);
            this.saídaReqToolStripMenuItem.Text = "Saída (Vendas)";
            this.saídaReqToolStripMenuItem.Click += new System.EventHandler(this.saídaReqToolStripMenuItem_Click);
            // 
            // entradaNFToolStripMenuItem
            // 
            this.entradaNFToolStripMenuItem.Image = global::Vendas.Properties.Resources.Actions_irc_join_channel_icon;
            this.entradaNFToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.entradaNFToolStripMenuItem.Name = "entradaNFToolStripMenuItem";
            this.entradaNFToolStripMenuItem.Size = new System.Drawing.Size(194, 30);
            this.entradaNFToolStripMenuItem.Text = "Entrada (NF)";
            this.entradaNFToolStripMenuItem.Click += new System.EventHandler(this.entradaMaterialToolStripMenuItem_Click);
            // 
            // devoluçãoDevToolStripMenuItem
            // 
            this.devoluçãoDevToolStripMenuItem.Image = global::Vendas.Properties.Resources.Actions_configure_toolbars_icon;
            this.devoluçãoDevToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.devoluçãoDevToolStripMenuItem.Name = "devoluçãoDevToolStripMenuItem";
            this.devoluçãoDevToolStripMenuItem.Size = new System.Drawing.Size(194, 30);
            this.devoluçãoDevToolStripMenuItem.Text = "Acerto Estq (Ajus)";
            this.devoluçãoDevToolStripMenuItem.Click += new System.EventHandler(this.devoluçãoDevToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtoSaldoToolStripMenuItem,
            this.saldoNaDataToolStripMenuItem,
            this.vendasNoMêsToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.relatóriosToolStripMenuItem.Image = global::Vendas.Properties.Resources.report;
            this.relatóriosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(105, 28);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // produtoSaldoToolStripMenuItem
            // 
            this.produtoSaldoToolStripMenuItem.Name = "produtoSaldoToolStripMenuItem";
            this.produtoSaldoToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.produtoSaldoToolStripMenuItem.Text = "Saldo Atual";
            this.produtoSaldoToolStripMenuItem.Click += new System.EventHandler(this.produtoSaldoToolStripMenuItem_Click);
            // 
            // saldoNaDataToolStripMenuItem
            // 
            this.saldoNaDataToolStripMenuItem.Name = "saldoNaDataToolStripMenuItem";
            this.saldoNaDataToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.saldoNaDataToolStripMenuItem.Text = "Saldo na Data";
            this.saldoNaDataToolStripMenuItem.Click += new System.EventHandler(this.saldoNaDataToolStripMenuItem_Click);
            // 
            // vendasNoMêsToolStripMenuItem
            // 
            this.vendasNoMêsToolStripMenuItem.Name = "vendasNoMêsToolStripMenuItem";
            this.vendasNoMêsToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.vendasNoMêsToolStripMenuItem.Text = "Vendas no Mês";
            this.vendasNoMêsToolStripMenuItem.Click += new System.EventHandler(this.vendasNoMêsToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sobreToolStripMenuItem.Image = global::Vendas.Properties.Resources.Actions_help_about_icon;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(72, 28);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 140);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Vendas Basic  -  Versão [0.002]";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem movimentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaNFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saídaReqToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devoluçãoDevToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoSaldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saldoNaDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasNoMêsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem1;
    }
}