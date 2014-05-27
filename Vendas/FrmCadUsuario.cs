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
using System.Windows.Forms.VisualStyles;
using Vendas.BD;

namespace Vendas
{
    public partial class FrmCadUsuario : Form
    {
        private DataTable dt = new DataTable();
        public FrmCadUsuario()
        {
            InitializeComponent();
            dt.Columns.Add("id");
            dt.Columns.Add("usuario");
           // dt.Columns.Add("senha");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void carrega()
        {
            Usuario obUsuario = new Usuario();
            dt.Clear();

            foreach (var usua in obUsuario.Carrega())
            {
                DataRow dr = dt.NewRow();
                dr["usuario"] = usua.Login;
                dr["id"]=usua.IdUsuario;
                dt.Rows.Add(dr);
            }
            dataGridView1.DataSource = dt;
        }

        private void FrmCadUsuario_Load(object sender, EventArgs e)
        {
            carrega();
            
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ((DataTable) dataGridView1.DataSource).DefaultView.RowFilter = "";
            if (txtPesq.TextLength == 0) return;
            switch (Opcoes.SelectedIndex)
            {
                case 0:
                {
                    ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = string.Format("usuario like '%{0}%'", txtPesq.Text.ToUpper().Trim().Replace("'", "''"));
                    break;
                }
                case 1:
                {
                    ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = string.Format("id = '{0}'", txtPesq.Text.ToUpper().Trim().Replace("'", "''"));
                    break;
                }
                default:
                {
                    break;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (consisteGeral())
            {
                if (txtId.TextLength > 0)
                {
                    //alteracao
                    Usuario objUsuario = new Usuario();
                    objUsuario.Login = txtUsuario.Text;
                    objUsuario.Senha = txtSenha.Text;
                    objUsuario.IdUsuario = Convert.ToInt16(txtId.Text);
                    if (objUsuario.VerificaDispLogin(objUsuario.IdUsuario))
                    {
                        MessageBox.Show("Usuário já utilizado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    objUsuario.Altera();
                }
                else
                {
                    //inclusao
                    Usuario objUsuario = new Usuario();
                    objUsuario.Login = txtUsuario.Text;
                    if (objUsuario.VerificaDispLogin())
                    {
                        MessageBox.Show("Usuário ja cadastrado!");
                        return;
                    }
                    objUsuario.Senha = txtSenha.Text;
                    objUsuario.Insere();
                }
                panel1.Enabled = false;
                carrega();
                limpaTela();

            }
        }

        public void limpaTela()
        {
            txtId.Clear();
            txtUsuario.Clear();
            txtSenha.Clear();
            txtSenha2.Clear();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpaTela();
            panel1.Enabled = true;
            txtUsuario.Focus();
            lblindicador.Text = "+ Inserção";
            lblindicador.BackColor = Color.Chartreuse;
            lblindicador.Visible = true;
        }

        public bool consisteGeral()
        {
            if (txtUsuario.TextLength < 3)
            {
                MessageBox.Show("Usuário deve ter pelo menos  3 caracteres");
                txtUsuario.Focus();
                return false;
            }
            if (txtSenha.TextLength < 3 )
            {
                MessageBox.Show("Senha deve ter pelo menos  3 caracteres");
                txtSenha.Focus();
                return false;
            }

            if (!txtSenha.Text.Equals(txtSenha2.Text))
            {
                MessageBox.Show("Senha não conferem");
                txtSenha.Focus();
                return false;
                
            }

            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count > 0 )
            {
                DataGridViewRow r = dataGridView1.CurrentRow;
                Usuario objUsuario = new Usuario();
                objUsuario.IdUsuario = Convert.ToInt16(r.Cells["id"].Value.ToString());
                try
                {
                    objUsuario.CarregaID();
                    txtId.Text = objUsuario.IdUsuario.ToString();
                    txtUsuario.Text = objUsuario.Login.ToString();
                    panel1.Enabled = true;
                    txtUsuario.Focus();
                    lblindicador.Text = "~ Alteração";
                    lblindicador.BackColor = Color.CornflowerBlue;
                    lblindicador.Visible = true;
                }
                catch (Exception erro)
                {
                    MessageBox.Show("ERRO-> "+erro.Message);
                }
            }
        }

        private void panel1_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_EnabledChanged(object sender, EventArgs e)
        {
            dataGridView1.Enabled = !(panel1.Enabled);
            btnAlterar.Enabled = !(panel1.Enabled);
            btnNovo.Enabled = !(panel1.Enabled);
            btnRemover.Enabled = !(panel1.Enabled);
            txtPesq.Enabled = !(panel1.Enabled);
            Opcoes.Enabled = !(panel1.Enabled);
            lblindicador.Visible = panel1.Enabled;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            limpaTela();
            panel1.Enabled = false;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                if (dataGridView1.SelectedRows.Count > 0)
                {

                    try
                    {
                        DataGridViewRow r = dataGridView1.CurrentRow;
                        Usuario objUsuario = new Usuario();
                        objUsuario.IdUsuario = Convert.ToInt16(r.Cells["id"].Value.ToString());
                        objUsuario.CarregaID();
                        if (MessageBox.Show("Deseja Excluir usuario:"+objUsuario.Login+" ??","Confirmação",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)==DialogResult.Yes)
                        {
                            objUsuario.Excluir();
                            carrega();

                        }
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
    }
}
