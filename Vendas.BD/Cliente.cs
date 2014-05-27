using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.BD
{
    public class Cliente
    {
        public int    idcliente { get; set; }
        public string nome      { get; set; }
        public string telefone  { get; set; }
        public string celular   { get; set; }
        public string cidade    { get; set; }
        public string obs       { get; set; }


        public List<Cliente> listar()
        {
            List<Cliente> listagem = new List<Cliente>();
            using (Conexao con = new Conexao())
            {
                string sql = "select idcliente,nome,telefone,celular,cidade,observacao from cliente";
                using (OleDbCommand command = new OleDbCommand(sql,con.GetConexao()))
                {
                    OleDbDataReader dtReader = command.ExecuteReader();
                    while (dtReader.Read())
                    {
                        listagem.Add(new Cliente{celular = dtReader["celular"].ToString(),
                                                 cidade = dtReader["cidade"].ToString(),
                                                 idcliente = Convert.ToInt16(dtReader["idcliente"].ToString()),
                                                 nome = dtReader["nome"].ToString(),
                                                 obs = dtReader["observacao"].ToString(),
                                                 telefone = dtReader["telefone"].ToString()
                        });
                    }
                }
            }
            return listagem;
        }
        public void CarregaID()
        {
            try
            {
                using (Conexao con = new Conexao())
                {
                    string sql =
                        "select idcliente,nome,telefone,celular,cidade,observacao from cliente where idcliente=@id";
                    using (OleDbCommand command = new OleDbCommand(sql, con.GetConexao()))
                    {
                        command.Parameters.AddWithValue("@id", idcliente);
                        OleDbDataReader dtReader = command.ExecuteReader();
                        if (!dtReader.HasRows)
                        {
                            idcliente = -1;
                            new Exception("Não encontrado cliente id:" + idcliente);
                            
                            
                        }
                        else
                        {
                            while (dtReader.Read())
                            {
                                celular = dtReader["celular"].ToString();
                                cidade = dtReader["cidade"].ToString();
                                idcliente = Convert.ToInt16(dtReader["idcliente"].ToString());
                                nome = dtReader["nome"].ToString();
                                obs = dtReader["observacao"].ToString();
                                telefone = dtReader["telefone"].ToString();

                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void Insere()
        {
            try
            {
                using (Conexao con = new Conexao())
                {
                    string sql = "insert into cliente(nome,telefone,celular,cidade,observacao) values (@nome,@telefone,@celular,@cidade,@observacao)";
                    using (OleDbCommand command = new OleDbCommand(sql, con.GetConexao()))
                    {
                        command.Parameters.AddWithValue("@nome", nome);
                        command.Parameters.AddWithValue("@telefone", telefone);
                        command.Parameters.AddWithValue("@celular", celular);
                        command.Parameters.AddWithValue("@cidade", cidade);
                        command.Parameters.AddWithValue("@observacao", obs);
                        command.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }



        public void Alterar()
        {
            try
            {
                using (Conexao con = new Conexao())
                {
                    string sql =
                        "update cliente set  nome=@nome,telefone=@telefone,celular=@celular,cidade=@cidade,observacao=@observacao where idcliente = @id ";
                    using (OleDbCommand command = new OleDbCommand(sql, con.GetConexao()))
                    {
                        command.Parameters.AddWithValue("@nome", nome);
                        command.Parameters.AddWithValue("@telefone", telefone);
                        command.Parameters.AddWithValue("@celular", celular);
                        command.Parameters.AddWithValue("@cidade", cidade);
                        command.Parameters.AddWithValue("@observacao", obs);
                        command.Parameters.AddWithValue("@id", idcliente);
                        command.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
    }


        public void Deletar()
        {
            try
            {
                using (Conexao con = new Conexao())
                {
                    string sql =
                        "delete from cliente where idcliente = @id ";
                    using (OleDbCommand command = new OleDbCommand(sql, con.GetConexao()))
                    {
                        command.Parameters.AddWithValue("@id", idcliente);
                        command.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        
        
    }
}
