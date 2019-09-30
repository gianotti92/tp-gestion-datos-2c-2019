using System;
using FrbaOfertas.AbmRol.ejecutores;

namespace FrbaOfertas.AbmRol
{
    public class RegistoDeUsuarioExec : BotonFuncionalidadAEjecutar
    {
        public RegistoDeUsuarioExec(string nombreParaMostrar)
        {
            base.nombreParaMostrar = nombreParaMostrar;
        }

        public override void execute(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}