﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 using FrbaOfertas.Dao;
 using FrbaOfertas.Entities;
 using FrbaOfertas.Repository;
 using FrbaOfertas.Service;

 namespace FrbaOfertas
{
    public partial class Form1 : Form
    {
        private UsuarioLoginService usuarioLoginService;
        private FuncionalidadPorRolService funcionalidadPorRolService;
        public Form1(UsuarioLoginService usuarioLoginService, FuncionalidadPorRolService funcionalidadPorRolService)
        {
            this.usuarioLoginService = usuarioLoginService;
            this.funcionalidadPorRolService = funcionalidadPorRolService;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = nameTxt.Text;
            string contrasena = contrasenaTxt.Text;

            if (usuarioLoginService.esUsuarioValido(usuario, contrasena))
            {
                usuarioLoginService.limpiarReintentos(usuario);
                List<Rol> roles = funcionalidadPorRolService.searchRoles(usuario);
                List<Funcionalidad> funcionalidades = funcionalidadPorRolService.searchFuncionalidades(roles);
                abrirPantallaBotonesPorRoles(funcionalidades);
            }
            else
            {
                usuarioLoginService.agregarReintento(usuario);
                //MOSTRAR POP UP DICIENDO QUE NO SE PUDO INICIALIZAR
            }
        }

        private void abrirPantallaBotonesPorRoles(List<Funcionalidad> funcionalidades)
        {
            Form botonesPorRoles = new AbmRol.Form1(funcionalidades);
            botonesPorRoles.Show();
            this.Hide();
        }
    }
}
