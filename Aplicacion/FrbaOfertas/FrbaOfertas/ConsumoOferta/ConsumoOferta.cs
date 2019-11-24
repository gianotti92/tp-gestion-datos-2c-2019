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
        
        private void PrecioTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar que la tecla presionada no sea CTRL u otra tecla no numerica
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten numeros Decimales1", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            // Si deseas, puedes permitir numeros decimales (o float)
            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))


            {

                MessageBox.Show("Solo se permiten numeros Decimales2", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }
    }
}