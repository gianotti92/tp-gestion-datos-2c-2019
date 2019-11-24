using System;
using System.Windows.Forms;
using FrbaOfertas.Dao;
using FrbaOfertas.Entities;
using FrbaOfertas.Service;

namespace FrbaOfertas.AbmUsuario
{
    public partial class AltaClienteForm : Form
    {
        private string nombre;
        private string apellido;
        private string dni;
        private string mail;
        private string telefono;
        private string fechaNac;
        private string calle;
        private string nro;
        private string piso;
        private string dpto;
        private string codigoPostal;
        private string localidad;

        private RolService RolService
        {
            get { return ServiceDependencies.GetRolService(); }
        }

        private UsuarioService usuarioService
        {
            get { return ServiceDependencies.GetUsuarioService(); }
        }

        private DireccionService direccionService
        {
            get { return ServiceDependencies.getDireccionService(); }
        }

        private ClienteService clienteService
        {
            get { return ServiceDependencies.getClienteService(); }
        }

        private Cliente cliente;

        private Usuario usuario;

        public AltaClienteForm(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

        private bool camposValidos()
        {
            nombre = nombreTxt.Text;
            apellido = apellidotxt.Text;
            dni = dniTxt.Text;
            mail = mailTxt.Text;
            telefono = telefonoTxt.Text;
            fechaNac = fechaNacPicker1.Text;
            calle = calleTxt.Text;
            nro = nroTxt.Text;
            piso = pisoTxt.Text;
            dpto = dptotxt.Text;
            codigoPostal = codigoPostaltxt.Text;
            localidad = localidadTxt.Text;

            bool esNumero = true;
            try
            {
                Convert.ToInt32(telefonoTxt.Text);
                Convert.ToInt32(dniTxt.Text);
            }
            catch (Exception e)
            {
                esNumero = false;
            }


            return !string.IsNullOrEmpty(nombre)  && !string.IsNullOrEmpty(dni) && !string.IsNullOrEmpty(mail) && string.IsNullOrEmpty(telefono)
                   && !string.IsNullOrEmpty(fechaNac) && !string.IsNullOrEmpty(calle) && !string.IsNullOrEmpty(nro) && !string.IsNullOrEmpty(piso) && !string.IsNullOrEmpty(dpto) 
                   && !string.IsNullOrEmpty(codigoPostal) && !string.IsNullOrEmpty(localidad) && !string.IsNullOrEmpty(apellido) || esNumero;
        }

        private void crearUsuario()
        {
            cliente = new Cliente();

            cliente.nombre = nombreTxt.Text;
            cliente.apellido = apellidotxt.Text;
            cliente.dni = Convert.ToInt32(dniTxt.Text);
            cliente.mail = mailTxt.Text;
            cliente.telefono = Convert.ToInt32(telefonoTxt.Text);
            cliente.fechaNac = fechaNacPicker1.Text;

            Direccion direccion = new Direccion();

            direccion.calle = calleTxt.Text;
            direccion.nro = nroTxt.Text;
            direccion.piso = pisoTxt.Text;
            direccion.depto = dptotxt.Text;
            direccion.localidad = localidadTxt.Text;

            int postalCodeId = direccionService.createCodigoPostal(codigoPostal);
            direccion.codigoPostal = postalCodeId;
            direccion = direccionService.CreateDireccion(direccion);
            cliente.direccion = direccion;

            usuarioService.CreateUsuario(usuario);

            cliente.usuario = usuario.userName;

            clienteService.createCliente(cliente);
        }

        private void creatBtn_Click(object sender, EventArgs e)
        {
            if (camposValidos())
            {
                crearUsuario();
                MessageBox.Show("Usuario creado correctamente\n logueate con tu user y pass");
                this.Dispose();
                
                Form1 f = new Form1(
                    new UsuarioLoginService(new FuncionalidadService(new FuncionalidadDao()),
                        new RolService(new RolDao()), new UsuarioService(new UsuarioDao())),
                    new FuncionalidadPorRolService(new RolService(new RolDao()),
                        new FuncionalidadService(new FuncionalidadDao())));
                
                f.Show();
            }
            else
            {
                MessageBox.Show("Hay campos con datos incorrectos");
            }
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            ABMUsuarioAltaForm altaUsuario = new ABMUsuarioAltaForm(false,null, null);
            this.Dispose();
            altaUsuario.Show();
        }
    }
}