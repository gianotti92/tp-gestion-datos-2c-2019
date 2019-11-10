using System;
using System.Windows.Forms;
using FrbaOfertas.CargaCredito;

namespace FrbaOfertas.AbmRol.ejecutores
{
    public class CargaCreditoExec : BotonFuncionalidadAEjecutar
    {
        public CargaCreditoExec(string nombreParaMostrar, Form pantallaACerrar)
        {
            base.nombreParaMostrar = nombreParaMostrar;
            base.pantallaACerrar = pantallaACerrar;
        }

        public override void execute(object sender, EventArgs e)
        {
            pantallaACerrar.Hide();
            CargaCredito.Form1 cargarCredito = new CargaCredito.Form1();
            cargarCredito.Show();
        }
    }
}