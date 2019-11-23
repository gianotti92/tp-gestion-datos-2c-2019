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

        public AltaProovedorForm(Proovedor proveedor, CiudadService ciudadService, RubroService rubroService)
        {
            this.proveedor = proveedor;
            this.rubroService = rubroService;
            this.ciudadService = ciudadService;
            InitializeComponent();
            cargarComboRubro(); 
            llenarComboCiudad();
            cargarPantalla();
        }

        private void cargarPantalla()
        {
            razonSocialTxt.Text = proveedor.razonSocial;
            mailTxt.Text = proveedor.mail;
            cuitTxt.Text = proveedor.cuit;
            rubroCombo.SelectedIndex = proveedor.rubro;
            telTxt.Text = proveedor.telefono.ToString();
            contactotxt.Text = proveedor.contacto;

            if (proveedor.direccion != null)
            {
                calleTxt.Text = proveedor.direccion.calle;
                nroTxt.Text = proveedor.direccion.nro;
                pisoTxt.Text = proveedor.direccion.piso;
                dptotxt.Text = proveedor.direccion.depto;

                localidadTxt.Text = proveedor.direccion.localidad;
                codigoPostaltxt.Text = proveedor.direccion.codigoPostal.ToString();
                ciudadCombo.SelectedIndex = proveedor.direccion.ciudad;
            }
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

        private void volverBtn_Click(object sender, EventArgs e)
        {
            Form1 abm = new Form1(ServiceDependencies.getProveedorService());
            this.Hide();
            abm.Show();
        }
    }
}