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
using Microsoft.Reporting.WinForms;
using Vendas.BD;

namespace Vendas
{
    public partial class FormRelSaldoData : Form
    {
        DataTable dt = new DataTable();
        public FormRelSaldoData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt.Clear();
            using (Conexao con = new Conexao())
            {
                String sql =
                    "SELECT p.idprod, p.descricao ,h.saldo_atual ,h.data  from produto p, histprod h where h.idprod = p.idprod and h.data = (select max(data) from histprod hh where hh.idprod = h.idprod and data<@data) ";
                using (OleDbCommand command = new OleDbCommand(sql, con.GetConexao()))
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@data", dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                    OleDbDataAdapter adpAdapter = new OleDbDataAdapter(command);
                    adpAdapter.Fill(dt);
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = dt;

                }
                
            }
            txtPesq_TextChanged(null,null);
            
        }

        private void txtPesq_TextChanged(object sender, EventArgs e)
        {
            if ((txtPesq.TextLength > 0) && (Opcoes.SelectedIndex >= 0))
            {
                switch (Opcoes.SelectedIndex)
                {
                    case 0:
                        ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = string.Format(" idprod = {0}",
                            txtPesq.Text.ToUpper());
                        break;
                    case 1:
                        ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter =
                            string.Format(" descricao like '%{0}%'",
                                txtPesq.Text.ToUpper().Replace("'", "''"));
                        break;
                }
            }
            else
            {
                ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter =
                    "";
            }
        }

        private void Opcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPesq_TextChanged(null,null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                ReportViewer report = new ReportViewer();
                report.LocalReport.ReportEmbeddedResource = "Vendas.Report3.rdlc";
                report.Dock = DockStyle.Fill;
                report.LocalReport.DataSources.Clear();
                report.LocalReport.DataSources.Add(new ReportDataSource("DataSet1",((DataTable)dataGridView1.DataSource)));
                
                report.RefreshReport();
                report.Visible = true;

                Form f = new Form();
                f.Controls.Add(report);

                f.ShowDialog();
            }
        }
    }
}
