using System;
using System.Windows.Forms;

namespace FrbaOfertas.AbmRol.ejecutores
{
    public class AbmClienteExec : BotonFuncionalidadAEjecutar
    {
        public AbmClienteExec(string nombreParaMostrar, Form formToClose)
        {
            base.nombreParaMostrar = nombreParaMostrar;
            base.formToClose = formToClose;
        }

        public override void execute(object sender, EventArgs e)
        {
            formToClose.Hide();
            AbmCliente.Form1 abmClientes = new AbmCliente.Form1();
            abmClientes.Show();
            
        }
    }
}