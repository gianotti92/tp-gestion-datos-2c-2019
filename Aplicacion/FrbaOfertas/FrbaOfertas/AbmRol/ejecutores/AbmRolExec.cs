using System;
using System.Windows.Forms;
using FrbaOfertas.AbmRol.ejecutores;

namespace FrbaOfertas.AbmRol
{
    public class AbmRolExec : BotonFuncionalidadAEjecutar
    {
        public AbmRolExec(string nombreParaMostrar, Form pantallaACerrar)
        {
            this.nombreParaMostrar = nombreParaMostrar;
            this.pantallaACerrar = pantallaACerrar;
        }

        public override void execute(object sender, EventArgs e)
        {
           pantallaACerrar.Hide();
           Form abmRol = new AbmRolMenuForm();
           abmRol.Show();
        }
    }
}