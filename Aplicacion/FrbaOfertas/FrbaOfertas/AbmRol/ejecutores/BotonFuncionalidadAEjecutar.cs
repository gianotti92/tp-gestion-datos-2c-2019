﻿using System;
 using System.Collections.Generic;
 using System.Windows.Forms;
 using FrbaOfertas.Entities;

 namespace FrbaOfertas.AbmRol.ejecutores
{
    public abstract class BotonFuncionalidadAEjecutar
    {
        public string nombreParaMostrar { get; set; }
        public Form pantallaACerrar { get; set; }

        public abstract void execute(object sender, EventArgs e);
    }
}