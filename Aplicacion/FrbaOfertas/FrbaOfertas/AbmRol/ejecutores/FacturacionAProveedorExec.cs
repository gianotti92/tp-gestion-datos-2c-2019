using System;

namespace FrbaOfertas.AbmRol.ejecutores
{
    public class FacturacionAProveedorExec : BotonFuncionalidadAEjecutar
    {
        public FacturacionAProveedorExec(string nombreParaMostrar)
        {
            base.nombreParaMostrar = nombreParaMostrar;
        }

        public override void execute(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}