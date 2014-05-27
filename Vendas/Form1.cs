using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form _openForm in Application.OpenForms)
            {
                if (_openForm is FrmCadUsuario )
                {
                    if (_openForm.WindowState.Equals(FormWindowState.Minimized))
                    {
                        _openForm.WindowState = FormWindowState.Normal;
                    }
                    _openForm.Focus();
                    
                    return;
                }
                
            }
            FrmCadUsuario frm = new FrmCadUsuario();
            frm.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form _openForm in Application.OpenForms)
            {
                if (_openForm is FormCadProd)
                {
                    _openForm.WindowState = FormWindowState.Normal;
                    _openForm.Focus();
                    return;
                }
            }
            FormCadProd frm = new FormCadProd();
            frm.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form _open in Application.OpenForms)
            {
                if (_open is FormCadCliente)
                {
                    _open.WindowState = FormWindowState.Normal;
                    _open.Focus();
                    return;
                }
                
            }
            FormCadCliente frmCliente = new FormCadCliente();
            frmCliente.Show();
        }

        private void entradaMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form _open in Application.OpenForms)
            {
                if (_open is FormEntradaMatcs)
                {
                    _open.WindowState = FormWindowState.Normal;
                    _open.Focus();
                    return;
                }

            }
            FormEntradaMatcs frmCliente = new FormEntradaMatcs();
            frmCliente.Show();
        }

        private void devoluçãoDevToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form _open in Application.OpenForms)
            {
                if (_open is FormAjuste)
                {
                    _open.WindowState = FormWindowState.Normal;
                    _open.Focus();
                    return;
                }

            }
            FormAjuste frmAjuste = new FormAjuste();
            frmAjuste.Show();
        }

        private void saídaReqToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form _open in Application.OpenForms)
            {
                if (_open is FormVendas)
                {
                    _open.WindowState = FormWindowState.Normal;
                    _open.Focus();
                    return;
                }

            }
            FormVendas frmVendas = new FormVendas();
            frmVendas.Show();
        }

        private void produtoSaldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form _open in Application.OpenForms)
            {
                if (_open is FormRelSaldo)
                {
                    _open.WindowState = FormWindowState.Normal;
                    _open.Focus();
                    return;
                }

            }
            FormRelSaldo frmrelsaldo = new FormRelSaldo();
            frmrelsaldo.Show();
        }

        private void saldoNaDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form _open in Application.OpenForms)
            {
                if (_open is FormRelSaldoData)
                {
                    _open.WindowState = FormWindowState.Normal;
                    _open.Focus();
                    return;
                }

            }
            FormRelSaldoData frmrelsaldo = new FormRelSaldoData();
            frmrelsaldo.Show();
        }

        private void vendasNoMêsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form _open in Application.OpenForms)
            {
                if (_open is FormRelVendasMês)
                {
                    _open.WindowState = FormWindowState.Normal;
                    _open.Focus();
                    return;
                }

            }
            FormRelVendasMês frmrelsaldo = new FormRelVendasMês();
            frmrelsaldo.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSobre frmSobre = new FormSobre();
            frmSobre.ShowDialog();
        }
    }
}
