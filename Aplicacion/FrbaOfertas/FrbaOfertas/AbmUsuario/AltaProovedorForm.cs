using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FrbaOfertas.Dao;
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
        private Boolean isFromLogin;

        public AltaProovedorForm(Boolean isFromLogin, Usuario usuario)
        {
            this.isFromLogin = isFromLogin;
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
                    MessageBox.Show("Usuario proveedor correctamente\n logueate con tu usr y pass");
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

        private bool camposValidos()
        {
            bool esnumero = true;
            try
            {
                Convert.ToInt32(telTxt.Text);
            }
            catch (Exception e)
            {
                esnumero = false;
            }

            return !string.IsNullOrEmpty(razonSocialTxt.Text) && !string.IsNullOrEmpty(mailTxt.Text) && !string.IsNullOrEmpty(cuitTxt.Text)&& !string.IsNullOrEmpty(telTxt.Text)&&
                   rubroCombo.SelectedIndex != -1 &&
                   ciudadCombo.SelectedIndex != -1 && !string.IsNullOrEmpty(calleTxt.Text)&&!string.IsNullOrEmpty(nroTxt.Text)&&
                   !string.IsNullOrEmpty(pisoTxt.Text) && !string.IsNullOrEmpty(pisoTxt.Text)&& !string.IsNullOrEmpty(pisoTxt.Text) && !string.IsNullOrEmpty(dptotxt.Text)&&
                   !string.IsNullOrEmpty(codigoPostaltxt.Text)&& !string.IsNullOrEmpty(localidadTxt.Text) && esnumero;
        }

        private void crearProovedor()
        {
            Proovedor proovedor = new Proovedor();
            proovedor.razonSocial = razonSocialTxt.Text;
            proovedor.cuit = cuitTxt.Text;
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

        private void volverBtn_Click(object sender, EventArgs e)
        {
            ABMUsuarioAltaForm altaUsuario = new ABMUsuarioAltaForm(isFromLogin,null,null);
            this.Dispose();
            altaUsuario.Show();
        }
        
        private void solo_numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar que la tecla presionada no sea CTRL u otra tecla no numerica
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten numeros Enteros ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }
    }
}




