using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.BD
{
    public class EntradaMat
    {
        public int  identrada { get; set; }
        public DateTime  data { get; set; }
        public string nf { get; set; }


        public void Insere()
        {
            try
            {
                using (Conexao con = new Conexao())
                {
                    string sql = "insert into entradamat(Data,NF) values (@data,@NF)";
                    using (OleDbCommand command = new OleDbCommand(sql, con.GetConexao2()))
                    {
                        command.Parameters.AddWithValue("@data", data);
                        command.Parameters.AddWithValue("@NF", nf);
                        command.ExecuteNonQuery();
                    }
                    sql = "SELECT @@IDENTITY";
                    
                    using (OleDbCommand cm = new OleDbCommand(sql, con.GetConexao2()))
                    {
                        identrada = Convert.ToInt16(cm.ExecuteScalar());
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
                    string sql = "update entradamat set Data=@data,NF=@NF where identrada=@id";
                    using (OleDbCommand command = new OleDbCommand(sql, con.GetConexao()))
                    {
                        command.Parameters.AddWithValue("@data", data);
                        command.Parameters.AddWithValue("@NF", nf);
                        command.Parameters.AddWithValue("@id", identrada);
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
                    string sql = "delete from entradamat where identrada=@id";
                    using (OleDbCommand command = new OleDbCommand(sql, con.GetConexao()))
                    {
                        command.Parameters.AddWithValue("@id", identrada);
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
