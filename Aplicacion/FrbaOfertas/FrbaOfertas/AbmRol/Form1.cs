﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.AbmRol.ejecutores;
using FrbaOfertas.Entities;
using FrbaOfertas.Service;

namespace FrbaOfertas.AbmRol
{
    public partial class Form1 : Form
    {
        public Form1(List<Funcionalidad> funcionalidades)
        {
            
            //TODO:pensar un nombre a ejecutar x dios jajaja
            List<BotonFuncionalidadAEjecutar> botonesAEjecutar = generarBotonesCorrespondientes(funcionalidades);

            foreach (var funcionalidad in funcionalidades)
            {
                Button b = new Button();
                
                //TODO:Averiguar como poner nombre y hacer que con el on click se ejecute la lista de botonesAEjecutar
                
                this.Controls.Add(b);
            }
           
            InitializeComponent();
           
        }

        private List<BotonFuncionalidadAEjecutar> generarBotonesCorrespondientes(List<Funcionalidad> funcionalidades)
        {
            List<BotonFuncionalidadAEjecutar> listaBotonesFuncionalidadAEjecutar = new List<BotonFuncionalidadAEjecutar>();
            foreach (var funcionalidad in funcionalidades)
            {
                listaBotonesFuncionalidadAEjecutar.Add(EjecutorFactory.create(funcionalidad.nombre));
            }

            return listaBotonesFuncionalidadAEjecutar;
        }
    }
}