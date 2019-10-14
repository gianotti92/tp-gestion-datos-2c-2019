using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.CrearOferta
{
    public partial class AbmOfertasForm : Form
    {
        public AbmOfertasForm()
        {
            InitializeComponent();
        }

        private void crearOfertaBtn_Click(object sender, EventArgs e)
        {
            AltaOfertaForm altaOfertaForm = new AltaOfertaForm();
            this.Hide();
            altaOfertaForm.Show();
        }
    }
}
