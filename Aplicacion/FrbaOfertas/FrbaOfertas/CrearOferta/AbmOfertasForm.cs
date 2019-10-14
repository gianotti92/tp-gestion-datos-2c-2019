using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FrbaOfertas.AbmRol;
using FrbaOfertas.Dao;
using FrbaOfertas.Entities;
using FrbaOfertas.Service;
using FrbaOfertas.Utils;

namespace FrbaOfertas.CrearOferta
{
    public partial class AbmOfertasForm : Form
    {
        private OfertaService ofertaService;
        public AbmOfertasForm(OfertaService ofertaService)
        {
            this.ofertaService = ofertaService;
            InitializeComponent();
            cargarDataGrid();
        }

        private void cargarDataGrid()
        {
            List<Oferta> ofertas = ofertaService.searchOfertas();
            OfertaDataGridView.DataSource = new BindingSource(ofertas, null);
        }

        private void crearOfertaBtn_Click(object sender, EventArgs e)
        {
            AltaOfertaForm altaOfertaForm = new AltaOfertaForm(new OfertaService(new OfertaDao()), new ProovedorService(new ProovedorDao()));
            this.Hide();
            altaOfertaForm.Show();
        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SeleccionarFuncionalidadForm1 seleccionFuncionalidad =
                new SeleccionarFuncionalidadForm1(FuncionalidadUtil.Funcionalidades);
            seleccionFuncionalidad.Show();
        }
    }
}