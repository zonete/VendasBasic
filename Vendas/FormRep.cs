using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Diagnostics;


namespace Vendas
{
    public partial class FormRep : Form
    {
        public FormRep()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           


            Form2 f = new Form2();
            
            f.ShowDialog();

        }

        private void FormRep_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BDDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.BDDataSet.DataTable1);
            // TODO: This line of code loads data into the 'BDDataSet.Ajuste' table. You can move, or remove it, as needed.
            this.AjusteTableAdapter.Fill(this.BDDataSet.Ajuste);

            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.altera("Report3.rdlc");
            f.ShowDialog();
            
         /*   ReportViewer report = new ReportViewer();
            report.ProcessingMode = ProcessingMode.Local;
            report.LocalReport.ReportEmbeddedResource = "Vendas.Report3.rdlc";

            byte[] bytepdf = reportViewer1.LocalReport.Render("Pdf");
            FileStream fileStream = null;
            string nomearq = Path.GetTempPath() + "Teste" + DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss") + ".pdf";

            fileStream = new FileStream(nomearq,FileMode.Create);
            fileStream.Write(bytepdf,0,bytepdf.Length);
            fileStream.Close();

            Process.Start(nomearq);*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.altera2("Report3.rdlc");
            f.ShowDialog();
        }
    }
}
