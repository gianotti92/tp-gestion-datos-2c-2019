using System.Windows.Forms;
using FrbaOfertas.AbmRol.ejecutores;
using FrbaOfertas.Entities;

namespace FrbaOfertas.AbmRol
{
    public class EjecutorFactory
    {
        public static BotonFuncionalidadAEjecutar create(Funcionalidad funcionalidad, Form formToClose)
        {
            if (funcionalidad.id == 1)
            {
                return new LoginYSeguridadExec(funcionalidad.nombre);
            }
            else if (funcionalidad.id == 2)
            {
                return new AbmRolExec(funcionalidad.nombre, formToClose);
            }
            else if (funcionalidad.id == 3)
            {
                return new RegistoDeUsuarioExec(funcionalidad.nombre);
            }
            else if (funcionalidad.id == 4)
            {
                return new AbmClienteExec(funcionalidad.nombre, formToClose);
            }
            else if (funcionalidad.id == 5)
            {
                return new AbmProovedorExec(funcionalidad.nombre);
            }
            else if (funcionalidad.id == 6)
            {
                return new CargaCreditoExec(funcionalidad.nombre);
            }
            else if (funcionalidad.id == 7)
            {
                return new ComprarOfertaExec(funcionalidad.nombre);
            }
            else if (funcionalidad.id == 8)
            {
                return new ConfeccionYPublicacionOfertasExec(funcionalidad.nombre);
            }
            else if (funcionalidad.id == 9)
            {
                return new FacturacionAProveedorExec(funcionalidad.nombre);
            }
            else if (funcionalidad.id == 10)
            {
                return new ListadoEstadisticoExec(funcionalidad.nombre);
            }
            else
            {
                return null;
            }
        }
    }
}