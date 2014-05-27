namespace Vendas
{
    partial class FormCadProd
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
            this.Opcoes = new System.Windows.Forms.ComboBox();
            this.txtPesq = new System.Windows.Forms.TextBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblindicador = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataCad = new System.Windows.Forms.DateTimePicker();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.dataComp = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFabr = new System.Windows.Forms.TextBox();
            this.txtSaldo = new txtNumerico.TxtNumerico();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVenda = new txtNumerico.TxtNumerico();
            this.txtEstoq = new txtNumerico.TxtNumerico();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCompra = new txtNumerico.TxtNumerico();
            this.TxtUnidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(760, 375);
            this.dataGridView1.TabIndex = 0;
            // 
            // Opcoes
            // 
            this.Opcoes.FormattingEnabled = true;
            this.Opcoes.Items.AddRange(new object[] {
            "Descrição",
            "Código",
            "Fabricante"});
            this.Opcoes.Location = new System.Drawing.Point(12, 18);
            this.Opcoes.Name = "Opcoes";
            this.Opcoes.Size = new System.Drawing.Size(203, 21);
            this.Opcoes.TabIndex = 5;
            // 
            // txtPesq
            // 
            this.txtPesq.Location = new System.Drawing.Point(221, 19);
            this.txtPesq.Name = "txtPesq";
            this.txtPesq.Size = new System.Drawing.Size(551, 20);
            this.txtPesq.TabIndex = 6;
            this.txtPesq.TextChanged += new System.EventHandler(this.txtPesq_TextChanged);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(176, 426);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 9;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(95, 426);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(14, 426);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 7;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(464, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 460);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblindicador);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtCodigo);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dataCad);
            this.panel2.Controls.Add(this.txtDesc);
            this.panel2.Controls.Add(this.dataComp);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtFabr);
            this.panel2.Controls.Add(this.txtSaldo);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtVenda);
            this.panel2.Controls.Add(this.txtEstoq);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtCompra);
            this.panel2.Controls.Add(this.TxtUnidade);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(611, 230);
            this.panel2.TabIndex = 31;
            // 
            // lblindicador
            // 
            this.lblindicador.AutoSize = true;
            this.lblindicador.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblindicador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblindicador.Location = new System.Drawing.Point(0, 0);
            this.lblindicador.Name = "lblindicador";
            this.lblindicador.Size = new System.Drawing.Size(70, 13);
            this.lblindicador.TabIndex = 32;
            this.lblindicador.Text = "Inserir/Alterar";
            this.lblindicador.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 84);
            this.button1.TabIndex = 10;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(112, 16);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(519, 14);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Data Cad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Código";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Data Ult. Comp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Descrição";
            // 
            // dataCad
            // 
            this.dataCad.Enabled = false;
            this.dataCad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataCad.Location = new System.Drawing.Point(112, 68);
            this.dataCad.Name = "dataCad";
            this.dataCad.Size = new System.Drawing.Size(100, 20);
            this.dataCad.TabIndex = 2;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(112, 94);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(369, 20);
            this.txtDesc.TabIndex = 3;
            // 
            // dataComp
            // 
            this.dataComp.Enabled = false;
            this.dataComp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataComp.Location = new System.Drawing.Point(112, 42);
            this.dataComp.Name = "dataComp";
            this.dataComp.Size = new System.Drawing.Size(100, 20);
            this.dataComp.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Saldo";
            // 
            // txtFabr
            // 
            this.txtFabr.Location = new System.Drawing.Point(112, 120);
            this.txtFabr.Name = "txtFabr";
            this.txtFabr.Size = new System.Drawing.Size(369, 20);
            this.txtFabr.TabIndex = 4;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(112, 150);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(88, 20);
            this.txtSaldo.TabIndex = 5;
            this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Fabricante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Estoque Min.";
            // 
            // txtVenda
            // 
            this.txtVenda.Location = new System.Drawing.Point(277, 176);
            this.txtVenda.Name = "txtVenda";
            this.txtVenda.Size = new System.Drawing.Size(88, 20);
            this.txtVenda.TabIndex = 9;
            this.txtVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEstoq
            // 
            this.txtEstoq.Location = new System.Drawing.Point(277, 150);
            this.txtEstoq.Name = "txtEstoq";
            this.txtEstoq.Size = new System.Drawing.Size(88, 20);
            this.txtEstoq.TabIndex = 6;
            this.txtEstoq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Preço Venda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Unidade";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtCompra
            // 
            this.txtCompra.Location = new System.Drawing.Point(112, 176);
            this.txtCompra.Name = "txtCompra";
            this.txtCompra.Size = new System.Drawing.Size(88, 20);
            this.txtCompra.TabIndex = 8;
            this.txtCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtUnidade
            // 
            this.TxtUnidade.Location = new System.Drawing.Point(420, 150);
            this.TxtUnidade.Name = "TxtUnidade";
            this.TxtUnidade.Size = new System.Drawing.Size(58, 20);
            this.TxtUnidade.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Preço Compra";
            // 
            // FormCadProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Opcoes);
            this.Controls.Add(this.txtPesq);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormCadProd";
            this.ShowIcon = false;
            this.Text = "Cadastro de Produto";
            this.Load += new System.EventHandler(this.FormCadProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox Opcoes;
        private System.Windows.Forms.TextBox txtPesq;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private txtNumerico.TxtNumerico txtSaldo;
        private System.Windows.Forms.TextBox TxtUnidade;
        private System.Windows.Forms.Label label5;
        private txtNumerico.TxtNumerico txtEstoq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dataCad;
        private System.Windows.Forms.DateTimePicker dataComp;
        private System.Windows.Forms.TextBox txtFabr;
        private System.Windows.Forms.Label label8;
        private txtNumerico.TxtNumerico txtVenda;
        private System.Windows.Forms.Label label6;
        private txtNumerico.TxtNumerico txtCompra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblindicador;
    }
}