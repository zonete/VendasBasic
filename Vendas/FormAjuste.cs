using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vendas.BD;

namespace Vendas
{
    public partial class FormAjuste : Form
    {
        public FormAjuste()
        {
            InitializeComponent();
        }

        private void txtCodPrd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                FormConsulta fr = new FormConsulta();
                fr.CarregaProduto();
                if (fr.vg_codigo != "")
                {
                    txtCodPrd.Text = fr.vg_codigo;
                    descProd.Text = fr.vg_descricao;
                    txtQtde.Focus();
                }
            }
        }

        private void txtCodPrd_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FormConsulta fr = new FormConsulta();
            fr.CarregaProduto();
            if (fr.vg_codigo != "")
            {
                txtCodPrd.Text = fr.vg_codigo;
                descProd.Text = fr.vg_descricao;
                txtQtde.Focus();
            }
        }
        public void erro(String erro)
        {
            MessageBox.Show(erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void txtCodPrd_Leave(object sender, EventArgs e)
        {
            if ((txtCodPrd.TextLength > 0) && (descProd.Text.Equals("")))
            {
                Produto pr = new Produto();
                pr.idprod = Convert.ToInt16(txtCodPrd.Text);
                pr.ListarID();
                if (pr.descricao != null)
                {
                    descProd.Text = pr.descricao;
                }
                else
                {
                    erro("Produto não cadastrado");
                    txtCodPrd.Text = "";
                    txtCodPrd.Focus();
                }

            }
        }

        private void panel2_VisibleChanged(object sender, EventArgs e)
        {
            panel1.Enabled = !panel2.Enabled;
            button1.Visible = ((panel2.Enabled) && (txtidajuste.TextLength > 0));
        }

        public void limpaDados()
        {
            txtCodPrd.Enabled = true;
            comboBox1.Enabled = true;
            DateNf.Enabled = true;
            txtCodPrd.Clear();
            txtQtde.Clear();
            descProd.Text = "";
            comboBox1.SelectedIndex = -1;

        }
        private void btnnew_Click(object sender, EventArgs e)
        {
            txtidajuste.Clear();
            limpaDados();
            panel2.Enabled = true;
            DateNf.Value = DateTime.Now;
            txtCodPrd.Focus();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCodPrd_TextChanged(object sender, EventArgs e)
        {

        }

        public bool Consiste()
        {
            if (txtCodPrd.TextLength == 0)
            {
                erro("informar Produto");
                txtCodPrd.Focus();
                return false;
            }
            if (txtQtde.TextLength == 0)
            {
                erro("informar Qtd");
                txtQtde.Focus();
                return false;
            }
            try
            {
                Convert.ToDecimal(txtQtde.Text);
            }
            catch (Exception)
            {
                erro("numero invalido");
                txtQtde.Focus();
                return false;
            }
            if ((comboBox1.SelectedIndex != 1) && (comboBox1.SelectedIndex != 2))
            {
                erro("selecionar um tipo");
                comboBox1.Focus();
                return false;
            }
            return true;
        }
        private void btnSalva_Click(object sender, EventArgs e)
        {

            if (Consiste())
            {
                if (txtidajuste.TextLength == 0)
                {
                    //isert
                    Ajuste objAjuste = new Ajuste
                    {
                        data = DateNf.Value,
                        prod = new Produto {idprod = Convert.ToInt16(txtCodPrd.Text)},
                        quantidade = Convert.ToDecimal(txtQtde.Text),
                        tipo = comboBox1.SelectedIndex
                    };
                    objAjuste.Insere();
                    MessageBox.Show("Saldo Acertado com Sucesso!");

                }
                else
                {
                    //alt
                    Ajuste objAjuste = new Ajuste
                    {
                        idajuste = Convert.ToInt16(txtidajuste.Text),
                        data = DateNf.Value,
                        prod = new Produto { idprod = Convert.ToInt16(txtCodPrd.Text) },
                        quantidade = Convert.ToDecimal(txtQtde.Text),
                        tipo = comboBox1.SelectedIndex
                    };
                    objAjuste.Alterar();

                    MessageBox.Show("Saldo Acertado com Sucesso!");
                }
                limpaDados();
                txtidajuste.Clear();
                panel2.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Consiste())
            {
                Ajuste objAjuste = new Ajuste
                {
                    idajuste = Convert.ToInt16(txtidajuste.Text),
                    data = DateNf.Value,
                    prod = new Produto {idprod = Convert.ToInt16(txtCodPrd.Text)},
                    quantidade = Convert.ToDecimal(txtQtde.Text),
                    tipo = comboBox1.SelectedIndex
                };
                objAjuste.Deletar();
                MessageBox.Show("Deletado com Sucesso!");
            }
            panel2.Enabled = false;
            txtidajuste.Clear();
            limpaDados();
        }

        private void txtidajuste_Leave(object sender, EventArgs e)
        {
            if (txtidajuste.TextLength > 0)
            {
                Ajuste objAjuste = new Ajuste();
                objAjuste.idajuste = Convert.ToInt16(txtidajuste.Text);
                objAjuste.CarregaID();
                if (objAjuste.idajuste > 0)
                {
                    txtCodPrd.Text = objAjuste.prod.idprod.ToString();
                    descProd.Text = objAjuste.prod.descricao;
                    DateNf.Value = objAjuste.data;
                    txtQtde.Text = objAjuste.quantidade.ToString();
                    comboBox1.SelectedIndex = objAjuste.tipo;
                    txtCodPrd.Enabled = false;
                    comboBox1.Enabled = false;
                    DateNf.Enabled = false;
                    panel2.Enabled = true;
                }
                else
                {
                    erro("não encontrado ajuste");
                    txtidajuste.Focus();
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaDados();
            txtidajuste.Clear();

            panel2.Enabled = false;
        }
    }
}
