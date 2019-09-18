using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FrbaOfertas.AbmRol.ejecutores;
using FrbaOfertas.Entities;

namespace FrbaOfertas.AbmRol
{
    public partial class Form1 : Form
    {
        public Form1(List<Funcionalidad> funcionalidades)
        {
            InitializeComponent();
            //TODO:pensar un nombre a ejecutar x dios jajaja
            List<BotonFuncionalidadAEjecutar> botonesAEjecutar = generarBotonesCorrespondientes(funcionalidades);

            foreach (var botonAEjecutar in botonesAEjecutar)
            {
                Button b = new Button();
                b.Text = "saraza";
                b.Click += new EventHandler(botonAEjecutar.execute);
                //TODO:Averiguar como poner nombre y hacer que con el on click se ejecute la lista de botonesAEjecutar
                b.Visible = true;
                b.Size = new System.Drawing.Size(75, 23);
                b.TabIndex = 1;
                b.AutoSize = true;
                b.BackColor = Color.LightBlue;
                b.Location = new System.Drawing.Point(184, 118);
                b.Show();
                b.Update();
                Controls.Add(b);
            }
        }

        private List<BotonFuncionalidadAEjecutar> generarBotonesCorrespondientes(List<Funcionalidad> funcionalidades)
        {
            List<BotonFuncionalidadAEjecutar> listaBotonesFuncionalidadAEjecutar =
                new List<BotonFuncionalidadAEjecutar>();
            foreach (var funcionalidad in funcionalidades)
            {
                listaBotonesFuncionalidadAEjecutar.Add(EjecutorFactory.create(funcionalidad.nombre));
            }

            return listaBotonesFuncionalidadAEjecutar;
        }
    }
}