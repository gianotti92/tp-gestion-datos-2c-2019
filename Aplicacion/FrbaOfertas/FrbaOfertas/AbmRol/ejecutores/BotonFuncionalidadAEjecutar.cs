﻿using System;

 namespace FrbaOfertas.AbmRol.ejecutores
{
    public abstract class BotonFuncionalidadAEjecutar
    {
        public string nombreParaMostrar { get; set; }
        public abstract void execute(object sender, EventArgs e);
    }
}