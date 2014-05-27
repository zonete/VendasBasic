using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendas
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            String local = Assembly.GetExecutingAssembly().Location;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormEntradaMatcs());
            StaticClasss.Userconectado = new BD.Usuario();
            //Application.Run(new FormVendas());
            FrmLogin objLogin = new FrmLogin();
            if (objLogin.ShowDialog() == DialogResult.OK)
            {
                //Application.Run(new FrmCadUsuario());
                //Application.Run(new FormEntradaMatcs());
                Application.Run(new Form1());
            }
                                                    
        }
    }
}
