using System;
using System.Linq;
using System.Windows.Forms;
using FrbaOfertas.Service;
using FrbaOfertas.Entities;
using System.Collections.Generic;
using FrbaOfertas.AbmRol;
using FrbaOfertas.Utils;

namespace FrbaOfertas.ListadoEstadistico
{
    public partial class TopCincoRecaudacionForm : Form
    {
        Int32 semestre;
        Int32 anio;
        ListadoService listadoService;
        //List<ListadoTop5VendorFact> top5Proveedores;
        //top5Descuento;


        public TopCincoRecaudacionForm(ListadoService listadoService)
        {
            this.listadoService = listadoService;
            InitializeComponent();

            comboBox2.Items.Add("PRIMER SEMESTRE");
            comboBox2.Items.Add("SEGUNDO SEMESTRE");
            comboBox1.DataSource = Enumerable.Range(2010, DateTime.Today.Year).ToList();
            cargarListados();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SeleccionarFuncionalidadForm1 seleccionFuncionalidad =
                new SeleccionarFuncionalidadForm1(FuncionalidadUtil.Funcionalidades);
            seleccionFuncionalidad.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.validar();
            
            anio = Int32.Parse(comboBox1.SelectedValue.ToString());
            Semestre();

            if (tipoListadoCBox.Text.Equals("Top 5 Mayor Descuento"))
            {
                List<ListadoTop5Descuento> top5Descuento = listadoService.top5Descuento(anio, semestre);
                this.dataGridView1.AutoGenerateColumns = true;
                this.dataGridView1.DataSource = new BindingSource(top5Descuento, null);
                    
            }
            if (tipoListadoCBox.Text.Equals("Top 5 Mayor Recaudacion"))
            {
                List<ListadoTop5VendorFact> top5Proveedores = listadoService.top5Facturacion(anio, semestre);
                             
                this.dataGridView1.DataSource = new BindingSource(top5Proveedores, null);
                this.dataGridView1.AutoGenerateColumns = true;

            }

          


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

        private void cargarListados()
        {
            tipoListadoCBox.Items.Add("Top 5 Mayor Descuento");
            tipoListadoCBox.Items.Add("Top 5 Mayor Recaudacion");
        }

    }
}