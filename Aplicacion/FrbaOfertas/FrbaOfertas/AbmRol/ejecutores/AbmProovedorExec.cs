﻿using System;

 namespace FrbaOfertas.AbmRol.ejecutores
{
    public class AbmProovedorExec : BotonFuncionalidadAEjecutar
    {

        public AbmProovedorExec(string nombreParaMostrar)
        {
            this.nombreParaMostrar = nombreParaMostrar;
        }

        public override void execute(object sender, EventArgs e)
        {
            Console.WriteLine("asd");
            //abrir el form correspondiente
        }
    }
}