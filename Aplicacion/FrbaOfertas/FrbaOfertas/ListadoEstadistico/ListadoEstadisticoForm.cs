using System;
using System.Windows.Forms;
using FrbaOfertas.AbmRol;
using FrbaOfertas.Service;
using FrbaOfertas.Utils;

namespace FrbaOfertas.ListadoEstadistico
{
    public partial class ListadoEstadisticoForm : Form
    {
        public ListadoEstadisticoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            //TopCincoMayorDescuentoForm form = new TopCincoMayorDescuentoForm(ServiceDependencies.getOfertaService());
            //form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           //this.Hide();
           //TopCincoRecaudacionForm form = new TopCincoRecaudacionForm();
           //form.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SeleccionarFuncionalidadForm1 seleccionFuncionalidad =
                new SeleccionarFuncionalidadForm1(FuncionalidadUtil.Funcionalidades);
            seleccionFuncionalidad.Show();
        }
    }
}
