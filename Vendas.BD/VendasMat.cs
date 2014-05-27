using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.BD
{
   public class VendasMat
    {
        public Usuario user { get; set; }
        public int idvenda { get; set; }
        public DateTime datahora { get; set; }
        public Cliente cliente { get; set; }


        public void Insere()
        {
            try
            {
                using (Conexao con = new Conexao())
                {
                    string sql = "insert into saidamat(data,idcliente,idusuario) values (@datahora,@idcliente,@idusuario)";
                    using (OleDbCommand command = new OleDbCommand(sql, con.GetConexao2()))
                    {
                        command.Parameters.AddWithValue("@datahora", datahora.ToString("yyyy-MM-dd HH:mm:ss"));
                        command.Parameters.AddWithValue("@idcliente", cliente.idcliente);
                        command.Parameters.AddWithValue("@idusuario", user.IdUsuario);
                        command.ExecuteNonQuery();
                    }
                    sql = "SELECT @@IDENTITY";

                    using (OleDbCommand cm = new OleDbCommand(sql, con.GetConexao2()))
                    {
                        idvenda= Convert.ToInt16(cm.ExecuteScalar());
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
                    string sql = "update saidamat set idcliente=@idcliente where idvenda=@id";
                    using (OleDbCommand command = new OleDbCommand(sql, con.GetConexao()))
                    {
                        command.Parameters.AddWithValue("@cliente", cliente.idcliente);
                        command.Parameters.AddWithValue("@id", idvenda);
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
                    string sql = "delete from saida where idvenda=@id";
                    using (OleDbCommand command = new OleDbCommand(sql, con.GetConexao()))
                    {
                        command.Parameters.AddWithValue("@id", idvenda);
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
