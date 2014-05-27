using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.BD
{
    public class ItemEntadaMat:EntradaMat
    {
        public Produto prod { set; get; }
        public Decimal qtde{ set; get; }
        public Decimal preco{ set; get; }
        public void InsereItem()
        {
            try
            {
                using (Conexao con = new Conexao())
                {
                    string sql = "insert into itementradamat(identrada,idprod,quantidade,preco_compra) values (@identrada,@idprod,@quantidade,@preco_compra)";
                    using (OleDbCommand command = new OleDbCommand(sql, con.GetConexao()))
                    {
                        command.Parameters.AddWithValue("@identrada", identrada);
                        command.Parameters.AddWithValue("@idprod",prod.idprod);
                        command.Parameters.AddWithValue("@quantidade", qtde);
                        command.Parameters.AddWithValue("@preco_compra", preco);
                        command.ExecuteNonQuery();
                    }
                    con.cLose();
                }
                Histoprod objHistoprod = new Histoprod();
                objHistoprod.idprod = prod.idprod;
                objHistoprod.documento = identrada.ToString();
                objHistoprod.quantidade = qtde;
                objHistoprod.data = data;
                objHistoprod.InserirHistNF();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void  AlterarItem()
        {
            try
            {
                using (Conexao con = new Conexao())
                {
                    string sql = "update itementradamat set quantidade=@quantidade,preco_compra=@preco_compra where identrada=@id and idprod=@idprod";
                    using (OleDbCommand command = new OleDbCommand(sql, con.GetConexao()))
                    {
                        command.Parameters.AddWithValue("@quantidade", qtde);
                        command.Parameters.AddWithValue("@preco_compra", preco);
                        command.Parameters.AddWithValue("@id", identrada);
                        command.Parameters.AddWithValue("@idprod", prod.idprod);
                        command.ExecuteNonQuery();
                    }
                }
                Histoprod objHistoprod = new Histoprod();
                objHistoprod.idprod = prod.idprod;
                objHistoprod.documento = identrada.ToString();
                objHistoprod.quantidade = qtde;
                objHistoprod.data = data;
                objHistoprod.tipo = 3;
                objHistoprod.Altera();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeletarItem()
        {
            try
            {
                Histoprod objHistoprod = new Histoprod();
                objHistoprod.idprod = prod.idprod;
                objHistoprod.documento = identrada.ToString();
                objHistoprod.quantidade = qtde;
                objHistoprod.data = data;
                objHistoprod.tipo = 3;
                objHistoprod.Deleta();
                using (Conexao con = new Conexao())
                {
                    string sql = "delete from itementradamat where identrada=@id and idprod=@idprod";
                    using (OleDbCommand command = new OleDbCommand(sql, con.GetConexao()))
                    {
                        command.Parameters.AddWithValue("@id", identrada);
                        command.Parameters.AddWithValue("@idprod", prod.idprod);
                        command.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }


        public List<ItemEntadaMat> Retornar()
        {
            List<ItemEntadaMat> lista = new List<ItemEntadaMat>();

            using (Conexao con = new Conexao())
            {
                string sql = "select e.identrada,e.data,e.nf,i.idprod,p.descricao,i.quantidade,i.preco_compra from entradamat e ,itementradamat i,produto p where e.identrada = i.identrada and p.idprod = i.idprod";
                using (OleDbCommand command = new OleDbCommand(sql, con.GetConexao()))
                {
                    OleDbDataReader objReader = command.ExecuteReader();
                    while (objReader.Read())
                    {
                        lista.Add(new ItemEntadaMat
                        {

                            data = Convert.ToDateTime(objReader["data"].ToString()),
                            identrada = Convert.ToInt16(objReader["identrada"].ToString()),
                            nf = objReader["nf"].ToString(),
                            preco = Convert.ToDecimal(objReader["preco_compra"].ToString()),
                            qtde = Convert.ToDecimal(objReader["quantidade"].ToString()),
                            prod =
                                new Produto
                                {
                                    idprod = Convert.ToInt16(objReader["idprod"].ToString()),
                                    descricao = objReader["descricao"].ToString()
                                }


                        });
                    }
                }
            }

            return lista;
        }

        public List<ItemEntadaMat> RetornarID()
        {
            List<ItemEntadaMat> lista = new List<ItemEntadaMat>();

            using (Conexao con = new Conexao())
            {
                string sql = "select e.identrada,e.data,e.nf,i.idprod,p.descricao,i.quantidade,i.preco_compra from entradamat e ,itementradamat i,produto p where e.identrada = i.identrada and p.idprod = i.idprod and e.identrada=" + identrada ;
                using (OleDbCommand command = new OleDbCommand(sql, con.GetConexao()))
                {
                    OleDbDataReader objReader = command.ExecuteReader();
                    while (objReader.Read())
                    {
                        lista.Add(new ItemEntadaMat
                        {

                            data = Convert.ToDateTime(objReader["data"].ToString()),
                            identrada = Convert.ToInt16(objReader["identrada"].ToString()),
                            nf = objReader["nf"].ToString(),
                            preco = Convert.ToDecimal(objReader["preco_compra"].ToString()),
                            qtde = Convert.ToDecimal(objReader["quantidade"].ToString()),
                            prod =
                                new Produto
                                {
                                    idprod = Convert.ToInt16(objReader["idprod"].ToString()),
                                    descricao = objReader["descricao"].ToString()
                                }


                        });
                    }
                }
            }

            return lista;
        }

        public void ApagaTodosItensID()
        {
            using (Conexao con = new Conexao())
            {
                string sql = "select e.identrada,e.data,e.nf,i.idprod,p.descricao,i.quantidade,i.preco_compra from entradamat e ,itementradamat i,produto p where e.identrada = i.identrada and p.idprod = i.idprod and e.identrada=" + identrada;
                using (OleDbCommand command = new OleDbCommand(sql, con.GetConexao()))
                {
                    OleDbDataReader objReader = command.ExecuteReader();
                    ItemEntadaMat auxitem;
                    while (objReader.Read())
                    {
                        auxitem = new ItemEntadaMat
                        {

                            data = Convert.ToDateTime(objReader["data"].ToString()),
                            identrada = Convert.ToInt16(objReader["identrada"].ToString()),
                            nf = objReader["nf"].ToString(),
                            preco = Convert.ToDecimal(objReader["preco_compra"].ToString()),
                            qtde = Convert.ToDecimal(objReader["quantidade"].ToString()),
                            prod =
                                new Produto
                                {
                                    idprod = Convert.ToInt16(objReader["idprod"].ToString()),
                                    descricao = objReader["descricao"].ToString()
                                }


                        };
                        auxitem.DeletarItem();
                    }
                }
            }

            
        } 
    }
}
