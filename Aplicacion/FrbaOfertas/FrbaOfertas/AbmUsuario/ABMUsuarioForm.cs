using FrbaOfertas.Entities;
using FrbaOfertas.Service;
using FrbaOfertas.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FrbaOfertas.AbmRol;

namespace FrbaOfertas.AbmUsuario
{
    public partial class ABMUsuarioForm : Form
    {
        private UsuarioService UsuarioService { get { return ServiceDependencies.GetUsuarioService(); } }

        public ABMUsuarioForm()
        {
            InitializeComponent();
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            List<Usuario> usuarios = UsuarioService.GetAll();
            this.dataGridView1.DataSource = new BindingSource(usuarios, null);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABMUsuarioAltaForm abmUsuarioAltaForm = new ABMUsuarioAltaForm();
            abmUsuarioAltaForm.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            SeleccionarFuncionalidadForm1 seleccionFuncionalidad = new SeleccionarFuncionalidadForm1(FuncionalidadUtil.Funcionalidades);
            seleccionFuncionalidad.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Usuario usuario = (Usuario)dataGridView1.CurrentRow.DataBoundItem;
                this.Hide();
                ABMUsuarioEditarForm form = new ABMUsuarioEditarForm(usuario);
                form.Show();
            }
            else if (e.ColumnIndex == 1)
            {
                Usuario usuario = (Usuario)dataGridView1.CurrentRow.DataBoundItem;
                UsuarioService.DeleteUsuario(usuario);
                CargarUsuarios();
            }
        }

        
    }
}
