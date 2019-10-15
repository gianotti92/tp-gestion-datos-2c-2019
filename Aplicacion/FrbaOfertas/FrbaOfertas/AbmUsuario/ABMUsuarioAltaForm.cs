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
    public partial class ABMUsuarioAltaForm : Form
    {
        private RolService RolService { get { return ServiceDependencies.GetRolService(); } }
        private UsuarioService UsuarioService { get { return ServiceDependencies.GetUsuarioService(); } }
        private List<Rol> roles;
        private List<Rol> rolesSeleccionados;

        public ABMUsuarioAltaForm()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos() 
        {
            rolesSeleccionados = new List<Rol>();
            CargarTiposUsuario();
            CargarRoles();
        }

        private void CargarTiposUsuario()
        {
            cbTipoUsuario.Items.Add("Seleccionar");
            cbTipoUsuario.Items.Add(TipoUsuario.CLIENTE.ToString());
            cbTipoUsuario.Items.Add(TipoUsuario.PROVEEDOR.ToString());
            cbTipoUsuario.SelectedItem = "Seleccionar";
        }

        private void CargarRoles()
        {
            roles = RolService.GetAll();
            cbRol.Items.Add("Seleccionar");
            roles.ForEach(x => cbRol.Items.Add(x.nombre));
            cbRol.SelectedItem = "Seleccionar";
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            cbTipoUsuario.SelectedItem = "Seleccionar";
            cbRol.SelectedItem = "Seleccionar";
            rolesSeleccionados.ForEach(x => lbRoles.Items.Remove(x.nombre));
            rolesSeleccionados.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Volver();
        }

        private void Volver()
        {
            this.Hide();
            ABMUsuarioForm abmUsuarioForm = new ABMUsuarioForm();
            abmUsuarioForm.Show();
        }

        private void btnAgregarRol_Click(object sender, EventArgs e)
        {
            int i = cbRol.SelectedIndex;

            if (rolesSeleccionados.Count == 0)
            {
                if (i > 0)
                {
                    Rol rol = roles[i - 1];
                    lbRoles.Items.Add(rol.nombre);
                    rolesSeleccionados.Add(rol);
                }
            }
        }

        private void btnEliminarRol_Click(object sender, EventArgs e)
        {
            int i = lbRoles.SelectedIndex;

            if (rolesSeleccionados.Count > 0 && i != -1)
            {
                string rolName = lbRoles.Items[i].ToString();
                Rol rol = roles.Find(x => x.nombre == rolName);
                lbRoles.Items.RemoveAt(i);
                rolesSeleccionados.Remove(rol);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (EsUsuarioValido())
            {
                Usuario usuario = new Usuario();
                usuario.userName = txtUsername.Text;
                usuario.contrasena = txtPassword.Text;
                usuario.tipoUsuario = (TipoUsuario)(Convert.ToInt32(cbTipoUsuario.SelectedIndex-1));
                usuario.roles = rolesSeleccionados;

                UsuarioService.CreateUsuario(usuario);

                Volver();
            }
        }

        private bool EsUsuarioValido()
        {
            bool esValido = true;
            int tipoUsuario = Convert.ToInt32(cbTipoUsuario.SelectedIndex);

            if (txtUsername.Text == "")
            {
                MessageBox.Show("Ingrese un username");
                esValido = false;
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Ingrese un password");
                esValido = false;
            }
            else if (tipoUsuario == 0)
            {
                MessageBox.Show("Seleccione un tipo de usuario");
                esValido = false;
            }
            else if (rolesSeleccionados.Count == 0)
            {
                MessageBox.Show("Seleccione un rol");
                esValido = false;
            }

            return esValido;
        }

    }
}
