using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vendas.BD;

namespace Vendas
{
    public partial class FormEntradaMatcs : Form
    {
        private List<itensGrid> ListaItens = new List<itensGrid>();
        private DataTable dtEntrada = new DataTable();
        private DataTable dtItens = new DataTable();

        public FormEntradaMatcs()
        {
            InitializeComponent();
            ListaItens.Clear();
            bindingSource1.DataSource = ListaItens;
            dataGridView3.AutoGenerateColumns = true;
            /*dataGridView3.Columns.Add("idprod", "Cód.Produto");
            dataGridView3.Columns.Add("descprod", "Produto");
            dataGridView3.Columns.Add("preco", "Preço");
            dataGridView3.Columns.Add("quantidade", "Qtde");*/
            foreach (DataGridViewColumn col in dataGridView3.Columns)
            {
                if (col.Name.ToUpper().Equals("PADRAO"))
                {
                    col.Visible = false;
                }

            }

            dtEntrada.Columns.Add("identrada");
            dtEntrada.Columns.Add("nf");
            dtEntrada.Columns.Add("data");

            dtItens.Columns.Add("identrada2");
            dtItens.Columns.Add("idprod2");
            dtItens.Columns.Add("descprod2");
            dtItens.Columns.Add("qtde2");
            dtItens.Columns.Add("preco2");


        }

        public void carregar()
        {
            ItemEntadaMat objItemEntadaMat = new ItemEntadaMat();
            dtEntrada.Clear();
            dtItens.Clear();
            DataRow r;
            foreach (var itens in objItemEntadaMat.Retornar())
            {
                if (dtEntrada.Select("identrada = " + itens.identrada.ToString()).Count() == 0)
                {
                    r = dtEntrada.NewRow();
                    r["identrada"] = itens.identrada;
                    r["nf"] = itens.nf;
                    r["data"] = itens.data;
                    dtEntrada.Rows.Add(r);
                }
                r = dtItens.NewRow();
                r["identrada2"] = itens.identrada;
                r["idprod2"] = itens.prod.idprod;
                r["descprod2"] = itens.prod.descricao;
                r["qtde2"] = itens.qtde;
                r["preco2"] = itens.preco;
                dtItens.Rows.Add(r);
            }

            dataGridView2.DataSource = dtItens;
            dataGridView1.DataSource = dtEntrada;
            if(dataGridView1.CurrentRow != null)
            ((DataTable) dataGridView2.DataSource).DefaultView.RowFilter = " identrada2 = " +
                                                                           dataGridView1.CurrentRow.Cells["identrada"]
                                                                               .Value.ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            descProd.Text = "";
        }

        private void panel3_VisibleChanged(object sender, EventArgs e)
        {
            txtCodigo.Enabled = !panel3.Visible;
            txtNF.Enabled = !panel3.Visible;
            DateNf.Enabled = ((!panel3.Visible) && (lblindicador.BackColor != Color.Chartreuse));
            btnCancelar.Enabled = !panel3.Visible;
            btnSalva.Enabled = !panel3.Visible;
            dataGridView3.Enabled = !panel3.Visible;

        }

        public void limpaDados()
        {
            txtNF.Clear();
            txtCodigo.Clear();
            DateNf.Value = DateTime.Today;
            ListaItens.Clear();
            LimpaItens();
        }

        public void LimpaItens()
        {
            txtCodPrd.Clear();
            descProd.Text = "";
            txtQtde.Clear();
            txtPreco.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpaItens();
            panel3.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {

            panel3.Visible = true;
            txtCodPrd.Enabled = true;
            txtCodPrd.Focus();
            btnAdicEdit.Text = "Inserir";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtCodPrd.Text = ((itensGrid) bindingSource1.Current).idprod.ToString();
            descProd.Text = ((itensGrid) bindingSource1.Current).descprod.ToString();
            txtPreco.Text = ((itensGrid) bindingSource1.Current).preco.ToString();
            txtQtde.Text = ((itensGrid) bindingSource1.Current).quantidade.ToString();
            panel3.Visible = true;
            txtCodPrd.Enabled = false;
            btnAdicEdit.Text = "Alterar";
        }

        public void erro(String erro)
        {
            MessageBox.Show(erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnAdicEdit_Click(object sender, EventArgs e)
        {
            if (ConsisteItens())
            {
                if (btnAdicEdit.Text.Equals("Inserir"))
                {
                    var query = from cl in ListaItens
                        where cl.idprod == Convert.ToInt16(txtCodPrd.Text)
                        select cl;
                    if (query.Any())
                    {
                        erro("Já existe o produto na lista! não é permitido duplicidade");
                        return;
                    }
                    bindingSource1.Add(new itensGrid()
                    {
                        preco = Convert.ToDecimal(txtPreco.Text),
                        idprod = Convert.ToInt16(txtCodPrd.Text),
                        quantidade = Convert.ToDecimal(txtQtde.Text),
                        descprod = descProd.Text,
                        padrao = "I"
                    });
                }
                else
                {
                    ((itensGrid) bindingSource1.Current).preco = Convert.ToDecimal(txtPreco.Text);
                    ((itensGrid) bindingSource1.Current).quantidade = Convert.ToDecimal(txtQtde.Text);
                    if (!((itensGrid) bindingSource1.Current).padrao.ToUpper().Equals("I"))
                    {
                        ((itensGrid) bindingSource1.Current).padrao = "A";
                    }
                }
                panel3.Visible = false;
                CalculaTotal();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void FormEntradaMatcs_Shown(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn col in dataGridView3.Columns)
            {
                if (col.Name.ToUpper().Equals("PADRAO"))
                {
                    col.Visible = true;
                }

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Current != null)
            {
                if (((itensGrid) bindingSource1.Current).padrao.ToUpper().Equals("I"))
                {
                    bindingSource1.Remove(bindingSource1.Current);
                }
                else if (((itensGrid) bindingSource1.Current).padrao.ToUpper().Equals("D"))
                {
                    ((itensGrid) bindingSource1.Current).padrao = "A";
                    btnexcluiitem.Text = "- Excluir";
                }
                else
                {
                    ((itensGrid) bindingSource1.Current).padrao = "D";
                    btnexcluiitem.Text = "<- Desfazer";
                }
            }

        }

        private void dataGridView3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (ListaItens.Count > 0)
            {

                if ((e.ColumnIndex == 0) && ((itensGrid) bindingSource1[e.RowIndex]).padrao.ToUpper().Equals("D"))
                {
                    dataGridView3.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;

                }
                else if (e.ColumnIndex == 0)
                {
                    dataGridView3.Rows[e.RowIndex].DefaultCellStyle.BackColor = dataGridView1.DefaultCellStyle.BackColor;
                }
            }

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            if(bindingSource1.Current != null){
            if (((itensGrid) bindingSource1.Current).padrao.Equals("D"))
            {
                btnexcluiitem.Text = "<- Desfazer Exclusão";
            }
            else
            {
                btnexcluiitem.Text = "! Excluir";
            }
}
        }

        public bool ConsisteGeral()
        {
            if (txtNF.TextLength == 0)
            {
                erro("informe NF");
                return false;
            }
            if (DateNf.Value == null)
            {
                erro("informe data");
                return false;
            }

            return true;
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConsisteGeral())
                {
                    EntradaMat objEntadaMat = new EntradaMat();
                    objEntadaMat.nf = txtNF.Text;
                    objEntadaMat.data = DateNf.Value;
                    if (txtCodigo.TextLength == 0)
                    {
                        objEntadaMat.Insere();
                        ItemEntadaMat objitem;
                        foreach (itensGrid itens in bindingSource1.List)
                        {
                            objitem = new ItemEntadaMat
                            {
                                prod = new Produto {idprod = itens.idprod},
                                identrada = objEntadaMat.identrada,
                                preco = itens.preco,
                                qtde = itens.quantidade,
                                data = objEntadaMat.data
                            };
                            objitem.InsereItem();
                        }
                        MessageBox.Show("Entrada de Materiais  Realizada com sucesso!", "Sucesso", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    }
                    else
                    {
                        //alteracao
                        objEntadaMat.identrada = Convert.ToInt16(txtCodigo.Text);
                        objEntadaMat.Alterar();
                        ItemEntadaMat objitem;
                        foreach (itensGrid itens in bindingSource1.List)
                        {
                            objitem = new ItemEntadaMat
                            {
                                prod = new Produto {idprod = itens.idprod},
                                identrada = objEntadaMat.identrada,
                                preco = itens.preco,
                                qtde = itens.quantidade,
                                data = objEntadaMat.data
                            };
                            switch (itens.padrao)
                            {
                                case "D":
                                    objitem.DeletarItem();
                                    break;
                                case "I":
                                    objitem.InsereItem();
                                    break;
                                case "A":
                                    objitem.AlterarItem();
                                    break;
                            }
                        }
                        MessageBox.Show("Entrada de MAteriais alterado com sucesso!", "Sucesso", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    panel1.Visible = false;
                    carregar();
                }
            }
            catch (Exception er)
            {
                erro(er.Message);
            }
        }

        private bool ConsisteItens()
        {
            if (txtCodPrd.TextLength == 0)
            {
                erro("Preencher Código");
                txtCodPrd.Focus();
                return false;
            }
            if (txtPreco.TextLength == 0)
            {
                erro("Preencher Preço");
                txtPreco.Focus();
                return false;
            }

            if (Convert.ToDecimal(txtQtde.Text) <= 0)
            {
                erro("Informar a Quantidade");
                txtQtde.Focus();
                return false;
            }
            return true;
        }

        public void CarregaPanel()
        {
            panel1.Left = 0;
            panel1.Top = 0;
            panel1.Visible = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpaDados();
            LimpaItens();
            DateNf.Enabled = true;
            ListaItens.Clear();
            bindingSource1.Clear();
            txtCodigo.Focus();
            lblindicador.Text = "+ Inserção";
            lblindicador.BackColor = Color.Chartreuse;
            lblindicador.Visible = true;
            CarregaPanel();
        }

        private void FormEntradaMatcs_Load(object sender, EventArgs e)
        {
            carregar();
        }

        private void dataGridView1_DataMemberChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                ((DataTable) dataGridView2.DataSource).DefaultView.RowFilter = " identrada2 =" +
                                                                               dataGridView1.CurrentRow.Cells[
                                                                                   "identrada"]
                                                                                   .Value.ToString();
            }
            else
            {
                ((DataTable)dataGridView2.DataSource).DefaultView.RowFilter = " 1 = 2";
            }
        }

        private void dataGridView1_CursorChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                ((DataTable) dataGridView2.DataSource).DefaultView.RowFilter = " identrada2 =" +
                                                                               dataGridView1.CurrentRow.Cells[
                                                                                   "identrada"]
                                                                                   .Value.ToString();
            }
            else
            {
                ((DataTable)dataGridView2.DataSource).DefaultView.RowFilter = " 1 = 2";
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                    ((DataTable) dataGridView2.DataSource).DefaultView.RowFilter = " identrada2 =" +
                                                                                   dataGridView1.CurrentRow.Cells[
                                                                                       "identrada"]
                                                                                       .Value.ToString();
            }
            else
            {
                ((DataTable)dataGridView2.DataSource).DefaultView.RowFilter = " 1 = 2" ;
            }
            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                limpaDados();
                LimpaItens();
                DateNf.Enabled = false;
                ListaItens.Clear();
                lblindicador.Text = "~ Alteração";
                lblindicador.BackColor = Color.CornflowerBlue;
                lblindicador.Visible = true;
                ItemEntadaMat objItemEntadaMat = new ItemEntadaMat();
                objItemEntadaMat.identrada =
                    Convert.ToInt16(dataGridView1.CurrentRow.Cells["identrada"].Value.ToString());
                int cont = 0;
                bindingSource1.Clear();
                foreach (ItemEntadaMat itens in objItemEntadaMat.RetornarID())
                {
                    if (cont == 0)
                    {
                        txtCodigo.Text = itens.identrada.ToString();
                        txtNF.Text = itens.nf;
                        DateNf.Value = itens.data;
                        cont++;
                    }
                    bindingSource1.Add(new itensGrid
                    {
                        descprod = itens.prod.descricao,
                        idprod = itens.prod.idprod,
                        padrao = "N",
                        preco = itens.preco,
                        quantidade = itens.qtde
                    });
                }

            }
            
            CarregaPanel();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            ItemEntadaMat itns = new ItemEntadaMat();
            itns.identrada = Convert.ToInt16(dataGridView1.CurrentRow.Cells["identrada"].Value.ToString());
            itns.ApagaTodosItensID();
            itns.Deletar();
            carregar();
        }

        private void txtCodPrd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                FormConsulta fr = new FormConsulta();
                fr.CarregaProduto();
                if(fr.vg_codigo != "")
                {
                    txtCodPrd.Text = fr.vg_codigo;
                    descProd.Text = fr.vg_descricao;
                    txtQtde.Focus();
                }
            }
            
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

        public void CalculaTotal()
        {
            Decimal cont = 0;
            foreach (itensGrid iten in ListaItens)
            {
                cont = cont + iten.preco * iten.quantidade;
            }
            textBox1.Text = cont.ToString("C");
        }

        private void bindingSource1_ListChanged_1(object sender, ListChangedEventArgs e)
        {
            CalculaTotal();
        }

        private void txtPesq_TextChanged(object sender, EventArgs e)
        {
            if (txtPesq.TextLength > 0)
            {
                switch (Opcoes.SelectedIndex)
                {
                    case 0:
                        ((DataTable) dataGridView1.DataSource).DefaultView.RowFilter = string.Format(" nf = {0} ",txtPesq.Text.ToUpper().Trim().Replace("'","''"));
                        break;
                    case 1:
                        ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = string.Format(" identrada = {0} ", txtPesq.Text.ToUpper().Trim().Replace("'", "''"));
                        break;
                    default:
                        ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = "";
                        ((DataTable)dataGridView2.DataSource).DefaultView.RowFilter = "";
                        break;
                }
                
            }
            else
            {
                ((DataTable) dataGridView1.DataSource).DefaultView.RowFilter = "";
            }
        }

        private void Opcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPesq_TextChanged(null, null);

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
    }

    public class itensGrid
    {
        public int idprod { get; set; }
        public String descprod { get; set; }
        public Decimal quantidade { get; set; }
        public Decimal preco { get; set; }
        public String padrao { get; set; }

    
    }
}
