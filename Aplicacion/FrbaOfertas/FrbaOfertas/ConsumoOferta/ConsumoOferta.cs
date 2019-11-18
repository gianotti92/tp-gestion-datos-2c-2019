using System;
using System.Windows.Forms;
using FrbaOfertas.AbmRol;
using FrbaOfertas.Utils;

namespace FrbaOfertas.ConsumoOferta
{
    public partial class ConsumoOferta : Form
    {
        public ConsumoOferta()
        {
            InitializeComponent();
        }

        private void volverBtn1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SeleccionarFuncionalidadForm1 seleccionFuncionalidad =
                new SeleccionarFuncionalidadForm1(FuncionalidadUtil.Funcionalidades);
            seleccionFuncionalidad.Show();
        }
    }
}