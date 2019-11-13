using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FrbaOfertas.Service;

namespace FrbaOfertas.ListadoEstadistico
{
    public partial class TopCincoMayorDescuentoForm : Form
    {
        private OfertaService ofertaService;
        private List<int> anios;
        public TopCincoMayorDescuentoForm(OfertaService ofertaService)
        {    
            this.ofertaService = ofertaService;
            InitializeComponent();
            cargarFecha();
            cargarSemestre();
        }

        private void cargarSemestre()
        {
            semestreCombo.Items.Add("1");
            semestreCombo.Items.Add("2");
        }

        private void cargarFecha()
        {
            anios = ofertaService.searchAnios();
           anios.ForEach(a => anioCombo.Items.Add(a));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListadoEstadisticoForm listado = new ListadoEstadisticoForm();
            this.Hide();
            listado.Show();
        }
    }
}