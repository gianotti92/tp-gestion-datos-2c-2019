using System;
using System.Windows.Forms;
using FrbaOfertas.Dao;
using FrbaOfertas.ListadoEstadistico;
using FrbaOfertas.Repository;
using FrbaOfertas.Service;

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
            ListadosRepository listadorespo = new ListadosDao();
            ListadoService listadoser = new ListadoService(listadorespo);
            Listados listadoEstadisticoForm = new Listados(listadoser);
            listadoEstadisticoForm.Show();
            pantallaACerrar.Hide();
        }
    }
}