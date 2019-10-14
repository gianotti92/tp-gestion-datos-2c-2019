using FrbaOfertas.Entities;
using FrbaOfertas.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.AbmUsuario
{
    public partial class ABMUsuarioForm : Form
    {
        private UsuarioService UsuarioService { get { return ServiceDependencies.GetUsuarioService(); } }

        public ABMUsuarioForm()
        {
            InitializeComponent();
            cargarUsuarios();
        }

        private void cargarUsuarios()
        {
            List<Usuario> usuarios = UsuarioService.GetAll();
            this.dataGridView1.DataSource = new BindingSource(usuarios, null);
        }
    }
}
