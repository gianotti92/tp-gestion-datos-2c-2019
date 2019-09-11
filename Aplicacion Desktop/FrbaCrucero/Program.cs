using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaCrucero.Service;
using FrbaCrucero.Repository;

namespace FrbaCrucero
{ 
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SavePersonDao savePersonDao = new SavePersonDao();
            SavePersonServiceImpl savePersonService = new SavePersonServiceImpl(savePersonDao);
            Application.Run(new Form1(savePersonService));
        }
    }
}
