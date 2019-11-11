using System;
using System.Windows.Forms;
using FrbaOfertas.ComprarOferta;
using FrbaOfertas.Service;

namespace FrbaOfertas.AbmRol.ejecutores
{
    public class ComprarOfertaExec : BotonFuncionalidadAEjecutar
    {
        public ComprarOfertaExec(string nombreParaMostrar, Form formToClose)
        {
            base.nombreParaMostrar = nombreParaMostrar;
            base.pantallaACerrar = formToClose;
        }

        public override void execute(object sender, EventArgs e)
        {
           Form comprarOferta = new ComprarOfertaForm(ServiceDependencies.getOfertaService(), ServiceDependencies.getProveedorService());
           pantallaACerrar.Close();
           comprarOferta.Show();
           
        }
    }
}