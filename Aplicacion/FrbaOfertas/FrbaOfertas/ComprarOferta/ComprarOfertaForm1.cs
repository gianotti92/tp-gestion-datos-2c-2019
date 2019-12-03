using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FrbaOfertas.AbmRol;
using FrbaOfertas.Entities;
using FrbaOfertas.Service;
using FrbaOfertas.Utils;

namespace FrbaOfertas.ComprarOferta
{
    public partial class ComprarOfertaForm1 : Form
    {
        private OfertaService ofertaService;
        private ProveedorService proveedorService;
        private ClienteService clienteService;
        private CompraService compraService { get { return ServiceDependencies.getCompraService(); } }

        private List<Oferta> ofertas;
       
        public ComprarOfertaForm1(OfertaService ofertaService, ProveedorService proveedorService,
            ClienteService clienteService)
        {
            this.ofertaService = ofertaService;
            this.proveedorService = proveedorService;
            this.clienteService = clienteService;
            InitializeComponent();
            inicializarFiltro();
            cargarDataGrid();
        }

        private void inicializarFiltro()
        {
            filtroProvCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            List<Proovedor> proveedores = proveedorService.searchProovedores();
            proovedorBindingSource.DataSource = proveedores;
            filtroProvCombo.SelectedIndex = -1;
            filtroDescTxt.Text = "";
        }


        private void cargarDataGrid()
        {
            ofertas = ofertaService.searchOfertasVigentes();
            compraOfertaDgw.DataSource = new BindingSource(ofertas, null);
        }
        
        private void volverBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SeleccionarFuncionalidadForm1 seleccionFuncionalidad =
                new SeleccionarFuncionalidadForm1(FuncionalidadUtil.Funcionalidades);
            seleccionFuncionalidad.Show();
        }
        
        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            inicializarFiltro();
            cargarDataGrid();
        }

        private void filtrarBtn_Click(object sender, EventArgs e)
        {
            int provId = 0;
            if (filtroProvCombo.SelectedValue != null)
            {
                provId = (int)filtroProvCombo.SelectedValue;
            }
            
            if (!string.IsNullOrEmpty(filtroDescTxt.Text) || provId > 0 )
            {
                string text = filtroDescTxt.Text;
                ofertas = ofertaService.searchOfertasVigentes(text, provId);
                compraOfertaDgw.DataSource = new BindingSource(ofertas, null);
            }
        }

        private void compraOfertaDgw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cliente cliente = clienteService.GetClienteByUsername(UsuarioUtil.Usuario.userName);
            
            Oferta ofertaSeleccionada = ofertas[e.RowIndex];
            string fechaDia = System.Configuration.ConfigurationManager.AppSettings.Get("fecha_dia");
            string nombreApellido = cliente.nombre + " " + cliente.apellido;

            try { this.validar(cliente,ofertaSeleccionada);
                
                int CantidadAComprar = int.Parse(CantidadOfertas.Text);
                List<int> idsComprados = new List<int>();
                while (CantidadAComprar != 0)
                {
                    Compra compra = new Compra();
                    compra.idOferta = ofertaSeleccionada.id;
                    compra.idCliente = cliente.id;
                    compra.fecha = Convert.ToDateTime(fechaDia);
                    compra.cantidad = int.Parse(CantidadOfertas.Text);
                    int idCompra = compraService.SaveCompra(compra);
                    cliente.saldo -= ofertaSeleccionada.precio;
                    clienteService.UpdateCliente(cliente);
                    idsComprados.Add(idCompra);
                    MessageBox.Show("Compra finalizada con exito, cod compra : " + idCompra);
                    CantidadAComprar = CantidadAComprar - 1;
                }


                cargarDataGrid();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }

        }

        private void validar(Cliente cliente, Oferta ofertaSeleccionada)
        {
            CantidadMayorACero();
            CantidadMaxima(ofertaSeleccionada);
            hayStock(ofertaSeleccionada);
            saldoSuficiente(cliente, ofertaSeleccionada);


        }

        private void CantidadMayorACero()
        {
            if (CantidadOfertas.Text == "") 
            {

                SystemException ex = new SystemException("Debe ingresar una cantidad Valida");
                throw ex;
            }
            else { 

            int CantidadAComprar = int.Parse(CantidadOfertas.Text);
            if (CantidadAComprar.Equals(null) || CantidadAComprar <1 )
            {

                SystemException ex = new SystemException("Debe ingresar una cantidad Valida");
                throw ex;
            }
            }

        }




        private void CantidadMaxima(Oferta ofertaSeleccionada)
        {
           
            int CantidadAComprar = int.Parse(CantidadOfertas.Text);
            if ( (ofertaSeleccionada.cantidadMaximaPorCompra < CantidadAComprar)) {

                SystemException ex = new SystemException("Supero el limite de compra por Cliente");
                throw ex;
            }

        }

        private void hayStock(Oferta ofertaSeleccionada)
        {
            int CantidadAComprar = int.Parse(CantidadOfertas.Text);
            if (ofertaSeleccionada.stockDisponible <= 0 || ofertaSeleccionada.stockDisponible < CantidadAComprar)
            {
                SystemException ex = new SystemException("No hay Stock disponible o la cantidad supera el Stock Disponible");
                throw ex;
            }

            
        }

        private void saldoSuficiente(Cliente cliente, Oferta oferta)
        {
            int CantidadAComprar = int.Parse(CantidadOfertas.Text);
            if ( ! (cliente.saldo >= (oferta.precio * CantidadAComprar)))
            {
                SystemException ex = new SystemException("No tiene suficiente saldo para realizar la compra.");
                throw ex;
            }
        }

        private void CantidadOfertas_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar que la tecla presionada no sea CTRL u otra tecla no numerica
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten numeros Enteros ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }

        }

        private void ComprarOfertaForm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}