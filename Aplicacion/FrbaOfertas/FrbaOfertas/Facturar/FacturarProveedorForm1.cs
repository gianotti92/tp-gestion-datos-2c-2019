using System;
using System.Collections.Generic;
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
        private List<int> ofertasCompradasIds;

        public FacturarProveedorForm1(CompraService compraService, ProveedorService _proveedorService,
            OfertaService _ofertaService,
            FacturaService _facturaService)
        {
            this._compraService = compraService;
            this._proveedorService = _proveedorService;
            this._ofertaService = _ofertaService;
            this._facturaService = _facturaService;
            InitializeComponent();
            cargarProveedores();
        }

        private void cargarProveedores()
        {
            proovedores = _proveedorService.searchProovedores();
            proovedores.ForEach(p => ProveedorCombo.Items.Add(p.razonSocial));
        }

        private bool esEstadoValido()
        {
            return finFactDate.Value >= inicioFactDate.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SeleccionarFuncionalidadForm1 form = new SeleccionarFuncionalidadForm1(FuncionalidadUtil.Funcionalidades);
            form.Show();
        }

        private void btnFacturarOfertas_Click(object sender, EventArgs e)
        {
            if (esEstadoValido())
            {
                int proveedorId = ProveedorCombo.SelectedIndex + 1;
                ofertas = _ofertaService.searchOfertasAdquiridasByProveedor(proveedorId, inicioFactDate.Value,
                    finFactDate.Value);
                ofertasCompradasIds = _compraService.getComprasSinFactura(proveedorId).ToList();

                ofertas = ofertas.Where(o => ofertasCompradasIds.Contains(o.id)).ToList();

                listadoOfertasGrid.DataSource = new BindingSource(ofertas, null);
                if (ofertas.Count <= 0)
                {
                    MessageBox.Show("No hay facturas para procesar");
                    return;
                }

                decimal suma = 0;
                totalFacttxt.Text = Convert.ToString(suma);
                if (ofertas.Count > 0)
                {
                    suma = ofertas.Select(o => o.precioLista).Sum();
                }

                Factura factura = new Factura();
                factura.fechaFacturacion = DateTime.Now;
                factura.inicio = inicioFactDate.Value;
                factura.fin = finFactDate.Value;
                factura.proveedorId = proveedorId;
                int numeroFactura = _facturaService.save(factura);

                _compraService.updateCompra(ofertasCompradasIds, numeroFactura);

                totalFacttxt.Text = "$ " + Convert.ToString(suma);
                NroFactTxt.Text = Convert.ToString(numeroFactura);
            }else {
                MessageBox.Show("Datos invalidos");
            }
        }
    }
}