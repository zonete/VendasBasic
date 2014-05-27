using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.BD
{
    public class ItemVendas
    {
        public int id { get; set; }
        public Produto prod { get; set; }
        public VendasMat venda { get; set; }
        public Decimal quantidade { get; set; }
        public Decimal preco { get; set; }


        public void InsereItem()
        {
            try
            {
                using (Conexao con = new Conexao())
                {
                    string sql = "insert into itemsaidamat(idvenda,idprod,quantidade,precovenda) values (@idvenda,@idprod,@quantidade,@precovenda)";
                    using (OleDbCommand command = new OleDbCommand(sql, con.GetConexao()))
                    {
                        command.Parameters.AddWithValue("@idvenda", venda.idvenda);
                        command.Parameters.AddWithValue("@idprod", prod.idprod);
                        command.Parameters.AddWithValue("@quantidade", quantidade);
                        command.Parameters.AddWithValue("@precovenda", preco);
                        command.ExecuteNonQuery();
                    }
                    con.cLose();
                }
                Histoprod objHistoprod = new Histoprod();
                objHistoprod.idprod = prod.idprod;
                objHistoprod.documento = venda.idvenda.ToString();
                objHistoprod.quantidade = quantidade;
                objHistoprod.data = venda.datahora;
                objHistoprod.InserirHistReq();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AlterarItem()
        {
            try
            {
                using (Conexao con = new Conexao())
                {
                    string sql = "update itemsaidamat set quantidade=@quantidade,precovenda=@precovenda where idvenda=@id and idprod=@idprod";
                    using (OleDbCommand command = new OleDbCommand(sql, con.GetConexao()))
                    {
                        command.Parameters.AddWithValue("@quantidade", quantidade);
                        command.Parameters.AddWithValue("@precovenda", preco);
                        command.Parameters.AddWithValue("@id", venda.idvenda);
                        command.Parameters.AddWithValue("@idprod", prod.idprod);
                        command.ExecuteNonQuery();
                    }
                }
                Histoprod objHistoprod = new Histoprod();
                objHistoprod.idprod = prod.idprod;
                objHistoprod.documento = venda.idvenda.ToString();
                objHistoprod.quantidade = quantidade;
                objHistoprod.data = venda.datahora;
                objHistoprod.tipo = 2;
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
                objHistoprod.documento = venda.idvenda.ToString();
                objHistoprod.quantidade = quantidade;
                objHistoprod.data = venda.datahora;
                objHistoprod.tipo = 2;
                objHistoprod.Deleta();
                using (Conexao con = new Conexao())
                {
                    string sql = "delete from itemsaidamat where idvenda=@id and idprod=@idprod";
                    using (OleDbCommand command = new OleDbCommand(sql, con.GetConexao()))
                    {
                        command.Parameters.AddWithValue("@id", venda.idvenda);
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


        public List<ItemVendas> Retornar()
        {
            List<ItemVendas> lista = new List<ItemVendas>();

            using (Conexao con = new Conexao())
            {
                string sql = "select  s.idvenda,s.data,s.idcliente,s.idusuario,"+
                            "         p.idprod,p.descricao, "+
                            "         i.precovenda,i.quantidade, "+
                            "         u.login, "+
                            "         c.nome "+
                            " from saidamat s, itemsaidamat i, produto p,usuario u,cliente c  where s.idvenda = i.idvenda and p.idprod = i.idprod and u.idusuario = s.idusuario and c.idcliente = s.idcliente";
                using (OleDbCommand command = new OleDbCommand(sql, con.GetConexao()))
                {
                    OleDbDataReader objReader = command.ExecuteReader();
                    while (objReader.Read())
                    {
                        lista.Add(new ItemVendas
                        {
                            venda = new VendasMat
                            {
                                datahora = Convert.ToDateTime(objReader["data"].ToString()),
                                idvenda = Convert.ToInt16(objReader["idvenda"].ToString()),
                                user = new Usuario {IdUsuario = Convert.ToInt16(objReader["idcliente"].ToString()),Login = objReader["login"].ToString()},
                                cliente = new Cliente{idcliente = Convert.ToInt16(objReader["idcliente"].ToString()),nome = objReader["nome"].ToString()}
                            },
                            preco = Convert.ToDecimal(objReader["precovenda"].ToString()),
                            quantidade = Convert.ToDecimal(objReader["quantidade"].ToString()),
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

        public List<ItemVendas> RetornarID()
        {
            List<ItemVendas> lista = new List<ItemVendas>();

            using (Conexao con = new Conexao())
            {
                string sql = "select  s.idvenda,s.data,s.idcliente,s.idusuario," +
                            "         p.idprod,p.descricao, " +
                            "         i.precovenda,i.quantidade, " +
                            "         u.login, " +
                            "         c.nome " +
                            " from saidamat s, itemsaidamat i, produto p,usuario u,cliente c  where s.idvenda = i.idvenda and p.idprod = i.idprod and u.idusuario = s.idusuario and c.idcliente = s.idcliente and s.idvenda="+venda.idvenda;
                using (OleDbCommand command = new OleDbCommand(sql, con.GetConexao()))
                {
                    OleDbDataReader objReader = command.ExecuteReader();
                    while (objReader.Read())
                    {
                        lista.Add(new ItemVendas
                        {
                            venda = new VendasMat
                            {
                                datahora = Convert.ToDateTime(objReader["data"].ToString()),
                                idvenda = Convert.ToInt16(objReader["idvenda"].ToString()),
                                user = new Usuario { IdUsuario = Convert.ToInt16(objReader["idcliente"].ToString()), Login = objReader["login"].ToString() },
                                cliente = new Cliente { idcliente = Convert.ToInt16(objReader["idcliente"].ToString()), nome = objReader["nome"].ToString() }
                            },
                            preco = Convert.ToDecimal(objReader["precovenda"].ToString()),
                            quantidade = Convert.ToDecimal(objReader["quantidade"].ToString()),
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
                string sql = "select  s.idvenda,s.data,s.idcliente,s.idusuario," +
                            "         p.idprod,p.descricao, " +
                            "         i.precovenda,i.quantidade, " +
                            "         u.login, " +
                            "         c.nome " +
                            " from saidamat s, itemsaidamat i, produto p,usuario u,cliente c  where s.idvenda = i.idvenda and p.idprod = i.idprod and u.idusuario = s.idusuario and c.idcliente = s.idcliente and s.idvenda=" + venda.idvenda;
                using (OleDbCommand command = new OleDbCommand(sql, con.GetConexao()))
                {
                    OleDbDataReader objReader = command.ExecuteReader();
                    if (objReader.Read())
                    {
                        ItemVendas obj = new ItemVendas
                        {
                            venda = new VendasMat
                            {
                                datahora = Convert.ToDateTime(objReader["data"].ToString()),
                                idvenda = Convert.ToInt16(objReader["idvenda"].ToString()),
                                user = new Usuario { IdUsuario = Convert.ToInt16(objReader["idcliente"].ToString()), Login = objReader["login"].ToString() },
                                cliente = new Cliente { idcliente = Convert.ToInt16(objReader["idcliente"].ToString()), nome = objReader["nome"].ToString() }
                            },
                            preco = Convert.ToDecimal(objReader["precovenda"].ToString()),
                            quantidade = Convert.ToDecimal(objReader["quantidade"].ToString()),
                            prod =
                                new Produto
                                {
                                    idprod = Convert.ToInt16(objReader["idprod"].ToString()),
                                    descricao = objReader["descricao"].ToString()
                                }
                        };
                        obj.DeletarItem();
                    }
                }
            }

            
        }
        
    }
}
