﻿using System;

 namespace FrbaOfertas.AbmRol.ejecutores
{
    public class AbmClienteExec : BotonFuncionalidadAEjecutar
    {
        public AbmClienteExec(string nombreParaMostrar)
        { 
            base.nombreParaMostrar = nombreParaMostrar;
        }

        public override void execute(object sender, EventArgs e)
        {
            Console.WriteLine("asd");
            //abrir el form correspondiente
        }
    }
}