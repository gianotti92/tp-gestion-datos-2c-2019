using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FrbaOfertas.Entities;
using FrbaOfertas.Repository;
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

        public AltaProovedorForm(Proovedor proveedor, CiudadService ciudadService, RubroService rubroService, DireccionService direccionService, ProveedorService proveedorService)
        {
            this.proveedor = proveedor;
            this.rubroService = rubroService;
            this.ciudadService = ciudadService;
            this.direccionService = direccionService;
            this.proveedorService = proveedorService;
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
                ciudadCombo.SelectedIndex = proveedor.direccion.ciudad - 1;
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
            if (!validoCamposObligatorios())
            {
                MessageBox.Show("Los campos con * son obligatorios y para aquellos que poseen "
                                + "un desplegable, se debe seleccionar una opcion de ellas", "Advertencia");
            }
            else
            {
                if (proveedorService.esRazonSocialRepetido(this.proveedor.id, razonSocialTxt.Text))
                {
                    MessageBox.Show("Existe un proveedor con esa razon social");
                }
                else
                {
                    if (proveedorService.esCUITRepetido(this.proveedor.id, cuitTxt.Text))
                    {
                        MessageBox.Show("Existe un proveedor con ese cuit");
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

                        if (rubroIndex >= 0)
                        {
                            proveedor.rubro = rubros[rubroIndex].id;
                        }

                        int id_direccion;
                        if (proveedor.direccion == null)
                        {
                            Direccion d = new Direccion();

                            d.calle = calleTxt.Text;
                            d.nro = nroTxt.Text;
                            d.piso = pisoTxt.Text;
                            d.depto = dptotxt.Text;
                            d.localidad = localidadTxt.Text;
                            d.codigoPostal = codigoPostaltxt.Text;
                            int cityIndex = ciudadCombo.SelectedIndex;
                            Ciudad city = ciudades[cityIndex];
                            d.ciudad = city.id;
                            
                            d = direccionService.CreateDireccion(d, false);
                            proveedor.direccion = d;
                        }
                        else
                        {
                            proveedor.direccion.calle = calleTxt.Text;
                            proveedor.direccion.nro = nroTxt.Text;
                            proveedor.direccion.piso = pisoTxt.Text;
                            proveedor.direccion.depto = dptotxt.Text;
                            int ciudadIndex = ciudadCombo.SelectedIndex;
                            Ciudad ciudad = ciudades[ciudadIndex];
                            proveedor.direccion.codigoPostal = codigoPostaltxt.Text;
                            proveedor.direccion.localidad = localidadTxt.Text;
                            proveedor.direccion.ciudad = ciudad.id;
                        }


                        proveedorService.update(proveedor);

                        MessageBox.Show("Proveedor actualizado correctamente");

                        Form1 form = new Form1(ServiceDependencies.getProveedorService());
                        this.Hide();
                        form.Show();
                    }
                }
            }
        }

        private bool validoCamposObligatorios()
        {
            return !string.IsNullOrEmpty(razonSocialTxt.Text) &&
                   !string.IsNullOrEmpty(mailTxt.Text) &&
                   !string.IsNullOrEmpty(cuitTxt.Text) &&
                   !string.IsNullOrEmpty(telTxt.Text) &&
                   rubroCombo.SelectedIndex != -1 &&
                   ciudadCombo.SelectedIndex != -1 &&
                   !string.IsNullOrEmpty(calleTxt.Text) &&
                   !string.IsNullOrEmpty(nroTxt.Text) &&
                   !string.IsNullOrEmpty(codigoPostaltxt.Text) &&
                   !string.IsNullOrEmpty(localidadTxt.Text);
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            Form1 abm = new Form1(ServiceDependencies.getProveedorService());
            this.Hide();
            abm.Show();
        }
    }
}