using System;
using FrbaOfertas.AbmRol.ejecutores;

namespace FrbaOfertas.AbmRol
{
    public class AbmRolExec : BotonFuncionalidadAEjecutar
    {
        string nombreParaMostrar { get; set; }

        public AbmRolExec(string nombreParaMostrar)
        {
            this.nombreParaMostrar = nombreParaMostrar;
        }

        public override void execute(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}