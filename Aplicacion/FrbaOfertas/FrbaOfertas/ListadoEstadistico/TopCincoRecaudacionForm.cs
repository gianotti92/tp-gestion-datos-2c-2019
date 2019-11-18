using System;
using System.Linq;
using System.Windows.Forms;
using FrbaOfertas.Service;
using FrbaOfertas.Entities;
using System.Collections.Generic;

namespace FrbaOfertas.ListadoEstadistico
{
    public partial class TopCincoRecaudacionForm : Form
    {
        Int32 semestre;
        Int32 anio;
        private ListadoService listadoService;
        private List<ListadoTop5VendorFact> top5Proveedores;


        public TopCincoRecaudacionForm()
        {
            InitializeComponent();
            comboBox2.Items.Add("PRIMER SEMESTRE");
            comboBox2.Items.Add("SEGUNDO SEMESTRE");
            comboBox1.DataSource = Enumerable.Range(2000, DateTime.Today.Year).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListadoEstadisticoForm listado = new ListadoEstadisticoForm();
            this.Hide();
            listado.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.validar();

            anio = Int32.Parse(comboBox1.SelectedValue.ToString());
            Semestre();

            top5Proveedores = listadoService.top5Facturacion(anio, semestre);
                    
            dataGridView1.DataSource = top5Proveedores;


        }

        private void validar()
        {
            if (this.comboBox1.SelectedIndex == -1)
            {
                SystemException ex = new SystemException("Eliga Año");
                throw ex;
            }
 
            if (this.comboBox2.SelectedIndex == -1)
            {
                SystemException ex = new SystemException("Seleccione el semestre");
                throw ex;
            }
        }

        private void Semestre()
        {
            if (comboBox2.Text.Equals("PRIMER SEMESTRE"))
            {
                semestre = 1;
            }
            else
            {
                semestre = 2;
            }
        }
    }
}