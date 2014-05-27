using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Vendas.BD;

namespace Vendas
{
    public partial class FormCadProd : Form
    {
        DataTable dt = new DataTable();
        
        public FormCadProd()
        {
            InitializeComponent();
            dt.Columns.Add("idprod");
            dt.Columns.Add("descricao");
            dt.Columns.Add("data_cad");
            dt.Columns.Add("data_ult_comp");
            dt.Columns.Add("saldo");
            dt.Columns.Add("fabricante");
            dt.Columns.Add("unidade");
            dt.Columns.Add("preco_compra");
            dt.Columns.Add("preco_venda");
            dt.Columns.Add("estoque_min");

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        public void Carrega()
        {
            Produto objProduto = new Produto();
            dt.Clear();
            DataRow r;
            foreach (var prod in objProduto.Listar())
            {
                r = dt.NewRow();
                r["idprod"] = prod.idprod;
                r["descricao"] = prod.descricao;
                r["data_cad"] = prod.data_cad;
                r["data_ult_comp"] = prod.data_ult;
                r["saldo"] = prod.saldo;
                r["fabricante"] = prod.fabricante;
                r["unidade"] = prod.unidade;
                r["preco_compra"] = prod.preco_compra;
                r["preco_venda"] = prod.preco_venda;
                r["estoque_min"] = prod.estoque_min;
                dt.Rows.Add(r);
            }
            dataGridView1.DataSource = dt;

        }

        public void CarregaPanel()
        {
            panel1.Left = 0;
            panel1.Top = 0;
            panel1.Visible = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpaCampo();
            txtDesc.Focus();
            dataCad.Value = DateTime.Today;
            dataComp.Value = DateTime.Today;
            lblindicador.Text = "+ Inserção";
            lblindicador.BackColor = Color.Chartreuse;
            lblindicador.Visible = true;
            CarregaPanel();

        }

        

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            limpaCampo();
            lblindicador.Text = "~ Alteração";
            lblindicador.BackColor = Color.CornflowerBlue;
            lblindicador.Visible = true;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow r = dataGridView1.CurrentRow;
                    Produto objProduto = new Produto();
                    objProduto.idprod = Convert.ToInt16(r.Cells["idprod"].Value.ToString());
                    objProduto.CarregaID();
                    txtCodigo.Text = Convert.ToString(objProduto.idprod);
                    dataComp.Value = objProduto.data_ult;
                    dataCad.Value = objProduto.data_cad;
                    txtCompra.Text = objProduto.preco_compra.ToString("#####0.00");
                    txtDesc.Text = objProduto.descricao;
                    txtEstoq.Text = objProduto.estoque_min.ToString("#####0.00");
                    txtFabr.Text = objProduto.fabricante;
                    txtSaldo.Text = objProduto.saldo.ToString("#####0.00");
                    txtVenda.Text = objProduto.preco_venda.ToString("#####0.00");
                    TxtUnidade.Text = objProduto.unidade;

                    
                }
                catch (Exception erros)
                {
                    erro(erros.Message);
                }


            }
            CarregaPanel();
        }

        
        private void FormCadProd_Load(object sender, EventArgs e)
        {
            Carrega();
            panel1.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void limpaCampo()
        {
            txtCodigo.Clear();
            txtCompra.Clear();
            txtDesc.Clear();
            txtEstoq.Clear();
            txtFabr.Clear();
            txtSaldo.Clear();
            txtVenda.Clear();
            TxtUnidade.Clear();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ConsisteGeral())
            {
                Produto objProduto = new Produto();
                objProduto.data_cad = dataCad.Value;
                objProduto.data_ult = dataComp.Value;
                objProduto.descricao = txtDesc.Text;
                objProduto.estoque_min = Convert.ToDecimal(txtEstoq.Text);
                objProduto.fabricante = txtFabr.Text;
                objProduto.preco_compra = Convert.ToDecimal(txtCompra.Text);
                objProduto.preco_venda = Convert.ToDecimal(txtVenda.Text);
                objProduto.saldo = Convert.ToDecimal(txtSaldo.Text);
                objProduto.unidade = TxtUnidade.Text;

                if (txtCodigo.TextLength > 0)
                {
                    //alteracao
                    objProduto.idprod = Convert.ToInt16(txtCodigo.Text);
                    objProduto.Alterar();
                    MessageBox.Show("Alterado com Sucesso!", "sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panel1.Visible = false;
                    Carrega();
                }
                else
                {
                    //inclusao
                    try
                    {
                        objProduto.Inserir();
                        MessageBox.Show("Inserido com Sucesso!", "sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        panel1.Visible = false;
                        Carrega();
                    }
                    catch (Exception erros)
                    {
                        erro(erros.Message);

                    }
                }
            }
        }

        public void erro(String erro)
        {
            MessageBox.Show(erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private bool ConsisteGeral()
        {
            if (txtDesc.TextLength  == 0)
            {
                erro("É necessário Preencher Descrição!");
                txtDesc.Focus();
                return false;
            }
            if (txtFabr.TextLength == 0)
            {
                erro("É necessário Preencher Fabricante!");
                txtFabr.Focus();
                return false;
            }
            try
            {
                Convert.ToDecimal(txtSaldo.Text);
            }
            catch (Exception)
            {
                erro("Preencher Saldo!");
                txtSaldo.Focus();
                return false;
            }
            try
            {
                Convert.ToDecimal(txtEstoq.Text);
            }
            catch (Exception)
            {
                erro("Preencher Estoq min!");
                txtEstoq.Focus();
                return false;
            }
            try
            {
                Convert.ToDecimal(txtVenda.Text);
            }
            catch (Exception)
            {
                erro("Preencher Preço de Venda!");
                txtVenda.Focus();
                return false;
            }
            try
            {
                Convert.ToDecimal(txtCompra.Text);
            }
            catch (Exception)
            {
                erro("Preencher Preço Compra!");
                txtCompra.Focus();
                return false;
            }

            if (TxtUnidade.TextLength == 0)
            {
                erro("Preencher Unidade");
                TxtUnidade.Focus();
                return false;
            }
            return true;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    Produto objProduto = new Produto();
                    objProduto.idprod = Convert.ToInt16(((DataGridViewRow) dataGridView1.CurrentRow).Cells["idprod"].Value.ToString());
                    objProduto.CarregaID();
                    if (
                        MessageBox.Show("Deseja excluir produto:" + objProduto.descricao + " ??", "Confirmação",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        objProduto.Remover();
                        Carrega();
                    }
                }
                catch (Exception exception)
                {
                    
                    erro(exception.Message);
                }
            }
        }

        private void txtPesq_TextChanged(object sender, EventArgs e)
        {

            if ((txtPesq.TextLength > 0) && (Opcoes.SelectedIndex >= 0))
            {
                switch (Opcoes.SelectedIndex)
                {
                    case 0:
                        ((DataTable) dataGridView1.DataSource).DefaultView.RowFilter =
                            string.Format(" descricao like '%{0}%'", txtPesq.Text.ToUpper().Trim().Replace("'", "''"));
                        break;
                    case 1:
                        ((DataTable) dataGridView1.DataSource).DefaultView.RowFilter = string.Format(
                            " idprod = '{0}' ", txtPesq.Text.ToUpper().Replace("'", "''").Trim());
                        break;
                    case 2:
                        ((DataTable) dataGridView1.DataSource).DefaultView.RowFilter =
                            string.Format(" fabricante like '%{0}%'", txtPesq.Text.ToUpper().Trim().Replace("'", "''"));
                        break;
                    default:
                        break;
                }

            }
            else
            {
                ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = "";
            }
        }
    }
}
