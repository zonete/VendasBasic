namespace Vendas
{
    partial class FormVendas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVendas));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtidvenda = new System.Windows.Forms.MaskedTextBox();
            this.btnnew = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalv = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.descCliente = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnexcluiitem = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.btnAdicEdit = new System.Windows.Forms.Button();
            this.txtPreco = new txtNumerico.TxtNumerico();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQtde = new txtNumerico.TxtNumerico();
            this.DescProd = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodProd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datevenda = new System.Windows.Forms.DateTimePicker();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código Venda";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtidvenda);
            this.panel1.Controls.Add(this.btnnew);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 45);
            this.panel1.TabIndex = 2;
            // 
            // txtidvenda
            // 
            this.txtidvenda.BackColor = System.Drawing.Color.White;
            this.txtidvenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtidvenda.Location = new System.Drawing.Point(114, 13);
            this.txtidvenda.Name = "txtidvenda";
            this.txtidvenda.Size = new System.Drawing.Size(135, 20);
            this.txtidvenda.TabIndex = 0;
            this.txtidvenda.Tag = "";
            this.txtidvenda.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtidvenda_MaskInputRejected);
            this.txtidvenda.TextChanged += new System.EventHandler(this.txtidvenda_TextChanged);
            this.txtidvenda.DoubleClick += new System.EventHandler(this.txtidvenda_DoubleClick);
            this.txtidvenda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtidvenda_KeyDown);
            this.txtidvenda.Leave += new System.EventHandler(this.txtidvenda_Leave);
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(591, 10);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(75, 23);
            this.btnnew.TabIndex = 2;
            this.btnnew.Text = "Nova Venda";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnSalv);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.descCliente);
            this.panel2.Controls.Add(this.txtTotal);
            this.panel2.Controls.Add(this.btnexcluiitem);
            this.panel2.Controls.Add(this.btnedit);
            this.panel2.Controls.Add(this.btnadd);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.datevenda);
            this.panel2.Controls.Add(this.txtCliente);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(12, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 379);
            this.panel2.TabIndex = 3;
            this.panel2.EnabledChanged += new System.EventHandler(this.panel2_EnabledChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(21, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(549, 191);
            this.dataGridView1.TabIndex = 62;
            // 
            // bindingSource1
            // 
            this.bindingSource1.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bindingSource1_ListChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 36);
            this.button1.TabIndex = 61;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnSalv
            // 
            this.btnSalv.Location = new System.Drawing.Point(580, 12);
            this.btnSalv.Name = "btnSalv";
            this.btnSalv.Size = new System.Drawing.Size(86, 86);
            this.btnSalv.TabIndex = 3;
            this.btnSalv.Text = "Salvar";
            this.btnSalv.UseVisualStyleBackColor = true;
            this.btnSalv.Click += new System.EventHandler(this.btnSalv_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Total";
            // 
            // descCliente
            // 
            this.descCliente.BackColor = System.Drawing.SystemColors.Info;
            this.descCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descCliente.Location = new System.Drawing.Point(380, 14);
            this.descCliente.Name = "descCliente";
            this.descCliente.Size = new System.Drawing.Size(194, 20);
            this.descCliente.TabIndex = 50;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.Info;
            this.txtTotal.Location = new System.Drawing.Point(470, 247);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 58;
            this.txtTotal.TabStop = false;
            // 
            // btnexcluiitem
            // 
            this.btnexcluiitem.Location = new System.Drawing.Point(183, 244);
            this.btnexcluiitem.Name = "btnexcluiitem";
            this.btnexcluiitem.Size = new System.Drawing.Size(75, 23);
            this.btnexcluiitem.TabIndex = 56;
            this.btnexcluiitem.Text = "- Excluir";
            this.btnexcluiitem.UseVisualStyleBackColor = true;
            this.btnexcluiitem.Click += new System.EventHandler(this.btnexcluiitem_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(102, 244);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 55;
            this.btnedit.Text = "! Editar";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(21, 244);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "+ Adicionar";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnCancelEdit);
            this.panel3.Controls.Add(this.btnAdicEdit);
            this.panel3.Controls.Add(this.txtPreco);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtQtde);
            this.panel3.Controls.Add(this.DescProd);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtCodProd);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(21, 273);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(553, 87);
            this.panel3.TabIndex = 57;
            this.panel3.Visible = false;
            this.panel3.VisibleChanged += new System.EventHandler(this.panel3_VisibleChanged);
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.Location = new System.Drawing.Point(483, 42);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(63, 23);
            this.btnCancelEdit.TabIndex = 53;
            this.btnCancelEdit.TabStop = false;
            this.btnCancelEdit.Text = "Cancelar";
            this.btnCancelEdit.UseVisualStyleBackColor = true;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // btnAdicEdit
            // 
            this.btnAdicEdit.Location = new System.Drawing.Point(324, 42);
            this.btnAdicEdit.Name = "btnAdicEdit";
            this.btnAdicEdit.Size = new System.Drawing.Size(153, 23);
            this.btnAdicEdit.TabIndex = 4;
            this.btnAdicEdit.Text = "Adicionar/Alterar";
            this.btnAdicEdit.UseVisualStyleBackColor = true;
            this.btnAdicEdit.Click += new System.EventHandler(this.btnAdicEdit_Click);
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(218, 43);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Preço";
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(71, 43);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(100, 20);
            this.txtQtde.TabIndex = 2;
            // 
            // DescProd
            // 
            this.DescProd.BackColor = System.Drawing.SystemColors.Info;
            this.DescProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescProd.Location = new System.Drawing.Point(174, 17);
            this.DescProd.Name = "DescProd";
            this.DescProd.Size = new System.Drawing.Size(372, 20);
            this.DescProd.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Quantidade";
            // 
            // txtCodProd
            // 
            this.txtCodProd.BackColor = System.Drawing.Color.White;
            this.txtCodProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCodProd.Location = new System.Drawing.Point(71, 17);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(100, 20);
            this.txtCodProd.TabIndex = 1;
            this.txtCodProd.Tag = "";
            this.txtCodProd.TextChanged += new System.EventHandler(this.txtidvenda_TextChanged);
            this.txtCodProd.DoubleClick += new System.EventHandler(this.txtCodProd_DoubleClick);
            this.txtCodProd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodProd_KeyDown);
            this.txtCodProd.Leave += new System.EventHandler(this.txtCodProd_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Cód.Prod";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Data/Hora";
            // 
            // datevenda
            // 
            this.datevenda.CustomFormat = "dd/MM/yyyy H:mm:ss";
            this.datevenda.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datevenda.Location = new System.Drawing.Point(80, 12);
            this.datevenda.Name = "datevenda";
            this.datevenda.Size = new System.Drawing.Size(143, 20);
            this.datevenda.TabIndex = 0;
            this.datevenda.Value = new System.DateTime(2014, 3, 1, 14, 31, 1, 0);
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.White;
            this.txtCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCliente.Location = new System.Drawing.Point(279, 14);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCliente.TabIndex = 1;
            this.txtCliente.Tag = "";
            this.txtCliente.TextChanged += new System.EventHandler(this.txtidvenda_TextChanged);
            this.txtCliente.DoubleClick += new System.EventHandler(this.txtCliente_DoubleClick);
            this.txtCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCliente_KeyDown);
            this.txtCliente.Leave += new System.EventHandler(this.txtCliente_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(146, 456);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dica:Os campos que aparecem o icone:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(377, 456);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(311, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "podem ser consultados clicando sobre eles 2x, ou apertando F2.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(344, 446);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 31);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 478);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormVendas";
            this.Text = "Vendas ";
            this.Load += new System.EventHandler(this.FormVendas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datevenda;
        private System.Windows.Forms.Label descCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnexcluiitem;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Button btnAdicEdit;
        private txtNumerico.TxtNumerico txtPreco;
        private System.Windows.Forms.Label label5;
        private txtNumerico.TxtNumerico txtQtde;
        private System.Windows.Forms.Label DescProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodProd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSalv;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox txtidvenda;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}