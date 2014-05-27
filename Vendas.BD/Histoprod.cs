using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.BD
{
    public class Histoprod
    {
        public int idprod { get; set; }
        public int tipo { get; set; }
        public DateTime data { get; set; }
        public Decimal quantidade { get; set; }
        public Decimal saldo { get;private set; }
        public Decimal SaldoAnt  { get;private set; }
        public String  documento { get; set; }
        /*1-inic ;2 - Req;3-NF;4-Canc;5-Ajust, 12 ajust(-) ,13 ajust(+)*/

        private void Gravar()
        {
            try
            {
                using (Conexao con = new Conexao())
                {
                    String sql =
                        "insert into histprod(idprod,tipo,data,quantidade,saldo_atual,saldo_anterior,documento) values (@idprod,@tipo,@data,@quantidade,@saldo_atual,@saldo_anterior,@documento)";
                    using (OleDbCommand com = new OleDbCommand(sql, con.GetConexao()))
                    {
                        com.Parameters.AddWithValue("@idprod", idprod);
                        com.Parameters.AddWithValue("@tipo", tipo);
                        com.Parameters.AddWithValue("@data", data.ToString("yyyy-MM-dd HH:mm:ss"));
                        com.Parameters.AddWithValue("@quantidade",quantidade);
                        com.Parameters.AddWithValue("@saldo_atual", saldo);
                        com.Parameters.AddWithValue("@saldo_anterior", SaldoAnt);
                        com.Parameters.AddWithValue("@documento", documento);
                        com.ExecuteNonQuery();
                    }
                    con.cLose();
                    if (VerificaSeExisteRegDepois())
                    {
                        Histoprod hh = new Histoprod();
                        hh = RegDepoisHistoprod();
                        hh.Altera();

                    }

                }
            }
            catch (Exception)
            {
                throw;
            }

        }
        public void InserirHistNF()
        {
            try
            {
                tipo = 3;
                Histoprod histAnt = new Histoprod();
                histAnt = Anterior();
                SaldoAnt = histAnt.saldo;
                saldo = histAnt.saldo + quantidade;
                Gravar();
            }
            catch (Exception)
            {
                throw;
            }

        }
        public void InserirAjustePositivo()
        {
            try
            {
                tipo = 13;
                Histoprod histAnt = new Histoprod();
                histAnt = Anterior();
                SaldoAnt = histAnt.saldo;
                saldo = histAnt.saldo + quantidade;
                Gravar();
            }
            catch (Exception)
            {
                throw;
            }

        }
        public void InserirAjusteNegativo()
        {
            try
            {
                tipo = 12;
                Histoprod histAnt = new Histoprod();
                histAnt = Anterior();
                SaldoAnt = histAnt.saldo;
                saldo = histAnt.saldo - quantidade;
                Gravar();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void InserirHistReq()
        {
            try
            {
                tipo = 2;
                Histoprod histAnt = new Histoprod();
                histAnt = Anterior();
                SaldoAnt = histAnt.saldo;
                saldo = histAnt.saldo - quantidade;
                Gravar();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void InserirHistIni()
        {
            try
            {
                tipo = 1;
                documento = "0";
                SaldoAnt = 0;
                saldo = quantidade;
                Gravar();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public bool VerificaSeExisteRegDepois()
        {
            using (Conexao con = new Conexao())
            {
                String sql = "select count(1) from histprod where idprod=@id and data > @data";
                using (OleDbCommand com = new OleDbCommand(sql, con.GetConexao()))
                {
                    com.Parameters.AddWithValue("@idprod", idprod);
                    com.Parameters.AddWithValue("@data", data.ToString("yyyy-MM-dd HH:mm:ss"));
                    OleDbDataReader dtReader = com.ExecuteReader();

                    dtReader.Read();
                    if (Convert.ToInt16(dtReader[0].ToString()) > 0)
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

        public Histoprod RegDepoisHistoprod()
        {
            Histoprod hist = new Histoprod();
            using (Conexao con = new Conexao())
            {
                String sql = "select h.idprod,h.tipo,h.data,h.quantidade,h.saldo_atual,h.saldo_anterior,h.documento from histprod h where h.idprod=@idprod" +
                    " and h.data = (select min(hh.data) from histprod hh where hh.idprod=h.idprod and hh.data > @data)";
                using (OleDbCommand command = new OleDbCommand(sql, con.GetConexao()))
                {
                    command.Parameters.AddWithValue("@data", data.ToString("yyyy-MM-dd HH:mm:ss"));
                    command.Parameters.AddWithValue("@idprod", idprod);
                    
                    OleDbDataReader dtReader = command.ExecuteReader();
                    dtReader.Read();
                    if (dtReader.HasRows)
                    {
                        
                        hist.SaldoAnt = Convert.ToDecimal(dtReader["saldo_anterior"].ToString());
                        hist.quantidade = Convert.ToDecimal(dtReader["quantidade"].ToString());
                        hist.saldo = Convert.ToDecimal(dtReader["saldo_atual"].ToString());
                        hist.data = Convert.ToDateTime(dtReader["data"].ToString());
                        hist.documento = dtReader["documento"].ToString();
                        hist.idprod = Convert.ToInt16(dtReader["idprod"].ToString());
                        hist.tipo = Convert.ToInt16(dtReader["tipo"].ToString());
                    }
                    else
                    {
                        hist.idprod = -1;
                    }
                }
            }
            return hist;
        }

        public void Altera()
        {
            using (Conexao con = new Conexao())
            {
                Histoprod h = new Histoprod();
                h =  Anterior();
              String  sql =
                    "update histprod set quantidade = @quantidade,saldo_atual=@saldo_atual,saldo_anterior=@saldo_anterior where idprod=@id and tipo=@tipo and data=@data and documento= @documento";
                using (OleDbCommand com = new OleDbCommand(sql, con.GetConexao()))
                {
                    if (h.idprod >= 0)
                    {
                        SaldoAnt = h.saldo;
                    }
                    else
                    {
                        SaldoAnt = 0;
                    }

                    if ((tipo == 1) || (tipo == 3) || (tipo == 13))
                    {
                        saldo = SaldoAnt + quantidade;
                    }
                    else
                    {
                        saldo = SaldoAnt - quantidade;
                    }
                    com.Parameters.AddWithValue("@quantidade", quantidade.ToString().Replace(".", ","));
                    com.Parameters.AddWithValue("@saldo_atual", saldo.ToString().Replace(".", ","));
                    com.Parameters.AddWithValue("@saldo_anterior", SaldoAnt.ToString().Replace(".", ","));
                    
                    com.Parameters.AddWithValue("@idprod", idprod);
                    com.Parameters.AddWithValue("@tipo", tipo);
                    com.Parameters.AddWithValue("@data", data.ToString("yyyy-MM-dd HH:mm:ss"));                    
                    com.Parameters.AddWithValue("@documento", documento);
                    com.ExecuteNonQuery();
                }
                con.cLose();
                if (VerificaSeExisteRegDepois())
                {
                    Histoprod hh = new Histoprod();
                    hh = RegDepoisHistoprod();
                    hh.Altera();

                }
                
            }
        }

        public void Deleta()
            {
                try
                {
                    Histoprod h = new Histoprod();
                    if (VerificaSeExisteRegDepois())
                    {
                        
                        h = Anterior();
                    }
                    using (Conexao con = new Conexao())
                    {
                        String sql =
                            "delete from histprod where idprod=@id and data=@data and tipo=@tipo and documento= @documento";
                        using (OleDbCommand com = new OleDbCommand(sql, con.GetConexao()))
                        {
                            com.Parameters.AddWithValue("@idprod", idprod);
                            com.Parameters.AddWithValue("@data", data.ToString("yyyy-MM-dd HH:mm:ss"));
                            com.Parameters.AddWithValue("@tipo", tipo);
                            com.Parameters.AddWithValue("@documento", documento);
                            com.ExecuteNonQuery();
                        }

                    }
                    if (h.documento != null)
                    {
                        h.Altera();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }

    

        private Histoprod Anterior()
        {
            Histoprod hist = new Histoprod();
            using (Conexao conexao = new Conexao())
            {
                string sql =
                    "select h.idprod,h.tipo,h.data,h.quantidade,h.saldo_atual,h.saldo_anterior,h.documento from histprod h where h.idprod=@idprod" +
                    " and h.data = (select max(hh.data) from histprod hh where hh.idprod=h.idprod and hh.data < @data) ";
                using (OleDbCommand command = new OleDbCommand(sql, conexao.GetConexao()))
                {
                    command.Parameters.AddWithValue("@data", data.ToString("yyyy-MM-dd HH:mm:ss"));
                    command.Parameters.AddWithValue("@idprod", idprod);
                    
                    OleDbDataReader dtReader = command.ExecuteReader();
                    dtReader.Read();
                    if (dtReader.HasRows)
                    {
                        hist.SaldoAnt = Convert.ToDecimal(dtReader["saldo_anterior"].ToString());
                        hist.quantidade = Convert.ToDecimal(dtReader["quantidade"].ToString());
                        hist.saldo = Convert.ToDecimal(dtReader["saldo_atual"].ToString());
                        hist.data = Convert.ToDateTime(dtReader["data"].ToString());
                        hist.documento = dtReader["documento"].ToString();
                        hist.idprod = Convert.ToInt16(dtReader["idprod"].ToString());
                        hist.tipo = Convert.ToInt16(dtReader["tipo"].ToString());
                    }
                    else
                    {
                        hist.idprod = -1;
                    }
                }
            }

            return hist;
        }

    }
}
