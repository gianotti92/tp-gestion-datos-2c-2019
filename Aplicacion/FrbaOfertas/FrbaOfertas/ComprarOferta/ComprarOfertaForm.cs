using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.Entities;
using FrbaOfertas.Service;

namespace FrbaOfertas.ComprarOferta
{
    public partial class ComprarOfertaForm : Form
    {
        private OfertaService ofertaService;
        private ProveedorService proveedorService;
        public ComprarOfertaForm(OfertaService ofertaService, ProveedorService proveedorService)
        {
            this.ofertaService = ofertaService;
            this.proveedorService = proveedorService;
            InitializeComponent();
            inicializarFiltro();
            cargarDataGrid();
        }

        private void inicializarFiltro()
        {
            List<Proovedor> proveedores = proveedorService.searchProovedores();
            filtroProvCombo.Items.Add("Seleccionar");
            filtroProvCombo.SelectedIndex = 0;
            proveedores.ForEach(p => filtroProvCombo.Items.Add(p.razonSocial));
        }


        private void cargarDataGrid()
        {
            List<Oferta> ofertas = ofertaService.searchOfertas();
            compraOfertaDgw.DataSource = new BindingSource(ofertas, null);
        }

        private void filtroBuscarBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filtroDescTxt.Text) || filtroProvCombo.SelectedIndex != 0)
            {
                string text = filtroDescTxt.Text;
                int provId = filtroProvCombo.SelectedIndex;
                List<Oferta> ofertas = ofertaService.searchOfertas(text, provId);
                compraOfertaDgw.DataSource = new BindingSource(ofertas, null);
            }
        }

        private void FiltroLimpiarBtn_Click(object sender, EventArgs e)
        {
            inicializarFiltro();
            cargarDataGrid();
        }

        private void ComprarBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compra finalizada con exito, cod compra : 12323");
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
