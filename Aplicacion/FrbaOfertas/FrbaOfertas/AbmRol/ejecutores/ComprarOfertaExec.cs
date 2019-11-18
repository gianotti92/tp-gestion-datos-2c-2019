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
           Form comprarOferta
               = new ComprarOfertaForm1(ServiceDependencies.getOfertaService(), ServiceDependencies.getProveedorService(), ServiceDependencies.getClienteService());
           pantallaACerrar.Close();
           comprarOferta.Show();
           
        }
    }
}