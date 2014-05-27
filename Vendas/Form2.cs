using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.Reporting.WinForms.Internal.Soap.ReportingServices2005.Execution;
using Vendas.BD;

namespace Vendas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BDDataSet.Ajuste' table. You can move, or remove it, as needed.
            this.AjusteTableAdapter.Fill(this.BDDataSet.Ajuste);
            // TODO: This line of code loads data into the 'BDDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.BDDataSet.DataTable1);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            

        }

        public void altera(string arquivo)
        {
            
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();
            pg.Margins.Top = 0;
            pg.Margins.Bottom = 0;
            pg.Margins.Left = 0;
            pg.Margins.Right = 0;
            
            reportViewer1.SetPageSettings(pg);


            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Vendas." + arquivo;
        }
        public void altera2(string arquivo)
        {
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();
            pg.Margins.Top = 0;
            pg.Margins.Bottom = 0;
            pg.Margins.Left = 0;
            pg.Margins.Right = 0;
            DataTable dt = new DataTable();
            dt.Clear();
            using (Conexao con = new Conexao())
            {
                String sql =
                    "SELECT p.idprod, p.descricao ,h.saldo_atual ,h.data  from produto p, histprod h where h.idprod = p.idprod and h.data = (select max(data) from histprod hh where hh.idprod = h.idprod)";
                using (OleDbCommand command = new OleDbCommand(sql, con.GetConexao()))
                {
                    OleDbDataAdapter adpAdapter = new OleDbDataAdapter(command);
                    adpAdapter.Fill(dt);
                    

                }
            }
            reportViewer1.SetPageSettings(pg);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Vendas." + arquivo;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1",dt)) ;


            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
