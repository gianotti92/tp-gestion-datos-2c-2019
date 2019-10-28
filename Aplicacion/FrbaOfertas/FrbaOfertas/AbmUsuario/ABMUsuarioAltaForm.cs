﻿using FrbaOfertas.Entities;
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
        private RolService rolService { get { return ServiceDependencies.GetRolService(); } }
        private UsuarioService UsuarioService { get { return ServiceDependencies.GetUsuarioService(); } }
        private List<Rol> roles;


        public ABMUsuarioAltaForm()
        {
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
            Volver();
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
                roles = rolService.searchRoles();
                Usuario usuario = new Usuario(true, 0, new List<Rol>());
                usuario.userName = txtUsername.Text;
                usuario.contrasena = txtPassword.Text;
                usuario.tipoUsuario = (TipoUsuario)(Convert.ToInt32(cbTipoUsuario.SelectedIndex-1));

                if (usuario.tipoUsuario == TipoUsuario.CLIENTE)
                {
                    usuario.roles.Add(roles.Find(rol => rol.nombre.Equals("Cliente")));
                    AltaClienteForm clienteForm = new AltaClienteForm(usuario);
                    clienteForm.Show();
                    this.Dispose();
                }
                else if (usuario.tipoUsuario == TipoUsuario.PROVEEDOR)
                {
                    usuario.roles.Add(roles.Find(rol => rol.nombre.Equals("Proveedor")));
                    AltaProovedorForm altaProovedorForm = new AltaProovedorForm(usuario);
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
