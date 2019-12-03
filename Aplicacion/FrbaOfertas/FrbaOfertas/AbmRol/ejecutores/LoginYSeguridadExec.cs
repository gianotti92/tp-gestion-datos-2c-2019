using FrbaOfertas.Service;
using FrbaOfertas.ComprarOferta;
using System;
using System.Windows.Forms;

namespace FrbaOfertas.AbmRol.ejecutores
{
    public class LoginYSeguridadExec : BotonFuncionalidadAEjecutar
    {

        public LoginYSeguridadExec(string nombreParaMostrar, Form pantallaACerrar)
        {
            base.nombreParaMostrar = nombreParaMostrar;
            base.pantallaACerrar = pantallaACerrar;
        }

        public override void execute(object sender, EventArgs e)
        {
            pantallaACerrar.Hide();
            Form entregaCupon = new ConsumoOferta.ConsumoOferta(ServiceDependencies.getCompraService(), ServiceDependencies.getOfertaService());
            entregaCupon.Show();
        }
    }
}