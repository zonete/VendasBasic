using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vendas.BD;

namespace Vendas
{
    public partial class FormRelVendasMês : Form
    {
        public DataTable dtVenda = new DataTable();
        public DataTable dtVendaitem = new DataTable();
        public FormRelVendasMês()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;
            dtVenda.Columns.Add("idvenda");
            dtVenda.Columns.Add("idcliente");
            dtVenda.Columns.Add("nome");
            dtVenda.Columns.Add("data");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtVenda.Clear();
            dtVendaitem.Clear();
            using (Conexao con = new Conexao())
            {
                String sql =
                    "SELECT v.idvenda, c.idcliente, c.nome, v.data, p.idprod, p.descricao, iv.quantidade, iv.precovenda "+
                    " FROM saidamat AS v, itemsaidamat AS iv, cliente AS c, produto AS p "+
                    " WHERE (((v.idvenda)=[iv].[idvenda]) AND ((p.idprod)=[iv].[idprod]) AND ((v.idcliente)=[c].[idcliente])) " +
                    " and v.data >= @dataini  and v.data < @datafim ";

                using (OleDbCommand command = new OleDbCommand(sql, con.GetConexao()))
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@dataini", dateTimePicker1.Value.ToString("yyyy-MM-"+ "01 00:00:00"));
                    command.Parameters.AddWithValue("@datafim", dateTimePicker1.Value.AddMonths(1).ToString("yyyy-MM-" + "01 00:00:00"));
                    
                    OleDbDataReader reader = command.ExecuteReader();
                    DataRow r;
                    while (reader.Read())
                    {
                        
                        if (dtVenda.Select("idvenda=" + reader["idvenda"].ToString()).Count() == 0)
                        {
                            r = dtVenda.NewRow();
                            r["idvenda"] = reader["idvenda"].ToString();
                            r["idcliente"] = reader["idcliente"].ToString();
                            r["nome"] = reader["nome"].ToString();
                            r["data"] = reader["data"].ToString();
                            dtVenda.Rows.Add(r);
                        }
                    }
                    reader.Close();
                    OleDbDataAdapter adpAdapter = new OleDbDataAdapter(command);
                    adpAdapter.Fill(dtVendaitem);
                    dataGridView2.DataSource = dtVendaitem;
                    dataGridView1.DataSource = dtVenda;
                    



                }

            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.CurrentRow != null)
                {
                    ((DataTable) dataGridView2.DataSource).DefaultView.RowFilter =
                        "idvenda =" + dataGridView1.CurrentRow.Cells["idvenda"].Value.ToString();
                }
                else
                {
                    ((DataTable) dataGridView2.DataSource).DefaultView.RowFilter =
                        "1=2";

                }
            }
        }
    }
}
