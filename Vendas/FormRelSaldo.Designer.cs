namespace Vendas
{
    partial class FormRelSaldo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idprod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo_atual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opcoes = new System.Windows.Forms.ComboBox();
            this.txtPesq = new System.Windows.Forms.TextBox();
            this.dataSet1 = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprod,
            this.descricao,
            this.saldo_atual,
            this.data});
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(715, 336);
            this.dataGridView1.TabIndex = 0;
            // 
            // idprod
            // 
            this.idprod.DataPropertyName = "idprod";
            this.idprod.HeaderText = "Código";
            this.idprod.Name = "idprod";
            this.idprod.ReadOnly = true;
            this.idprod.Width = 80;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Produto";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 250;
            // 
            // saldo_atual
            // 
            this.saldo_atual.DataPropertyName = "saldo_atual";
            this.saldo_atual.HeaderText = "Saldo";
            this.saldo_atual.Name = "saldo_atual";
            this.saldo_atual.ReadOnly = true;
            // 
            // data
            // 
            this.data.DataPropertyName = "data";
            this.data.HeaderText = "Data Ultima Movimentação";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Width = 200;
            // 
            // Opcoes
            // 
            this.Opcoes.FormattingEnabled = true;
            this.Opcoes.Items.AddRange(new object[] {
            "Código",
            "Produto"});
            this.Opcoes.Location = new System.Drawing.Point(12, 21);
            this.Opcoes.Name = "Opcoes";
            this.Opcoes.Size = new System.Drawing.Size(203, 21);
            this.Opcoes.TabIndex = 20;
            this.Opcoes.SelectedIndexChanged += new System.EventHandler(this.Opcoes_SelectedIndexChanged);
            // 
            // txtPesq
            // 
            this.txtPesq.Location = new System.Drawing.Point(221, 22);
            this.txtPesq.Name = "txtPesq";
            this.txtPesq.Size = new System.Drawing.Size(506, 20);
            this.txtPesq.TabIndex = 21;
            this.txtPesq.TextChanged += new System.EventHandler(this.txtPesq_TextChanged);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // FormRelSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 396);
            this.Controls.Add(this.Opcoes);
            this.Controls.Add(this.txtPesq);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormRelSaldo";
            this.Text = "Saldo Atual Produtos";
            this.Load += new System.EventHandler(this.FormRelSaldo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox Opcoes;
        private System.Windows.Forms.TextBox txtPesq;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprod;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo_atual;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
    }
}