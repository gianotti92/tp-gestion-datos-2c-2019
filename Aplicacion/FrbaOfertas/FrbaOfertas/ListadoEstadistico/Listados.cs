using System;
using System.Linq;
using System.Windows.Forms;
using FrbaOfertas.Service;
using FrbaOfertas.Entities;
using System.Collections.Generic;
using System.ComponentModel;
using FrbaOfertas.AbmRol;
using FrbaOfertas.Utils;

namespace FrbaOfertas.ListadoEstadistico
{
    public partial class Listados : Form
    {
        private Int32 semestre;
        private Int32 anio;
        private ListadoService listadoService;
        private List<ListadoTop5VendorFact> top5Proveedores;
        private List<ListadoTop5Descuento> top5Descuento;


        public Listados(ListadoService listadoService)
        {
            this.listadoService = listadoService;
            InitializeComponent();;

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
            try
            { this.validar(); 
              
            anio = Int32.Parse(comboBox1.SelectedValue.ToString());
            Semestre();

            if (tipoListadoCBox.Text.Equals("Top 5 Mayor Descuento"))
            {
                    top5Descuento = listadoService.top5Descuento(anio, semestre);
                    this.listadoGrid.DataSource = new BindingSource(new BindingList<ListadoTop5Descuento>(top5Descuento), null);



                }
            if (tipoListadoCBox.Text.Equals("Top 5 Mayor Recaudacion"))
            {
                    top5Proveedores = listadoService.top5Facturacion(anio, semestre);
                    this.listadoGrid.DataSource =
                        new BindingSource(new BindingList<ListadoTop5VendorFact>(top5Proveedores), null);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }


        }

        private void validar()
        {
            if (this.comboBox1.SelectedIndex == -1)
            {
               MessageBox.Show("Eliga Año");
                
            }
 
            if (this.comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el semestre");
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

        private void TopCincoRecaudacionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
                System.Windows.Forms.Application.Exit();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}