using System;
using System.Windows.Forms;

namespace FrbaOfertas.ListadoEstadistico
{
    public partial class TopCincoRecaudacionForm : Form
    {
        public TopCincoRecaudacionForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListadoEstadisticoForm listado = new ListadoEstadisticoForm();
            this.Hide();
            listado.Show();
        }
    }
}