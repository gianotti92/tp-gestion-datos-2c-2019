using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FrbaOfertas.Entities;
using FrbaOfertas.Service;

namespace FrbaOfertas.AbmUsuario
{
    public partial class AltaProovedorForm : Form
    {
        private RolService RolService
        {
            get { return ServiceDependencies.GetRolService(); }
        }

        private UsuarioService UsuarioService
        {
            get { return ServiceDependencies.GetUsuarioService(); }
        }

        private CiudadService ciudadService
        {
            get { return ServiceDependencies.GetCiudadService(); }
        }

        private RubroService rubroService
        {
            get { return ServiceDependencies.getRubroService(); }
        }

        private ClienteService clienteService
        {
            get { return ServiceDependencies.getClienteService(); }
        }

        private ProveedorService proveedorService
        {
            get { return ServiceDependencies.getProveedorService(); }
        }
        
        private DireccionService direccionService
        {
            get { return ServiceDependencies.getDireccionService(); }
        }

        private Usuario usuario;
        private List<Rubro> rubros;
        private List<Ciudad> ciudades;

        public AltaProovedorForm(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
            llenarComboCiudad();
            llenarComboRubro();
        }

        private void llenarComboRubro()
        {
            rubros = rubroService.searcRubros();
            foreach (var r in rubros)
            {
                this.rubroCombo.Items.Add(r.description);
            }
        }

        private void llenarComboCiudad()
        {
            ciudades = ciudadService.searchCiudades();
            foreach (var ciudad in ciudades)
            {
                ciudadCombo.Items.Add(ciudad.descripcion);
            }
        }

        private void creatBtn_Click(object sender, EventArgs e)
        {
            if (camposValidos())
            {
                crearProovedor();
            }
        }

        private bool camposValidos()
        {
            return razonSocialTxt.Text != null && mailTxt.Text != null && cuitTxt.Text != null && telTxt.Text != null &&
                   rubroCombo.SelectedIndex != -1 &&
                   ciudadCombo.SelectedIndex != -1 && calleTxt.Text != null && nroTxt.Text != null &&
                   pisoTxt.Text != null && pisoTxt.Text != null && pisoTxt.Text != null && dptotxt.Text != null &&
                   codigoPostaltxt.Text != null && localidadTxt.Text != null;
        }

        private void crearProovedor()
        {
            Proovedor proovedor = new Proovedor();
            proovedor.razonSocial = razonSocialTxt.Text;
            proovedor.cuit = Convert.ToInt32(cuitTxt.Text);
            proovedor.mail = mailTxt.Text;
            proovedor.mail = mailTxt.Text;
            proovedor.telefono = Convert.ToInt32(telTxt.Text);
            proovedor.contacto = contactotxt.Text;

            int rubroIndex = rubroCombo.SelectedIndex;

            proovedor.rubro = rubros[rubroIndex].id;
            
            Direccion direccion = new Direccion();
            direccion.calle = calleTxt.Text;
            direccion.nro = nroTxt.Text;
            direccion.piso = pisoTxt.Text;
            direccion.depto = dptotxt.Text;
            int ciudadIndex = ciudadCombo.SelectedIndex;
            Ciudad ciudad = ciudades[ciudadIndex];
           
            int postalCodeId = direccionService.createCodigoPostal(codigoPostaltxt.Text);
            direccion.codigoPostal = postalCodeId;
            direccion.localidad = localidadTxt.Text;
            direccion.ciudad = ciudad.id;

            direccionService.CreateDireccion(direccion);

            proovedor.direccion = direccion;
            proovedor.usuario = usuario.userName;
            UsuarioService.CreateUsuario(usuario);
            proveedorService.save(proovedor);
        }
    }
}