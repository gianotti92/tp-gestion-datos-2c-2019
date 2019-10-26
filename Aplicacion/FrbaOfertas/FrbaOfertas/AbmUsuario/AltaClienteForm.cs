using System.Windows.Forms;
using FrbaOfertas.Entities;

namespace FrbaOfertas.AbmUsuario
{
    public partial class AltaClienteForm : Form
    {
        private Usuario usuario;
        public AltaClienteForm(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }
    }
}