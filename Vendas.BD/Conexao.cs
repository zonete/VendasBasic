using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.BD
{
    public class Conexao:IDisposable
    {
        OleDbConnection conn = null;

        public Conexao()
        {
            conn =
                new OleDbConnection(
                    System.Configuration.ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString.ToString());
        }

        public OleDbConnection GetConexao()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            return conn;

        }

        public void cLose()
        {
            conn.Close();
        }

        public void Dispose()
        {
            
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
            }
        }

        public OleDbConnection GetConexao2()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            
            return conn;
        }
    }
}
