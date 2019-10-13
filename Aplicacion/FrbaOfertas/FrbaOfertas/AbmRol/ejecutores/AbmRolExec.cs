using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FrbaOfertas.AbmRol.ejecutores;
using FrbaOfertas.Dao;
using FrbaOfertas.Entities;
using FrbaOfertas.Repository;
using FrbaOfertas.Service;

namespace FrbaOfertas.AbmRol
{
    public class AbmRolExec : BotonFuncionalidadAEjecutar
    {
        public AbmRolExec( string nombreParaMostrar, Form pantallaACerrar)
        {
            this.pantallaACerrar = pantallaACerrar;
            this.nombreParaMostrar = nombreParaMostrar;
        }

        public override void execute(object sender, EventArgs e)
        {
           pantallaACerrar.Hide();
           RolRepository rolRepository = new RolDao();
           RolService rolService = new RolService(rolRepository);
           FuncionalidadPorRolService funcionalidadPorRolService = new FuncionalidadPorRolService(rolService, new FuncionalidadService(new FuncionalidadDao()));
           AbmRolMenuForm abmRol = new AbmRolMenuForm(rolService,funcionalidadPorRolService);
           abmRol.Show();
        }
    }
}