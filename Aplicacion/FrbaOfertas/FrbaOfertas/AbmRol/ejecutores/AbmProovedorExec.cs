﻿using System;
 using System.Windows.Forms;
 using FrbaOfertas.Service;

 namespace FrbaOfertas.AbmRol.ejecutores
{
    public class AbmProovedorExec : BotonFuncionalidadAEjecutar
    {

        public AbmProovedorExec(string nombreParaMostrar, Form pantallaACerrrar)
        {
            this.nombreParaMostrar = nombreParaMostrar;
            base.pantallaACerrar = pantallaACerrrar;
        }

        public override void execute(object sender, EventArgs e)
        {
           pantallaACerrar.Hide();
           AbmProveedor.Form1 proveedorForm = new AbmProveedor.Form1(ServiceDependencies.getProveedorService());
           proveedorForm.Show();
        }
    }
}