using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FrbaOfertas.AbmRol.ejecutores;
using FrbaOfertas.Entities;

namespace FrbaOfertas.AbmRol
{
    public partial class SeleccionarFuncionalidadForm1 : Form
    {
        public SeleccionarFuncionalidadForm1(List<Funcionalidad> funcionalidades)
        {
            InitializeComponent();
            //TODO:pensar un nombre a ejecutar x dios jajaja
            List<BotonFuncionalidadAEjecutar> botonesAEjecutar = generarBotonesCorrespondientes(funcionalidades);
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Dock = DockStyle.Fill;
            this.Controls.Add(panel);
            foreach (var botonAEjecutar in botonesAEjecutar)
            {
                Button b = new Button();
                b.Text = botonAEjecutar.nombreParaMostrar;
                b.AutoSize = true;
                b.Click += new EventHandler(botonAEjecutar.execute);
                b.Visible = true;
                
                panel.Controls.Add(b);
            }
        }

        private List<BotonFuncionalidadAEjecutar> generarBotonesCorrespondientes(List<Funcionalidad> funcionalidades)
        {
            List<BotonFuncionalidadAEjecutar> listaBotonesFuncionalidadAEjecutar =
                new List<BotonFuncionalidadAEjecutar>();
            foreach (var funcionalidad in funcionalidades)
            {
                listaBotonesFuncionalidadAEjecutar.Add(EjecutorFactory.create(funcionalidad, this));
            }

            return listaBotonesFuncionalidadAEjecutar;
        }
    }
}