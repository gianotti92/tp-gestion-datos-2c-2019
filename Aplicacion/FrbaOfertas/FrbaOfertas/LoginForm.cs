using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FrbaOfertas.AbmRol;
using FrbaOfertas.Entities;
using FrbaOfertas.Service;

namespace FrbaOfertas
{
    public partial class LoginForm : Form
    {
        private UsuarioLoginService usuarioLoginService;
        private FuncionalidadPorRolService funcionalidadPorRolService;

        public LoginForm(UsuarioLoginService usuarioLoginService, FuncionalidadPorRolService funcionalidadPorRolService)
        {
            this.usuarioLoginService = usuarioLoginService;
            this.funcionalidadPorRolService = funcionalidadPorRolService;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = nameTxt.Text;
            string contrasena = contrasenaTxt.Text;

            if (usuarioLoginService.esUsuarioValido(usuario, contrasena))
            {
                usuarioLoginService.limpiarReintentos(usuario);
                List<Rol> roles = funcionalidadPorRolService.searchRoles(usuario);
                List<Funcionalidad> funcionalidades = funcionalidadPorRolService.searchFuncionalidades(roles);
                abrirPantallaBotonesPorRoles(funcionalidades);
            }
            else
            {
                usuarioLoginService.agregarReintento(usuario);
                //MOSTRAR POP UP DICIENDO QUE NO SE PUDO INICIALIZAR
            }
        }

        private void abrirPantallaBotonesPorRoles(List<Funcionalidad> funcionalidades)
        {

            Form botonesPorRoles = new Form1(funcionalidades);
            botonesPorRoles.Show();
            this.Hide();
        }
    }
}