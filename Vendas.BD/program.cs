using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Vendas.BD
{
    class program
    {
        private static void Main()
        {
            String local = Assembly.GetExecutingAssembly().Location;
            ConfigurationManager.ConnectionStrings.Remove("AccessBD");
            ConfigurationManager.ConnectionStrings.Add(new ConnectionStringSettings("AccessBD", "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + local + "\\BD.accdb"));
        }
    }
}
