using System;
using System.Windows.Forms;
using FrbaOfertas.AbmRol.ejecutores;

namespace FrbaOfertas.AbmRol
{
    public class AbmRolExec : BotonFuncionalidadAEjecutar
    {
        string nombreParaMostrar { get; set; }

        public AbmRolExec(string nombreParaMostrar, Form formToClose)
        {
            this.nombreParaMostrar = nombreParaMostrar;
            this.formToClose = formToClose;
        }

        public override void execute(object sender, EventArgs e)
        {    this.formToClose.Hide();
            MenuRolForm rolMenu = new MenuRolForm();
            rolMenu.Show();
        }
    }
}