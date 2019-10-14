using System;
using System.Windows.Forms;
using FrbaOfertas.CrearOferta;

namespace FrbaOfertas.AbmRol.ejecutores
{
    public class ConfeccionYPublicacionOfertasExec : BotonFuncionalidadAEjecutar
    {
        public ConfeccionYPublicacionOfertasExec(string nombreParaMostrar, Form pantallaACerrar)
        {
            base.nombreParaMostrar = nombreParaMostrar;
            base.pantallaACerrar = pantallaACerrar;
        }

        public override void execute(object sender, EventArgs e)
        {
            AbmOfertasForm abmOfertasForm = new AbmOfertasForm();
            abmOfertasForm.Show();
            pantallaACerrar.Hide();
        }
    }
}