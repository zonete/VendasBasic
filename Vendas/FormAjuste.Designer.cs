namespace Vendas
{
    partial class FormAjuste
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtidajuste = new System.Windows.Forms.MaskedTextBox();
            this.btnnew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.DateNf = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtQtde = new txtNumerico.TxtNumerico();
            this.descProd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodPrd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtidajuste);
            this.panel1.Controls.Add(this.btnnew);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 44);
            this.panel1.TabIndex = 0;
            // 
            // txtidajuste
            // 
            this.txtidajuste.BackColor = System.Drawing.Color.White;
            this.txtidajuste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtidajuste.Location = new System.Drawing.Point(96, 12);
            this.txtidajuste.Name = "txtidajuste";
            this.txtidajuste.Size = new System.Drawing.Size(135, 20);
            this.txtidajuste.TabIndex = 3;
            this.txtidajuste.Tag = "";
            this.txtidajuste.Leave += new System.EventHandler(this.txtidajuste_Leave);
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(327, 10);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(75, 23);
            this.btnnew.TabIndex = 5;
            this.btnnew.Text = "Novo Ajuste";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código Ajuste";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.DateNf);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnSalva);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.txtQtde);
            this.panel2.Controls.Add(this.descProd);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtCodPrd);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(12, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 173);
            this.panel2.TabIndex = 1;
            this.panel2.EnabledChanged += new System.EventHandler(this.panel2_VisibleChanged);
            this.panel2.VisibleChanged += new System.EventHandler(this.panel2_VisibleChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 60;
            this.button1.TabStop = false;
            this.button1.Text = "Deletar Ajuste";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DateNf
            // 
            this.DateNf.CustomFormat = "d/MM/yyyy HH:mm";
            this.DateNf.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateNf.Location = new System.Drawing.Point(79, 58);
            this.DateNf.Name = "DateNf";
            this.DateNf.Size = new System.Drawing.Size(152, 20);
            this.DateNf.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "Data/Hora ";
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(327, 37);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(75, 66);
            this.btnSalva.TabIndex = 56;
            this.btnSalva.Text = "Salvar";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(326, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 57;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Tipo";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "(+)Entrada ",
            "(-)Saída     "});
            this.comboBox1.Location = new System.Drawing.Point(79, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 54;
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(79, 83);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(100, 20);
            this.txtQtde.TabIndex = 50;
            // 
            // descProd
            // 
            this.descProd.BackColor = System.Drawing.SystemColors.Info;
            this.descProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descProd.Location = new System.Drawing.Point(79, 31);
            this.descProd.Name = "descProd";
            this.descProd.Size = new System.Drawing.Size(228, 20);
            this.descProd.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Quantidade";
            // 
            // txtCodPrd
            // 
            this.txtCodPrd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCodPrd.Location = new System.Drawing.Point(79, 8);
            this.txtCodPrd.Name = "txtCodPrd";
            this.txtCodPrd.Size = new System.Drawing.Size(100, 20);
            this.txtCodPrd.TabIndex = 49;
            this.txtCodPrd.TextChanged += new System.EventHandler(this.txtCodPrd_TextChanged);
            this.txtCodPrd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodPrd_KeyDown);
            this.txtCodPrd.Leave += new System.EventHandler(this.txtCodPrd_Leave);
            this.txtCodPrd.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtCodPrd_MouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Cód.Prod";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // FormAjuste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 247);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormAjuste";
            this.Text = "Ajustes de Saldos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox txtidajuste;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private txtNumerico.TxtNumerico txtQtde;
        private System.Windows.Forms.Label descProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodPrd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker DateNf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}