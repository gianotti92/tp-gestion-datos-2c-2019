using FrbaOfertas.AbmRol.ejecutores;

namespace FrbaOfertas.AbmRol
{
    public class EjecutorFactory
    {
        public static BotonFuncionalidadAEjecutar create(string nombreFuncionalidad)
        {
            if (nombreFuncionalidad.Equals("pepe"))
            {
                return new AbmClienteExec();
            }
            else
            {
                return new AbmProovedorExec();
            }
            
            //TODO: completar el factory y buscar en google uno como la gente
            //TODO tambien revisar el tema de los servicios como singleton
        }
    }
}