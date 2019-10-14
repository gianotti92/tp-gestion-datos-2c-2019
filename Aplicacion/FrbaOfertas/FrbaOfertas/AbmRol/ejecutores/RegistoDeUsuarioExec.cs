using System;
using FrbaOfertas.AbmRol.ejecutores;
using System.Windows.Forms;

namespace FrbaOfertas.AbmRol
{
    public class RegistoDeUsuarioExec : BotonFuncionalidadAEjecutar
    {
        public RegistoDeUsuarioExec(string nombreParaMostrar, Form pantallaACerrar)
        {
            base.nombreParaMostrar = nombreParaMostrar;
            base.pantallaACerrar = pantallaACerrar;
        }

        public override void execute(object sender, EventArgs e)
        {
            pantallaACerrar.Hide();
            Form abmUsuario = new AbmUsuario.ABMUsuarioForm();
            abmUsuario.Show();
        }
    }
}