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
    public partial class FormCadCliente : Form
    {
        DataTable dt = new DataTable();
        public FormCadCliente(){

            InitializeComponent();

            dt.Columns.Add("idcliente");
            dt.Columns.Add("nome");
            dt.Columns.Add("telefone");
            dt.Columns.Add("celular");
            dt.Columns.Add("cidade");
            dt.Columns.Add("obs");
        }

        public void Carrega()
        {
            Cliente objCliente = new Cliente();
            dt.Clear();
            DataRow r;
            foreach (var cli in objCliente.listar())
            {
                r = dt.NewRow();
                r["idcliente"] = cli.idcliente;
                r["nome"] = cli.nome;
                r["telefone"] = cli.telefone;
                r["celular"] = cli.celular;
                r["cidade"] = cli.cidade;
                r["obs"] = cli.obs;
                dt.Rows.Add(r);
            }
            dataGridView1.DataSource = dt;

        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpaCampo();
            txtNome.Focus();
            lblindicador.Text = "+ Inserção";
            lblindicador.BackColor = Color.Chartreuse;
            lblindicador.Visible = true;
            CarregaPanel();
        }
        public void limpaCampo()
        {
            txtCodigo.Clear();
            txtObs.Clear();
            txtNome.Clear();
            txtCidade.Clear();
            txtcel.Clear();
            TxtTel.Clear();

        }

        private void FormCadCliente_Load(object sender, EventArgs e)
        {
            Carrega();
            panel1.Visible = false;
        }
        public void CarregaPanel()
        {
            panel1.Left = 0;
            panel1.Top = 0;
            panel1.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConsisteGeral())
                {
                    Cliente objCliente = new Cliente();
                    objCliente.celular = txtcel.Text;
                    objCliente.cidade = txtCidade.Text;
                    objCliente.nome = txtNome.Text;
                    objCliente.obs = txtObs.Text;
                    objCliente.telefone = TxtTel.Text;
                    if (txtCodigo.TextLength == 0)
                    {
                        objCliente.Insere();
                        MessageBox.Show("Cadastro Realizado com sucesso!", "Sucesso", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        //inclusao
                    }
                    else
                    {
                        //alteracao
                        objCliente.idcliente = Convert.ToInt16(txtCodigo.Text);
                        objCliente.Alterar();
                        MessageBox.Show("Cadastro alterado com sucesso!", "Sucesso", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    Carrega();
                    panel1.Visible = false;
                }
            }
            catch (Exception er)
            {
                erro(er.Message);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            limpaCampo();
            lblindicador.Text = "~ Alteração";
            lblindicador.BackColor = Color.CornflowerBlue;
            lblindicador.Visible = true;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow r = dataGridView1.CurrentRow;
                    Cliente objCliente = new Cliente();
                    objCliente.idcliente = Convert.ToInt16(r.Cells["idcliente"].Value.ToString());
                    objCliente.CarregaID();
                    txtCodigo.Text = Convert.ToString(objCliente.idcliente);
                    txtCidade.Text = objCliente.cidade;
                    txtNome.Text = objCliente.nome;
                    txtObs.Text = objCliente.obs;
                    txtcel.Text = objCliente.celular;
                    TxtTel.Text = objCliente.telefone;
                }
                catch (Exception erros)
                {
                    erro(erros.Message);
                }


            }
            CarregaPanel();
        }
        public void erro(String erro)
        {
            MessageBox.Show(erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private bool ConsisteGeral()
        {
            if (txtNome.TextLength == 0)
            {
                erro("Informe o Nome");
                txtNome.Focus();
                return false;
            }
            return true;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    Cliente objcliente = new Cliente();
                    objcliente.idcliente = Convert.ToInt16(((DataGridViewRow)dataGridView1.CurrentRow).Cells["idcliente"].Value.ToString());
                    objcliente.CarregaID();
                    if (
                        MessageBox.Show("Deseja excluir produto:" + objcliente.nome + " ??", "Confirmação",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        objcliente.Deletar();
                        Carrega();
                    }
                }
                catch (Exception exception)
                {

                    erro(exception.Message);
                }
            }
        }

        private void txtPesq_TextChanged(object sender, EventArgs e)
        {
            if ((txtPesq.TextLength > 0) && (Opcoes.SelectedIndex >= 0))
            {
                
                switch (Opcoes.SelectedIndex)
                {
                    case 0:
                        ((DataTable) dataGridView1.DataSource).DefaultView.RowFilter =
                            string.Format(" idcliente = '{0}'",txtPesq.Text.ToUpper().Trim().Replace("'","''"));
                        break;
                    case 1: ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter =
                             string.Format(" nome like '%{0}%'", txtPesq.Text.ToUpper().Trim().Replace("'", "''"));
                        break;
                    case 2: ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter =
                             string.Format(" cidade like '%{0}%'", txtPesq.Text.ToUpper().Trim().Replace("'", "''"));
                        break;
                    case 3: ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter =
                             string.Format(" telefone like '%{0}%'", txtPesq.Text.ToUpper().Trim().Replace("'", "''"));
                        break;
                    case 4: ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter =
                             string.Format(" celular like '%{0}%'", txtPesq.Text.ToUpper().Trim().Replace("'", "''"));
                        break;
                }
            }
            else
            {
                ((DataTable) dataGridView1.DataSource).DefaultView.RowFilter = "";
            }
        }
    }
}
