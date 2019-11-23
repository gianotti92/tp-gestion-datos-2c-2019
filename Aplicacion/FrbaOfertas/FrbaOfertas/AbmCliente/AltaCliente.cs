using System;
using System.Windows.Forms;
using FrbaOfertas.Entities;
using FrbaOfertas.Service;

namespace FrbaOfertas.AbmCliente
{
    public partial class AltaCliente : Form
    {
        private Cliente c;
        private ClienteService _clienteService;
        public AltaCliente(Cliente c, ClienteService clienteService)
        {
            this.c = c;
            this._clienteService = clienteService;
            InitializeComponent();
            llenarCampos();
        }

        private void llenarCampos()
        {
            apellidotxt.Text = c.apellido;
            nombreTxt.Text = c.nombre;
            mailTxt.Text = c.mail;
            dniTxt.Text = c.dni.ToString();
            telefonoTxt.Text = c.telefono.ToString();
            fechaNacPicker1.Value = Convert.ToDateTime(c.fechaNac);

            calleTxt.Text = c.direccion.calle;
            nroTxt.Text = c.direccion.nro;
            dptotxt.Text = c.direccion.depto;
            localidadTxt.Text = c.direccion.localidad;
            codigoPostaltxt.Text = Convert.ToString(c.direccion.codigoPostal);
            
        }

        public AltaCliente()
        {
            InitializeComponent();
        }

        private void creatBtn_Click(object sender, EventArgs e)
        {
            if (c == null)
            {
                Cliente cliente = new Cliente();
                cliente.apellido = apellidotxt.Text;
                cliente.nombre = nombreTxt.Text;
                cliente.mail = mailTxt.Text;
                cliente.dni = Convert.ToInt16(dniTxt.Text);
                cliente.telefono = Convert.ToInt16(telefonoTxt.Text);
                cliente.fechaNac = fechaNacPicker1.Text;

                cliente.direccion.calle = calleTxt.Text;
                cliente.direccion.nro = nroTxt.Text;
                cliente.direccion.depto = dptotxt.Text;
                cliente.direccion.localidad = localidadTxt.Text;
                cliente.direccion.codigoPostal = Convert.ToInt32(codigoPostaltxt.Text);
                
                
                _clienteService.createCliente(cliente);
            }
            else
            {
                c.apellido = apellidotxt.Text;
                c.nombre = nombreTxt.Text;
                c.mail = mailTxt.Text;
                c.dni = Convert.ToInt16(dniTxt.Text);
                c.telefono = Convert.ToInt16(telefonoTxt.Text);
                c.fechaNac = fechaNacPicker1.Text;

                c.direccion.calle = calleTxt.Text ;
                c.direccion.nro = nroTxt.Text ;
                c.direccion.depto = dptotxt.Text;
                c.direccion.localidad = localidadTxt.Text ;
                 c.direccion.codigoPostal = Convert.ToInt16(codigoPostaltxt.Text);
                _clienteService.UpdateCliente(c);
            }
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(ServiceDependencies.getClienteService());
            this.Hide();
            form.Show();
        }
    }
}