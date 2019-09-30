using System;

namespace FrbaOfertas.AbmRol.ejecutores
{
    public class ComprarOfertaExec : BotonFuncionalidadAEjecutar
    {
        public ComprarOfertaExec(string nombreParaMostrar)
        {
            base.nombreParaMostrar = nombreParaMostrar;
        }

        public override void execute(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}