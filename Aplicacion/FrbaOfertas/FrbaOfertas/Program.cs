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
            UsuarioRepository usuarioDao = new UsuarioDao();
            UsuarioService usuarioService = new UsuarioService(usuarioDao);

            FuncionalidadDao funcionalidadDao = new FuncionalidadDao();
            FuncionalidadService funcionalidadService = new FuncionalidadService(funcionalidadDao);

            RolDao rolDao = new RolDao();
            RolService rolService = new RolService(rolDao);

            FuncionalidadPorRolService funcionalidadPorRolService =
                new FuncionalidadPorRolService(rolService, funcionalidadService);

            UsuarioLoginService usuarioLoginService =
                new UsuarioLoginService(funcionalidadService, rolService, usuarioService);
            usuarioLoginService = new UsuarioLoginService(funcionalidadService, rolService, usuarioService);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm(usuarioLoginService, funcionalidadPorRolService));
        }
    }
}