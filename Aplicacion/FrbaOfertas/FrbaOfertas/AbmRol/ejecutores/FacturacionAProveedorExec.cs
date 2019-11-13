using System;
using System.Windows.Forms;
using FrbaOfertas.Facturar;
using FrbaOfertas.Service;

namespace FrbaOfertas.AbmRol.ejecutores
{
    public class FacturacionAProveedorExec : BotonFuncionalidadAEjecutar
    {
        public FacturacionAProveedorExec(string nombreParaMostrar, Form pantallaACerrar)
        {
            base.nombreParaMostrar = nombreParaMostrar;
            base.pantallaACerrar = pantallaACerrar;
        }

        public override void execute(object sender, EventArgs e)
        {
            FacturarProveedorForm1 form = new FacturarProveedorForm1(ServiceDependencies.getProveedorService(),
                ServiceDependencies.getOfertaService(), ServiceDependencies.getFacturaService());
            pantallaACerrar.Hide();
            form.Show();
        }
    }
}