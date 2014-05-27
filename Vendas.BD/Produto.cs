using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.BD
{
    public class Produto
    {
        public int idprod  { get; set; }
        public string  descricao { get; set; }
        public DateTime data_cad { get; set; }
        public DateTime data_ult { get; set; }
        public Decimal saldo { get; set; }
        public string fabricante { get; set; }
        public string unidade { get; set; }
        public Decimal preco_compra { get; set; }
        public Decimal preco_venda { get; set; }
        public Decimal estoque_min { get; set; }

        public List<Produto> Listar()
        {
            List<Produto> listProd = new List<Produto>();
            using (Conexao con = new Conexao())
            {
                string sql = "select idprod,descricao,data_cad,data_ult_compra,saldo,fabricante,unidade,preco_compra,preco_venda,estoque_min from produto";
                using (OleDbCommand command = new OleDbCommand(sql,con.GetConexao()))
                {
                    OleDbDataReader dtReader = command.ExecuteReader();
                    while (dtReader.Read())
                    {
                        listProd.Add(new Produto
                        {
                            data_cad = Convert.ToDateTime(dtReader["data_cad"].ToString()),
                            data_ult = Convert.ToDateTime(dtReader["data_ult_compra"].ToString()),
                            descricao = dtReader["descricao"].ToString(),
                            estoque_min = Convert.ToDecimal(dtReader["estoque_min"].ToString()),
                            fabricante = dtReader["fabricante"].ToString(),
                            idprod = Convert.ToInt16(dtReader["idprod"].ToString()),
                            preco_compra = Convert.ToDecimal(dtReader["preco_compra"].ToString()),
                            preco_venda = Convert.ToDecimal(dtReader["preco_venda"].ToString()),
                            saldo = Convert.ToDecimal(dtReader["saldo"].ToString()),
                            unidade = dtReader["unidade"].ToString()
                        });
                    }
                }
            }
            return listProd;
        }

        public void ListarID()
        {
            using (Conexao con = new Conexao())
            {
                string sql = "select idprod,descricao,data_cad,data_ult_compra,saldo,fabricante,unidade,preco_compra,preco_venda,estoque_min from produto where idprod="+idprod;
                using (OleDbCommand command = new OleDbCommand(sql, con.GetConexao()))
                {
                    OleDbDataReader dtReader = command.ExecuteReader();
                   if(dtReader.Read())
                   {
                       data_cad = Convert.ToDateTime(dtReader["data_cad"].ToString());
                       data_ult = Convert.ToDateTime(dtReader["data_ult_compra"].ToString());
                       descricao = dtReader["descricao"].ToString();
                       estoque_min = Convert.ToDecimal(dtReader["estoque_min"].ToString());
                       fabricante = dtReader["fabricante"].ToString();
                       idprod = Convert.ToInt16(dtReader["idprod"].ToString());
                       preco_compra = Convert.ToDecimal(dtReader["preco_compra"].ToString());
                       preco_venda = Convert.ToDecimal(dtReader["preco_venda"].ToString());
                       saldo = Convert.ToDecimal(dtReader["saldo"].ToString());
                       unidade = dtReader["unidade"].ToString();
                   }
                }
            }
        }

        public void CarregaID()
        {
            try
            {
                using (Conexao con = new Conexao())
                {
                    string sql = "select idprod,descricao,data_cad,data_ult_compra,saldo,fabricante,unidade,preco_compra,preco_venda,estoque_min from produto where idprod=@id";
                    using (OleDbCommand command = new OleDbCommand(sql, con.GetConexao()))
                    {
                        command.Parameters.AddWithValue("@id", idprod);
                        OleDbDataReader dtReader = command.ExecuteReader();
                        if (!dtReader.HasRows)
                        {
                            
                            new Exception("Não encontrado produto para id->"+idprod);
                            idprod = -1;
                        }
                        else
                        {
                            while (dtReader.Read())
                            {
                                data_cad = Convert.ToDateTime(dtReader["data_cad"].ToString());
                                data_ult = Convert.ToDateTime(dtReader["data_ult_compra"].ToString());
                                descricao = dtReader["descricao"].ToString();
                                estoque_min = Convert.ToDecimal(dtReader["estoque_min"].ToString());
                                fabricante = dtReader["fabricante"].ToString();
                                preco_compra = Convert.ToDecimal(dtReader["preco_compra"].ToString());
                                preco_venda = Convert.ToDecimal(dtReader["preco_venda"].ToString());
                                saldo = Convert.ToDecimal(dtReader["saldo"].ToString());
                                unidade = dtReader["unidade"].ToString();
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

        public void Inserir()
        {
            try
            {
                using (Conexao con = new Conexao())
                {
                    String sql =
                        "insert into produto(descricao,data_cad,data_ult_compra,saldo,fabricante,unidade,preco_compra,preco_venda,estoque_min) values (@descricao,@data_cad,@data_ult_compra,@saldo,@fabricante,@unidade,@preco_compra,@preco_venda,@estoque_min)";
                    using (OleDbCommand com = new OleDbCommand(sql, con.GetConexao2()))
                    {
                        com.Parameters.AddWithValue("@descricao", descricao);
                        com.Parameters.AddWithValue("@data_cad", data_cad);
                        com.Parameters.AddWithValue("@data_ult_compra", data_ult);
                        com.Parameters.AddWithValue("@saldo", saldo.ToString().Replace(".", ","));
                        com.Parameters.AddWithValue("@fabricante", fabricante);
                        com.Parameters.AddWithValue("@unidade", unidade);
                        com.Parameters.AddWithValue("@preco_compra", preco_compra.ToString().Replace(".", ","));
                        com.Parameters.AddWithValue("@preco_venda", preco_venda.ToString().Replace(".", ","));
                        com.Parameters.AddWithValue("@estoque_min", estoque_min.ToString().Replace(".", ","));
                        com.ExecuteNonQuery();
                    }
                    sql = "SELECT @@IDENTITY";
                    int newID;
                    using (OleDbCommand cm = new OleDbCommand(sql, con.GetConexao2()))
                    {
                        newID = Convert.ToInt16(cm.ExecuteScalar());
                        // let the calling process know that it was a success by the number of records affeted (1)
                        //return Convert.ToString(rowsAffected);
                        
                    }
                    Histoprod histoprod = new Histoprod();
                    histoprod.idprod = newID;
                    histoprod.quantidade = saldo;
                    histoprod.data = data_cad;
                    histoprod.InserirHistIni();

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Remover()
        {
            try
            {
                using (Conexao con = new Conexao())
                {
                    Histoprod histoprod = new Histoprod();
                    histoprod.idprod = idprod;
                    histoprod.tipo = 1;
                    histoprod.data = data_cad;
                    histoprod.documento = "0";
                    histoprod.Deleta();

                    string sql =
                        "delete from produto where idprod=@id";
                    using (OleDbCommand com = new OleDbCommand(sql, con.GetConexao()))
                    {
                        com.Parameters.AddWithValue("@idprod", idprod);
                        com.ExecuteNonQuery();
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
                    String sql =
                        "update produto set descricao=@descricao,data_cad=@data_cad,data_ult_compra=@data_ult_compra,saldo=@saldo,fabricante=@fabricante,unidade=@unidade,preco_compra=@preco_compra,preco_venda=@preco_venda,estoque_min=@estoque_min where idprod = @id";
                    using (OleDbCommand com = new OleDbCommand(sql, con.GetConexao()))
                    {
                        com.Parameters.AddWithValue("@descricao", descricao);
                        com.Parameters.AddWithValue("@data_cad", data_cad);
                        com.Parameters.AddWithValue("@data_ult_compra", data_ult);
                        com.Parameters.AddWithValue("@saldo", saldo.ToString().Replace(".",","));
                        com.Parameters.AddWithValue("@fabricante", fabricante);
                        com.Parameters.AddWithValue("@unidade", unidade);
                        com.Parameters.AddWithValue("@preco_compra", preco_compra.ToString().Replace(".", ","));
                        com.Parameters.AddWithValue("@preco_venda", preco_venda.ToString().Replace(".", ","));
                        com.Parameters.AddWithValue("@estoque_min", estoque_min.ToString().Replace(".", ","));
                        com.Parameters.AddWithValue("@id", idprod);
                        com.ExecuteNonQuery();
                    }
                   
                    Histoprod h = new Histoprod();
                    h.idprod = idprod;
                    h.quantidade = saldo;
                    h.tipo = 1;
                    h.documento = "0";
                    h.data = data_cad;
                    h.Altera();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
