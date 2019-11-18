using System;
using System.Windows.Forms;
using FrbaOfertas.ListadoEstadistico;

namespace FrbaOfertas.AbmRol.ejecutores
{
    public class ListadoEstadisticoExec : BotonFuncionalidadAEjecutar
    {

        public ListadoEstadisticoExec(string nombreParaMostrar, Form pantallaACerrar)
        {
            base.nombreParaMostrar = nombreParaMostrar;
            base.pantallaACerrar = pantallaACerrar;
        }

        public override void execute(object sender, EventArgs e)
        {
            ListadoEstadisticoForm listadoEstadisticoForm = new ListadoEstadisticoForm();
            listadoEstadisticoForm.Show();
            pantallaACerrar.Hide();
        }
    }
}