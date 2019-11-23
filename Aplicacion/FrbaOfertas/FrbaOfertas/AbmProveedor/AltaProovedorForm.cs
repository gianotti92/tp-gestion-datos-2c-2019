using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FrbaOfertas.Entities;
using FrbaOfertas.Service;

namespace FrbaOfertas.AbmProveedor
{
    public partial class AltaProovedorForm : Form
    {
        private CiudadService ciudadService;
        private RubroService rubroService;
        private DireccionService direccionService;
        private ProveedorService proveedorService;

        private Proovedor proveedor;
        private List<Rubro> rubros;
        private List<Ciudad> ciudades;

        public AltaProovedorForm( CiudadService ciudadService, RubroService rubroService,
            DireccionService direccionService, ProveedorService proveedorService)
        {
            this.proveedorService = proveedorService;
            this.ciudadService = ciudadService;
            this.rubroService = rubroService;
            InitializeComponent();
            cargarComboRubro();
            llenarComboCiudad();

        }
        
        public AltaProovedorForm(Proovedor proveedor, CiudadService ciudadService, RubroService rubroService)
        {
            this.proveedor = proveedor;
            this.rubroService = rubroService;
            InitializeComponent();
            cargarComboRubro(); 
            llenarComboCiudad();
        }

        private void cargarComboRubro()
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
            if (proveedor == null)
            {
                Proovedor p = new Proovedor();
                p.razonSocial = razonSocialTxt.Text;
                p.cuit = cuitTxt.Text;
                p.mail = mailTxt.Text;
                p.mail = mailTxt.Text;
                p.telefono = Convert.ToInt32(telTxt.Text);
                p.contacto = contactotxt.Text;

                int rubroIndex = rubroCombo.SelectedIndex;

                p.rubro = rubros[rubroIndex].id;
            
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

                p.direccion = direccion;
                
                proveedorService.save(p);
            }
            else
            {
                proveedor.razonSocial = razonSocialTxt.Text;
                proveedor.cuit = cuitTxt.Text;
                proveedor.mail = mailTxt.Text;
                proveedor.mail = mailTxt.Text;
                proveedor.telefono = Convert.ToInt32(telTxt.Text);
                proveedor.contacto = contactotxt.Text;

                int rubroIndex = rubroCombo.SelectedIndex;

                proveedor.rubro = rubros[rubroIndex].id;
            
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

                proveedor.direccion = direccion;

                proveedorService.update(proveedor);
            }
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            Form1 abm = new Form1(ServiceDependencies.getProveedorService());
            this.Hide();
            abm.Show();
        }
    }
}