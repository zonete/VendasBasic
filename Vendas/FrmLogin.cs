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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario objUsuario = new Usuario{IdUsuario=0,Login = txtUsuario.Text ,Senha = txtSenha.Text};
            if (objUsuario.Verifica())
            {
                StaticClasss.Userconectado = objUsuario;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário não autorizado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //MessageBox.Show("OK");

        }
    }
}
