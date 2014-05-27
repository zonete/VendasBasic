using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using Vendas.BD;

namespace Vendas
{
    public partial class FormVendas : Form
    {
        List<itensGrid> listaGrid = new List<itensGrid>();
 
        public FormVendas()
        {
            InitializeComponent();
            bindingSource1.DataSource = listaGrid;
            dataGridView1.AutoGenerateColumns = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtidvenda.Text = "";
            panel2.Enabled = true;
            datevenda.Value = DateTime.Now;
            txtCliente.Focus();
        }

        public void LimpaDados()
        {
            txtCliente.Clear();
            descCliente.Text = "";
            txtTotal.Clear();
            bindingSource1.Clear();
            dataGridView1.Refresh();
        }

        public void limpaItens()
        {
            txtCodProd.Clear();
            txtPreco.Clear();
            txtQtde.Clear();
            DescProd.Text = "";
        }

        private void panel2_EnabledChanged(object sender, EventArgs e)
        {
            panel1.Enabled = !panel2.Enabled;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtidvenda.Clear();
            panel2.Enabled = false;
            LimpaDados();
            limpaItens();
        }

        private void FormVendas_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (col.Name.ToUpper().Equals("PADRAO"))
                {
                    col.Visible = false;
                }

            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            txtCodProd.Enabled = true;
            txtCodProd.Focus();
            btnAdicEdit.Text = "Inserir";
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            txtCodProd.Text = ((itensGrid)bindingSource1.Current).idprod.ToString();
            DescProd.Text = ((itensGrid)bindingSource1.Current).descprod.ToString();
            txtPreco.Text = ((itensGrid)bindingSource1.Current).preco.ToString();
            txtQtde.Text = ((itensGrid)bindingSource1.Current).quantidade.ToString();
            panel3.Visible = true;
            txtCodProd.Enabled = false;
            btnAdicEdit.Text = "Alterar";
        }

        private void btnexcluiitem_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Current != null)
            {
                if (((itensGrid)bindingSource1.Current).padrao.ToUpper().Equals("I"))
                {
                    bindingSource1.Remove(bindingSource1.Current);
                }
                else if (((itensGrid)bindingSource1.Current).padrao.ToUpper().Equals("D"))
                {
                    ((itensGrid)bindingSource1.Current).padrao = "A";
                    btnexcluiitem.Text = "- Excluir";
                }
                else
                {
                    ((itensGrid)bindingSource1.Current).padrao = "D";
                    btnexcluiitem.Text = "<- Desfazer";
                }
            }
        }

        private void btnAdicEdit_Click(object sender, EventArgs e)
        {
            if (ConsisteItens())
            {
                if (btnAdicEdit.Text.Equals("Inserir"))
                {
                    var query = from cl in listaGrid
                                where cl.idprod == Convert.ToInt16(txtCodProd.Text)
                                select cl;
                    if (query.Any())
                    {
                        erro("Já existe o produto na lista! não é permitido duplicidade");
                        return;
                    }
                    bindingSource1.Add(new itensGrid()
                    {
                        preco = Convert.ToDecimal(txtPreco.Text),
                        idprod = Convert.ToInt16(txtCodProd.Text),
                        quantidade = Convert.ToDecimal(txtQtde.Text),
                        descprod = DescProd.Text,
                        padrao = "I"
                    });
                }
                else
                {
                    ((itensGrid)bindingSource1.Current).preco = Convert.ToDecimal(txtPreco.Text);
                    ((itensGrid)bindingSource1.Current).quantidade = Convert.ToDecimal(txtQtde.Text);
                    if (!((itensGrid)bindingSource1.Current).padrao.ToUpper().Equals("I"))
                    {
                        ((itensGrid)bindingSource1.Current).padrao = "A";
                    }
                    
                }
                panel3.Visible = false;
                CalculaTotal();
                limpaItens();
            }
            bindingSource1.ResetBindings(false);
            dataGridView1.Refresh();
            
        }

        public void CalculaTotal()
        {
            Decimal cont = 0;
            foreach (itensGrid iten in listaGrid)
            {
                cont = cont + iten.preco * iten.quantidade;
            }
            txtTotal.Text = cont.ToString("C");
        }
        public void erro(String erro)
        {
            MessageBox.Show(erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private bool ConsisteItens()
        {
            if (txtCodProd.TextLength == 0)
            {
                erro("Preencher Código");
                txtCodProd.Focus();
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

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            limpaItens();
            panel3.Visible = false;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            if (bindingSource1.Current != null)
            {
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

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (listaGrid.Count > 0)
            {

                if ((e.ColumnIndex == 0) && ((itensGrid)bindingSource1[e.RowIndex]).padrao.ToUpper().Equals("D"))
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;

                }
                else if (e.ColumnIndex == 0)
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = dataGridView1.DefaultCellStyle.BackColor;
                }
            }
        }

        private void panel3_VisibleChanged(object sender, EventArgs e)
        {
            btnSalv.Enabled = !panel3.Visible;
            button1.Enabled = !panel3.Visible;
            btnadd.Enabled = !panel3.Visible;
            btnedit.Enabled = !panel3.Visible;
            btnexcluiitem.Enabled = !panel3.Visible;
            datevenda.Enabled  = !panel3.Visible;
            txtCliente.Enabled = !panel3.Visible;
            dataGridView1.Enabled = !panel3.Visible;
        }

        private void txtCodProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                FormConsulta fr = new FormConsulta();
                fr.CarregaProduto();
                if (fr.vg_codigo != "")
                {
                    txtCodProd.Text = fr.vg_codigo;
                    DescProd.Text = fr.vg_descricao;
                    txtQtde.Focus();
                }
            }
        }

        private void txtCodProd_Leave(object sender, EventArgs e)
        {
            if ((txtCodProd.TextLength > 0) && (DescProd.Text.Equals("")))
            {
                Produto pr = new Produto();
                pr.idprod = Convert.ToInt16(txtCodProd.Text);
                pr.ListarID();
                if (pr.descricao != null)
                {
                    DescProd.Text = pr.descricao;
                }
                else
                {
                    erro("Produto não cadastrado");
                    txtCodProd.Text = "";
                    txtCodProd.Focus();
                }

            }
        }

        private void txtCodProd_TextChanged(object sender, EventArgs e)
        {
            DescProd.Text = "";
        }

        private void txtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                FormConsulta frm = new FormConsulta();
                frm.CarregaCliente();
                if (frm.vg_codigo != "")
                {
                    txtCliente.Text = frm.vg_codigo;
                    descCliente.Text = frm.vg_descricao;
                }
            }
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            descCliente.Text = "";
        }

        private void txtCliente_Leave(object sender, EventArgs e)
        {
            if ((txtCliente.TextLength > 0) && (descCliente.Text == ""))
            {
                Cliente cli = new Cliente();
                cli.idcliente = Convert.ToInt16(txtCliente.Text);
                cli.CarregaID();
                if (cli.idcliente > 0)
                {
                    descCliente.Text = cli.nome;
                }
                else
                {
                    erro("Cliente não encontrado");
                    txtCliente.Focus();
                }
            }
        }

        private void bindingSource1_ListChanged(object sender, ListChangedEventArgs e)
        {
            CalculaTotal();
        }
        public bool ConsisteGeral()
        {
            if (txtCliente.TextLength == 0)
            {
                erro("informe NF");
                return false;
            }
            if (datevenda.Value == null)
            {
                erro("informe data");
                return false;
            }

            return true;
        }
        private void btnSalv_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConsisteGeral())
                {
                    VendasMat objVendasMat = new VendasMat();
                    objVendasMat.cliente = new Cliente{idcliente = Convert.ToInt16(txtCliente.Text)};
                    objVendasMat.user = StaticClasss.Userconectado;
                    objVendasMat.datahora = datevenda.Value;

                    if (txtidvenda.TextLength == 0)
                    {
                        objVendasMat.Insere();
                        ItemVendas  objitem;
                        foreach (itensGrid itens in bindingSource1.List)
                        {
                            objitem = new ItemVendas
                            {
                                prod = new Produto { idprod = itens.idprod },
                                venda = objVendasMat,
                                preco = itens.preco,
                                quantidade = itens.quantidade
                            };
                            objitem.InsereItem();
                        }
                        MessageBox.Show("Vendas Realizada com sucesso!", "Sucesso", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    }
                    else
                    {
                        //alteracao
                        objVendasMat.idvenda = Convert.ToInt16(txtidvenda.Text);
                        objVendasMat.Alterar();
                        ItemVendas objitem;
                        foreach (itensGrid itens in bindingSource1.List)
                        {
                            objitem = new ItemVendas
                            {
                                prod = new Produto { idprod = itens.idprod },
                                venda = objVendasMat,
                                preco = itens.preco,
                                quantidade = itens.quantidade
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
                        MessageBox.Show("Vendas alterada com sucesso!", "Sucesso", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    LimpaDados();
                    limpaItens();
                    panel2.Enabled = true;

                }
            }
            catch (Exception er)
            {
                erro(er.Message);
            }
        }

        private void txtidvenda_Leave(object sender, EventArgs e)
        {
            if (txtidvenda.TextLength > 0)
            {
                //altera
                limpaItens();
                LimpaDados();
                ItemVendas objVendas = new ItemVendas();
                objVendas.venda = new VendasMat {idvenda = Convert.ToInt16(txtidvenda.Text)};
                int i = 0;
                bindingSource1.Clear();
                foreach (ItemVendas iten in objVendas.RetornarID())
                {
                    if (i==0)
                    {
                        txtCliente.Text = iten.venda.cliente.idcliente.ToString();
                        descCliente.Text = iten.venda.cliente.nome;
                        datevenda.Value = iten.venda.datahora;
                        i++;
                    }
                    bindingSource1.Add(new itensGrid
                    {
                        descprod = iten.prod.descricao,
                        idprod = Convert.ToInt16(iten.prod.idprod),
                        padrao = "N",
                        preco = iten.preco,
                        quantidade = iten.quantidade
                    });
                }
                if (i > 0)
                {
                    dataGridView1.Refresh();

                    panel2.Enabled = true;
                }
                else
                {
                    erro("Venda não localizada");
                    txtidvenda.Focus();
                }
            }
        }

        private void txtidvenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                   FormConsulta frm = new FormConsulta();
                   frm.CarregaVendas();
                if (frm.vg_codigo != "")
                {
                    txtidvenda.Text = frm.vg_codigo;
                    txtidvenda_Leave(null,null);
                }

            }
        
        }

        private void txtidvenda_DoubleClick(object sender, EventArgs e)
        {
            FormConsulta frm = new FormConsulta();
            frm.CarregaVendas();
            if (frm.vg_codigo != "")
            {
                txtidvenda.Text = frm.vg_codigo;
                txtidvenda_Leave(null, null);
            }
        }

        private void txtCliente_DoubleClick(object sender, EventArgs e)
        {
            FormConsulta frm = new FormConsulta();
            frm.CarregaCliente();
            if (frm.vg_codigo != "")
            {
                txtCliente.Text = frm.vg_codigo;
                descCliente.Text = frm.vg_descricao;
            }
        }

        private void txtCodProd_DoubleClick(object sender, EventArgs e)
        {
            FormConsulta fr = new FormConsulta();
            fr.CarregaProduto();
            if (fr.vg_codigo != "")
            {
                txtCodProd.Text = fr.vg_codigo;
                DescProd.Text = fr.vg_descricao;
                txtQtde.Focus();
            }
        }

        private void txtidvenda_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtidvenda_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
    
}


