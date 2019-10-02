﻿using System;
 using System.Windows.Forms;

 namespace FrbaOfertas.AbmRol.ejecutores
{
    public abstract class BotonFuncionalidadAEjecutar
    {
        public string nombreParaMostrar { get; set; }
        public Form pantallaACerrar { get; set; }
        public abstract void execute(object sender, EventArgs e);
    }
}