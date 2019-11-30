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
        private Boolean isFromLogin;
        private Form proveedorForm;
        private Form clienteForm;
        private RolService rolService { get { return ServiceDependencies.GetRolService(); } }
        private UsuarioService UsuarioService { get { return ServiceDependencies.GetUsuarioService(); } }
        private List<Rol> roles;
        private List<Rol> rolesSeleccionados;


        public ABMUsuarioAltaForm(Boolean isFromLogin, AbmCliente.Form1 abmClienteForm, AbmProveedor.Form1 abmProveedorForm)
        {
            this.isFromLogin = isFromLogin;
            this.clienteForm = abmClienteForm;
            this.proveedorForm = abmProveedorForm;
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            CargarTiposUsuario();
        }

        private void CargarTiposUsuario()
        {
            cbTipoUsuario.Items.Add("Seleccionar");
            cbTipoUsuario.Items.Add(TipoUsuario.CLIENTE.ToString());
            cbTipoUsuario.Items.Add(TipoUsuario.PROVEEDOR.ToString());
            cbTipoUsuario.SelectedItem = "Seleccionar";
        }


        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            cbTipoUsuario.SelectedItem = "Seleccionar";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (isFromLogin)
            {
                Form1 login = new Form1(ServiceDependencies.getUsuarioLoginService(), ServiceDependencies.getFuncionalidadPorRolService());
                this.Dispose();
                login.Show();
            }
            else if (clienteForm == null && proveedorForm == null)
            {
                 Volver();
            }
            else if(clienteForm != null)
            {
                clienteForm = new AbmCliente.Form1(ServiceDependencies.getClienteService());
                this.Hide();
                clienteForm.Show();
            }
            else if (proveedorForm != null)
            {
                proveedorForm = new AbmProveedor.Form1(ServiceDependencies.getProveedorService());
                this.Hide();
                proveedorForm.Show();
            }


        }

        private void Volver()
        {
            this.Hide();
            ABMUsuarioForm abmUsuarioForm = new ABMUsuarioForm();
            abmUsuarioForm.Show();
        }
        

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (EsUsuarioValido())
            {
                roles = rolService.searchRoles().Where(r => r.activo).ToList();
                Usuario usuario = new Usuario();
                usuario.userName = txtUsername.Text;
                usuario.contrasena = txtPassword.Text;
                usuario.tipoUsuario = (TipoUsuario)(Convert.ToInt32(cbTipoUsuario.SelectedIndex));

                if (usuario.tipoUsuario == TipoUsuario.CLIENTE)
                {
                    usuario.roles = roles.Where(r => r.nombre.Equals("Cliente")).ToList();

                    if (usuario.roles.Count <= 0)
                    {
                        MessageBox.Show("El rol cliente no esta habilitado");
                        return;
                    }

                    AltaClienteForm clienteForm = new AltaClienteForm(isFromLogin,usuario);
                    clienteForm.Show();
                    this.Dispose();
                }
                else if (usuario.tipoUsuario == TipoUsuario.PROVEEDOR)
                {
                    usuario.roles = roles.Where(r => r.nombre.Equals("Proveedor")).ToList();
                   
                    if (usuario.roles.Count <= 0)
                    {
                        MessageBox.Show("El rol proveedor no esta habilitado");
                        return;
                    }
                    
                    AltaProovedorForm altaProovedorForm = new AltaProovedorForm(isFromLogin,usuario);
                    altaProovedorForm.Show();
                    this.Dispose();
                }
                else
                {
                    throw new Exception("Mal seleccion de tipo usuario");
                }

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
            
            Usuario usuario = UsuarioService.searchUsuario(txtUsername.Text);
            if (usuario != null)
            {
                MessageBox.Show("El usuario ingresado ya existe");
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
            

            return esValido;
        }

    }
}
