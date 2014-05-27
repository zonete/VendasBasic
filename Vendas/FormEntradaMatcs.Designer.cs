namespace Vendas
{
    partial class FormEntradaMatcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEntradaMatcs));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnexcluiitem = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.btnAdicEdit = new System.Windows.Forms.Button();
            this.txtPreco = new txtNumerico.TxtNumerico();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQtde = new txtNumerico.TxtNumerico();
            this.descProd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodPrd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DateNf = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.lblindicador = new System.Windows.Forms.Label();
            this.btnSalva = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNF = new System.Windows.Forms.TextBox();
            this.Opcoes = new System.Windows.Forms.ComboBox();
            this.txtPesq = new System.Windows.Forms.TextBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.identrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.identrada2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idprod2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descprod2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtde2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(59, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 460);
            this.panel1.TabIndex = 23;
            this.panel1.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(246, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(311, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "podem ser consultados clicando sobre eles 2x, ou apertando F2.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(15, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Dica:Os campos que aparecem o icone:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.btnexcluiitem);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.DateNf);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblindicador);
            this.panel2.Controls.Add(this.btnSalva);
            this.panel2.Controls.Add(this.txtCodigo);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtNF);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 348);
            this.panel2.TabIndex = 31;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.DataSource = this.bindingSource1;
            this.dataGridView3.Location = new System.Drawing.Point(68, 42);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(429, 150);
            this.dataGridView3.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Total";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(397, 198);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 48;
            this.textBox1.TabStop = false;
            // 
            // btnexcluiitem
            // 
            this.btnexcluiitem.Location = new System.Drawing.Point(233, 198);
            this.btnexcluiitem.Name = "btnexcluiitem";
            this.btnexcluiitem.Size = new System.Drawing.Size(75, 23);
            this.btnexcluiitem.TabIndex = 4;
            this.btnexcluiitem.Text = "- Excluir";
            this.btnexcluiitem.UseVisualStyleBackColor = true;
            this.btnexcluiitem.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(152, 198);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "! Editar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(71, 198);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "+ Adicionar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnCancelEdit);
            this.panel3.Controls.Add(this.btnAdicEdit);
            this.panel3.Controls.Add(this.txtPreco);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtQtde);
            this.panel3.Controls.Add(this.descProd);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtCodPrd);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(71, 227);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(426, 101);
            this.panel3.TabIndex = 47;
            this.panel3.Visible = false;
            this.panel3.VisibleChanged += new System.EventHandler(this.panel3_VisibleChanged);
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.Location = new System.Drawing.Point(345, 70);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(63, 23);
            this.btnCancelEdit.TabIndex = 53;
            this.btnCancelEdit.TabStop = false;
            this.btnCancelEdit.Text = "Cancelar";
            this.btnCancelEdit.UseVisualStyleBackColor = true;
            this.btnCancelEdit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdicEdit
            // 
            this.btnAdicEdit.Location = new System.Drawing.Point(192, 70);
            this.btnAdicEdit.Name = "btnAdicEdit";
            this.btnAdicEdit.Size = new System.Drawing.Size(147, 23);
            this.btnAdicEdit.TabIndex = 3;
            this.btnAdicEdit.Text = "Adicionar/Alterar";
            this.btnAdicEdit.UseVisualStyleBackColor = true;
            this.btnAdicEdit.Click += new System.EventHandler(this.btnAdicEdit_Click);
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(253, 40);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Preço";
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(78, 40);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(100, 20);
            this.txtQtde.TabIndex = 1;
            // 
            // descProd
            // 
            this.descProd.BackColor = System.Drawing.SystemColors.Info;
            this.descProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descProd.Location = new System.Drawing.Point(179, 15);
            this.descProd.Name = "descProd";
            this.descProd.Size = new System.Drawing.Size(228, 20);
            this.descProd.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Quantidade";
            // 
            // txtCodPrd
            // 
            this.txtCodPrd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCodPrd.Location = new System.Drawing.Point(78, 15);
            this.txtCodPrd.Name = "txtCodPrd";
            this.txtCodPrd.Size = new System.Drawing.Size(100, 20);
            this.txtCodPrd.TabIndex = 0;
            this.txtCodPrd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtCodPrd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodPrd_KeyDown);
            this.txtCodPrd.Leave += new System.EventHandler(this.txtCodPrd_Leave);
            this.txtCodPrd.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtCodPrd_MouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Cód.Prod";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // DateNf
            // 
            this.DateNf.CustomFormat = "d/MM/yyyy HH:mm";
            this.DateNf.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateNf.Location = new System.Drawing.Point(394, 16);
            this.DateNf.Name = "DateNf";
            this.DateNf.Size = new System.Drawing.Size(152, 20);
            this.DateNf.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Data NF";
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
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(521, 85);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(75, 66);
            this.btnSalva.TabIndex = 5;
            this.btnSalva.Text = "Salvar";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(112, 16);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(70, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(521, 56);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "NF";
            // 
            // txtNF
            // 
            this.txtNF.Location = new System.Drawing.Point(229, 16);
            this.txtNF.Name = "txtNF";
            this.txtNF.Size = new System.Drawing.Size(100, 20);
            this.txtNF.TabIndex = 0;
            // 
            // Opcoes
            // 
            this.Opcoes.FormattingEnabled = true;
            this.Opcoes.Items.AddRange(new object[] {
            "NF",
            "ID"});
            this.Opcoes.Location = new System.Drawing.Point(13, 10);
            this.Opcoes.Name = "Opcoes";
            this.Opcoes.Size = new System.Drawing.Size(203, 21);
            this.Opcoes.TabIndex = 18;
            this.Opcoes.SelectedIndexChanged += new System.EventHandler(this.Opcoes_SelectedIndexChanged);
            // 
            // txtPesq
            // 
            this.txtPesq.Location = new System.Drawing.Point(222, 11);
            this.txtPesq.Name = "txtPesq";
            this.txtPesq.Size = new System.Drawing.Size(457, 20);
            this.txtPesq.TabIndex = 19;
            this.txtPesq.TextChanged += new System.EventHandler(this.txtPesq_TextChanged);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(177, 418);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 22;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(96, 418);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 21;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(15, 418);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 20;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identrada,
            this.nf,
            this.data});
            this.dataGridView1.Location = new System.Drawing.Point(13, 37);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(666, 126);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.DataMemberChanged += new System.EventHandler(this.dataGridView1_DataMemberChanged);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.CursorChanged += new System.EventHandler(this.dataGridView1_CursorChanged);
            // 
            // identrada
            // 
            this.identrada.DataPropertyName = "identrada";
            this.identrada.HeaderText = "ID";
            this.identrada.Name = "identrada";
            this.identrada.ReadOnly = true;
            // 
            // nf
            // 
            this.nf.DataPropertyName = "nf";
            this.nf.HeaderText = "NF";
            this.nf.Name = "nf";
            this.nf.ReadOnly = true;
            // 
            // data
            // 
            this.data.DataPropertyName = "data";
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identrada2,
            this.idprod2,
            this.descprod2,
            this.preco2,
            this.qtde2});
            this.dataGridView2.Location = new System.Drawing.Point(15, 188);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(666, 208);
            this.dataGridView2.TabIndex = 24;
            // 
            // identrada2
            // 
            this.identrada2.DataPropertyName = "identrada2";
            this.identrada2.HeaderText = "id";
            this.identrada2.Name = "identrada2";
            this.identrada2.ReadOnly = true;
            this.identrada2.Visible = false;
            // 
            // idprod2
            // 
            this.idprod2.DataPropertyName = "idprod2";
            this.idprod2.HeaderText = "CódigoProd";
            this.idprod2.Name = "idprod2";
            this.idprod2.ReadOnly = true;
            // 
            // descprod2
            // 
            this.descprod2.DataPropertyName = "descprod2";
            this.descprod2.HeaderText = "Produto";
            this.descprod2.Name = "descprod2";
            this.descprod2.ReadOnly = true;
            // 
            // preco2
            // 
            this.preco2.DataPropertyName = "preco2";
            this.preco2.HeaderText = "Preço";
            this.preco2.Name = "preco2";
            this.preco2.ReadOnly = true;
            // 
            // qtde2
            // 
            this.qtde2.DataPropertyName = "qtde2";
            this.qtde2.HeaderText = "Quantidade";
            this.qtde2.Name = "qtde2";
            this.qtde2.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(213, 364);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 31);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // FormEntradaMatcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 453);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Opcoes);
            this.Controls.Add(this.txtPesq);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "FormEntradaMatcs";
            this.Text = "Entrada NF";
            this.Load += new System.EventHandler(this.FormEntradaMatcs_Load);
            this.Shown += new System.EventHandler(this.FormEntradaMatcs_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodPrd;
        private System.Windows.Forms.DateTimePicker DateNf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblindicador;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNF;
        private System.Windows.Forms.ComboBox Opcoes;
        private System.Windows.Forms.TextBox txtPesq;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label descProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnexcluiitem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAdicEdit;
        private txtNumerico.TxtNumerico txtPreco;
        private System.Windows.Forms.Label label5;
        private txtNumerico.TxtNumerico txtQtde;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn identrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn nf;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn identrada2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprod2;
        private System.Windows.Forms.DataGridViewTextBoxColumn descprod2;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco2;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtde2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}