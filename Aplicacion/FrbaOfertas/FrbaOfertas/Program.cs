using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.Dao;
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
            FuncionalidadService funcionalidadService = new FuncionalidadService(new FuncionalidadDao());
            RolService rolService = new RolService(new RolDao());
            UsuarioService usuarioService = new UsuarioService(new UsuarioDao());
            UsuarioLoginService usuarioLoginService = new UsuarioLoginService(funcionalidadService, rolService, usuarioService);
            
            FuncionalidadPorRolService funcionalidadPorRolService =
                new FuncionalidadPorRolService(rolService, funcionalidadService);
            
            
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login(usuarioLoginService, funcionalidadPorRolService));
        }
    }
}
