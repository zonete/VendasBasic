using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Vendas.BD
{
    public class Usuario
    {
        public int  IdUsuario { get; set; }

        private String _senha;
        public String Senha{
            get { return _senha; }
            set
            {
                MD5 objMd5 = MD5.Create();
                byte[] retornmd5 = objMd5.ComputeHash(Encoding.UTF8.GetBytes(value));
                StringBuilder resultado = new StringBuilder();
                resultado.Clear();
                for (int i = 0; i < retornmd5.Length ; i++)
                {
                    resultado.Append(retornmd5[i].ToString());
                }
                
                _senha = resultado.ToString();
            }
        }

        

        public String Login;



        public void Insere()
        {
            using (Conexao con = new Conexao())
            {
                String sql = "INSERT INTO USUARIO(login,senha) values (@login,@senha)";

                using (OleDbCommand command = new OleDbCommand(sql,con.GetConexao()))
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@login", this.Login);
                    command.Parameters.AddWithValue("@senha", this._senha);
                    command.ExecuteNonQuery();
                }

            }
        }

        public List<Usuario> Carrega()
        {
            List < Usuario > listUsuarios = new List<Usuario>();
            using (Conexao con = new Conexao())
            {
                string sql = "select idusuario,login,senha from usuario";
                using (OleDbCommand command = new OleDbCommand(sql,con.GetConexao()))
                {
                    OleDbDataReader dtReader = command.ExecuteReader();
                    if (dtReader != null)
                    {
                        Usuario us;
                        while (dtReader.Read())
                        {
                            us = new Usuario();
                            us.Login = dtReader[1].ToString();
                            us.IdUsuario = Convert.ToInt16(dtReader[0]);
                            listUsuarios.Add(us);
                        }
                    }

                }
            }
            return listUsuarios;
        }

        public void CarregaID()
        {
            using (Conexao con = new Conexao())
            {
                string sql = "select idusuario,login,senha from usuario where idusuario=@id";
                using (OleDbCommand command = new OleDbCommand(sql,con.GetConexao()))
                {
                    command.Parameters.AddWithValue("@id", this.IdUsuario);
                    OleDbDataReader dtrReader = command.ExecuteReader();
                    if (dtrReader.Read())
                    {
                        this.Login = dtrReader["login"].ToString();
                    }
                    else
                    {
                        this.IdUsuario = -1;
                        throw new Exception("Usuário não encontrado");
                    }

                }

            }
        }

        public void Excluir()
        {
            try
            {
                using (Conexao con = new Conexao())
                {
                    string sql = "delete from usuario where idusuario=@id";
                    using (OleDbCommand command = new OleDbCommand(sql, con.GetConexao()))
                    {
                        command.Parameters.AddWithValue("@id", this.IdUsuario);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        public bool VerificaDispLogin(int id=0)
        {
            using (Conexao con = new Conexao())
            {
                string sql;
                if (id == 0)
                {
                     sql = "select count(*) from usuario where ucase(login) = ucase(@usuario)";
                }
                else
                {
                    sql = "select count(*) from usuario where ucase(login) = ucase(@usuario) and idusuario<>@id";
                }
                using (OleDbCommand command = new OleDbCommand(sql,con.GetConexao()))
                {
                    command.Parameters.AddWithValue("@usuario", this.Login);
                    if (id != 0)
                    {
                        command.Parameters.AddWithValue("@id", id);
                    }
                    OleDbDataReader dataReader = command.ExecuteReader();
                    dataReader.Read();
                    if (Convert.ToInt16(dataReader[0].ToString()) > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
        }

        

        public void Altera()
        {
            using (Conexao con = new Conexao())
            {
                string sql = "update usuario set login=@login,senha=@senha where idusuario = @id";
                using (OleDbCommand command = new OleDbCommand(sql,con.GetConexao()))
                {
                    command.Parameters.AddWithValue("@login", this.Login);
                    command.Parameters.AddWithValue("@senha", this._senha);
                    command.Parameters.AddWithValue("@id", this.IdUsuario);
                    command.ExecuteNonQuery();

                }
            }
        }
        
        public bool Verifica()
        {
            using (Conexao con = new Conexao())
            {
                String sql = "select idusuario from usuario where  login= @login and senha= @senha";

                using (OleDbCommand command = new OleDbCommand(sql, con.GetConexao()))
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@login", this.Login);
                    command.Parameters.AddWithValue("@senha", this._senha);
                    OleDbDataReader drReader;
                    drReader = command.ExecuteReader();
                    try
                    {
                        if (drReader != null)
                        {
                            if (drReader.Read())
                            {
                                IdUsuario = Convert.ToInt16(drReader[0].ToString());
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }

                    }
                    catch (Exception erro)
                    {
                        throw;
                    }
                }

            }
        }
    }
}
