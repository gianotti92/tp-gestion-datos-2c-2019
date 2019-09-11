using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.Repository;
using FrbaOfertas.Service;

namespace FrbaOfertas
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LoginDao loginDao = new LoginDao();
            LoginServiceImpl loginServiceImpl = new LoginServiceImpl(loginDao);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(loginServiceImpl));
        }
    }
}
