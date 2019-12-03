using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using FrbaOfertas.AbmRol;
using FrbaOfertas.Dao;
using FrbaOfertas.Entities;
using FrbaOfertas.Service;
using FrbaOfertas.Utils;

namespace FrbaOfertas.Facturar
{
    public partial class FacturarProveedorForm1 : Form
    {
        private ProveedorService _proveedorService;
        private OfertaService _ofertaService;
        private FacturaService _facturaService;
        private CompraService _compraService;

        private List<Proovedor> proovedores;
        private List<Oferta> ofertas;
        private List<Compra> ofertasCompradas;
        private DateTime fechaDelDia = DateTime.Parse(ConfigurationManager.AppSettings["fecha_dia"]);

        public FacturarProveedorForm1(CompraService compraService, ProveedorService _proveedorService,
            OfertaService _ofertaService,
            FacturaService _facturaService)
        {
            this._compraService = compraService;
            this._proveedorService = _proveedorService;
            this._ofertaService = _ofertaService;
            this._facturaService = _facturaService;
          
            InitializeComponent();
            inicioFactDate.Value = fechaDelDia;
            finFactDate.Value = fechaDelDia;
            cargarProveedores();
        }

        private void cargarProveedores()
        {
            proovedores = _proveedorService.searchProovedores();
            proovedores.ForEach(p => ProveedorCombo.Items.Add(p.razonSocial));
        }

        private void esEstadoValido()
        {


            if(! (finFactDate.Value >= inicioFactDate.Value))
            {
                SystemException ex = new SystemException("Fechas de fin debe ser menor a fecha de inicio");
                throw ex;
            }

            if (ProveedorCombo.Text.Equals(""))
            {
                SystemException ex = new SystemException("Debe seleccionar un proveedor");
                throw ex;
            }

         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SeleccionarFuncionalidadForm1 form = new SeleccionarFuncionalidadForm1(FuncionalidadUtil.Funcionalidades);
            form.Show();
        }

        private void btnFacturarOfertas_Click(object sender, EventArgs e)
        {         
                try {
                esEstadoValido();

                    int proveedorId = ProveedorCombo.SelectedIndex + 1;
                    ofertas = _ofertaService.searchOfertasAdquiridasByProveedor(proveedorId, inicioFactDate.Value,
                        finFactDate.Value);
                    ofertasCompradas = _compraService.getComprasSinFactura(proveedorId, inicioFactDate.Value,
                        finFactDate.Value).ToList();

                listadoOfertasGrid.DataSource = new BindingSource(ofertasCompradas, null);
                listadoOfertasGrid.Columns["cantidad"].Visible = false;

                if (ofertasCompradas.Count <= 0)
                    {
                        MessageBox.Show("No hay facturas para procesar");
                        return;
                    }

                    decimal suma = 0;
                    totalFacttxt.Text = Convert.ToString(suma);
                    if (ofertasCompradas.Count > 0)
                    {
                        suma = ofertasCompradas.Select(oc => _ofertaService.searchOfertabyId(oc.idOferta).precioLista).Sum();

                    }

                    Factura factura = new Factura();
                    factura.fechaFacturacion = DateTime.Now;
                    factura.inicio = inicioFactDate.Value;
                    factura.fin = finFactDate.Value;
                    factura.proveedorId = proveedorId;
                    int numeroFactura = _facturaService.save(factura);

                    _compraService.updateCompra(ofertasCompradas, numeroFactura);

                    totalFacttxt.Text = "$ " + Convert.ToString(suma);
                    NroFactTxt.Text = Convert.ToString(numeroFactura);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

           
                
           
        }
    }
}