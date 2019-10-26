using System;
using System.Windows.Forms;
using FrbaOfertas.Entities;
using FrbaOfertas.Service;

namespace FrbaOfertas.AbmUsuario
{
    public partial class AltaProovedorForm : Form
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
        
        private RolService RolService { get { return ServiceDependencies.GetRolService(); } }
        private UsuarioService UsuarioService { get { return ServiceDependencies.GetUsuarioService(); } }

        private ClienteService clienteService {
            get { return ServiceDependencies.getClienteService(); }
        }

        private Usuario usuario;

        private Cliente cliente;

        public AltaProovedorForm(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

        private void creatBtn_Click(object sender, EventArgs e)
        {
            if (camposValidos())
            {
                crearUsuario();
            }
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

            return nombre != null && dni != null && mail != null && telefono != null && fechaNac != null &&
                   calle != null && nro != null && piso != null && dpto != null && codigoPostal != null &&
                   localidad != null && apellido != null;

        }
        
        private void crearUsuario()
        {
            cliente = new Cliente();
            
            cliente.nombre = nombreTxt.Text;
            cliente.apellido = apellidotxt.Text;
            cliente.dni = dniTxt.Text;
            cliente.mail = mailTxt.Text;
            cliente.telefono = telefonoTxt.Text;
            cliente.fechaNac = fechaNacPicker1.Text;

            Direccion direccion = new Direccion();
           
            direccion.calle = calleTxt.Text;
            direccion.nro = nroTxt.Text;
            direccion.piso = pisoTxt.Text;
            direccion.depto = dptotxt.Text;
            direccion.codigoPostal = codigoPostaltxt.Text;
            direccion.localidad = localidadTxt.Text;
            
            cliente.direccion = direccion;
            
            
            UsuarioService.CreateUsuario(usuario);
            clienteService.createCliente(cliente);
        }
    }
}