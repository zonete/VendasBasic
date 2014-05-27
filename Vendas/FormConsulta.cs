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
    public partial class FormConsulta : Form
    {
        DataTable DT = new DataTable();
        public String vg_codigo = "";
        public String vg_descricao = "";

        public FormConsulta()
        {
            InitializeComponent();
        }

        public void CarregaProduto()
        {
            DT.Columns.Clear();
            DT.Columns.Add("idprod");
            DT.Columns.Add("descprod");
            opcao.Items.Add("Código");
            opcao.Items.Add("Descrição");
            dataGridView1.DataSource = DT;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.Columns[0].HeaderText = "Código";
            dataGridView1.Columns[0].HeaderText = "Produto";
            

            Produto objProduto = new Produto();
            DT.Clear();
            DataRow r;
            foreach (Produto item in objProduto.Listar())
            {
                r = DT.NewRow();
                r["idprod"] = item.idprod;
                r["descprod"] = item.descricao;
                DT.Rows.Add(r);
            }
            ShowDialog();
        }
        public void CarregaVendas()
        {
            DT.Columns.Clear();
            DT.Columns.Add("idvenda");
            DT.Columns.Add("nome");
            DT.Columns.Add("data");
            

            opcao.Items.Add("Código");
            opcao.Items.Add("Nome");

            dataGridView1.DataSource = DT;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.Columns[0].HeaderText = "Código";
            dataGridView1.Columns[1].HeaderText = "Nome";
            dataGridView1.Columns[2].HeaderText = "Data";


            ItemVendas objiVendas = new ItemVendas();
            DT.Clear();
            DataRow r;
            foreach (ItemVendas item in objiVendas.Retornar())
            {
                if (DT.Select("idvenda = " + item.venda.idvenda).Count() == 0)
                {
                    r = DT.NewRow();
                    r["idvenda"] = item.venda.idvenda;
                    r["nome"] = item.venda.cliente.nome;
                    r["data"] = item.venda.datahora;
                    DT.Rows.Add(r);
                }
            }
            ShowDialog();
        }

        public void CarregaCliente()
        {
            DT.Columns.Clear();
            DT.Columns.Add("idcliente");
            DT.Columns.Add("nome");
            opcao.Items.Add("Código");
            opcao.Items.Add("Nome");
            dataGridView1.DataSource = DT;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.Columns[0].HeaderText = "Código";
            dataGridView1.Columns[0].HeaderText = "Nome";


            Cliente objCliente= new Cliente();
            DT.Clear();
            DataRow r;
            foreach (Cliente item in objCliente.listar())
            {
                r = DT.NewRow();
                r["idcliente"] = item.idcliente;
                r["nome"] = item.nome;
                DT.Rows.Add(r);
            }
            ShowDialog();
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if ((txtpesq.TextLength > 0) && (opcao.SelectedIndex >= 0))
            {
                switch (opcao.SelectedIndex)
                {
                    case 1:
                        ((DataTable) dataGridView1.DataSource).DefaultView.RowFilter =
                            string.Format( "{0}  like '%{1}%'", dataGridView1.Columns[1].Name , txtpesq.Text.ToUpper().Trim().Replace("'", "''"));
                        break;
                    case 0:
                        ((DataTable) dataGridView1.DataSource).DefaultView.RowFilter = string.Format(
                            " {0} = '{1}' ",dataGridView1.Columns[0].Name, txtpesq.Text.ToUpper().Replace("'", "''").Trim());
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                vg_codigo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                vg_descricao = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
            Close();
        }
    }
}
