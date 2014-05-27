using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.BD
{
   public class Ajuste
    {
       public int idajuste { get; set; }
       public DateTime data { get; set; }
       public Produto prod { get; set; }
       public int tipo { get; set; }
       public Decimal quantidade { get; set; }
        public void Insere()
        {
            try
            {
                using (Conexao con = new Conexao())
                {
                    string sql = "insert into ajuste(idprod,quantidade,tipo,data) values (@idprod,@quantidade,@tipo,@data)";
                    using (OleDbCommand command = new OleDbCommand(sql, con.GetConexao2()))
                    {
                        command.Parameters.AddWithValue("@idprod", prod.idprod);
                        command.Parameters.AddWithValue("@quantidade", quantidade);
                        command.Parameters.AddWithValue("@tipo", tipo);
                        command.Parameters.AddWithValue("@data", data.ToString("yyyy-MM-dd HH:mm:ss"));
                        command.ExecuteNonQuery();
                    }
                    sql = "SELECT @@IDENTITY";

                    using (OleDbCommand cm = new OleDbCommand(sql, con.GetConexao2()))
                    {
                        idajuste = Convert.ToInt16(cm.ExecuteScalar());
                    }
                }
                Histoprod h = new Histoprod();
                h.idprod = prod.idprod;
                h.quantidade = quantidade;
                h.documento = idajuste.ToString();
                h.data = data;
                if (tipo == 1)
                {
                    h.InserirAjustePositivo();
                }
                else
                {
                    h.InserirAjusteNegativo();
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
                    string sql = "update ajuste set quantidade=@quantidade where idajuste = @idajuste";
                    using (OleDbCommand command = new OleDbCommand(sql, con.GetConexao2()))
                    {
                        command.Parameters.AddWithValue("@quantidade", quantidade);
                        command.Parameters.AddWithValue("@idajuste", idajuste);
                        command.ExecuteNonQuery();
                    }
                }
                Histoprod objHistoprod = new Histoprod();
                objHistoprod.idprod = prod.idprod;
                objHistoprod.documento = idajuste.ToString();
                objHistoprod.quantidade = quantidade;
                objHistoprod.data = data;
                if (tipo == 1)
                {
                    objHistoprod.tipo = 13;
                }
                else
                {
                    objHistoprod.tipo = 12;
                    
                }
                objHistoprod.Altera();
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
                Histoprod objHistoprod = new Histoprod();
                objHistoprod.idprod = prod.idprod;
                objHistoprod.documento = idajuste.ToString();
                objHistoprod.quantidade = quantidade;
                objHistoprod.data = data;
                if (tipo == 1)
                {
                    objHistoprod.tipo = 13;
                }
                else
                {
                    objHistoprod.tipo = 12;

                }
                objHistoprod.Deleta();
                using (Conexao con = new Conexao())
                {
                    string sql = "delete from ajuste where idajuste=@id";
                    using (OleDbCommand command = new OleDbCommand(sql, con.GetConexao()))
                    {
                        command.Parameters.AddWithValue("@id", idajuste);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void CarregaID()
        {
            try
            {
                using (Conexao con = new Conexao())
                {
                    string sql =
                        "select a.idajuste,a.idprod,p.descricao,a.quantidade,a.tipo,a.data from ajuste a, produto p where a.idprod = p.idprod and a.idajuste=@id";
                    using (OleDbCommand command = new OleDbCommand(sql, con.GetConexao()))
                    {
                        command.Parameters.AddWithValue("@id", idajuste);
                        OleDbDataReader dtReader = command.ExecuteReader();
                        if (!dtReader.HasRows)
                        {
                            idajuste = -1;
                            new Exception("Não encontrado cliente id:" + idajuste);


                        }
                        else
                        {
                            if (dtReader.Read())
                            {
                                prod = new Produto { descricao = dtReader["descricao"].ToString(), idprod = Convert.ToInt16(dtReader["idprod"].ToString()) };
                                quantidade = Convert.ToDecimal(dtReader["quantidade"].ToString());
                                data = Convert.ToDateTime(dtReader["data"].ToString());
                                tipo = Convert.ToInt16(dtReader["tipo"].ToString());
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
    }
}
