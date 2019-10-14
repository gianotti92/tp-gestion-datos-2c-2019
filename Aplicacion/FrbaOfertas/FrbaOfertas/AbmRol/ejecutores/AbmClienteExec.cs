using System;
using System.Windows.Forms;

namespace FrbaOfertas.AbmRol.ejecutores
{
    public class AbmClienteExec : BotonFuncionalidadAEjecutar
    {
        public AbmClienteExec(string nombreParaMostrar, Form pantallaACerrar)
        {
            base.nombreParaMostrar = nombreParaMostrar;
            base.pantallaACerrar = pantallaACerrar;
        }

        public override void execute(object sender, EventArgs e)
        {
            pantallaACerrar.Hide();
            AbmCliente.Form1 abmClientes = new AbmCliente.Form1();
            abmClientes.Show();
            
        }
    }
}