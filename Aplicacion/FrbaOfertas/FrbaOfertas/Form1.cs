﻿﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 using FrbaOfertas.AbmUsuario;
 using FrbaOfertas.Dao;
 using FrbaOfertas.Entities;
 using FrbaOfertas.Repository;
 using FrbaOfertas.Service;
 using FrbaOfertas.Utils;

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
            string nombreUsuario = nameTxt.Text;
            string contrasena = contrasenaTxt.Text;
            Usuario usuario = usuarioLoginService.searchUsuario(nombreUsuario);
            if (usuario != null)
            {
                if (usuario.intento == 3)
                {
                    MessageBox.Show("Usuario inhabilitado"); 
                }
                else if (usuario.contrasena.Equals(contrasena))
                {
                    usuarioLoginService.limpiarReintentos(nombreUsuario);
                    List<Funcionalidad> funcionalidades = funcionalidadPorRolService.searchFuncionalidades(usuario);
                    abrirPantallaBotonesPorRoles(funcionalidades);
                }
                else
                {
                    usuarioLoginService.agregarReintento(nombreUsuario);
                    usuario = usuarioLoginService.searchUsuario(nombreUsuario);
                    if (usuario.intento == 3)
                    {
                        usuario.habilitado = false;
                        usuarioLoginService.saveUsuarioInhabilitado(usuario);
                    }
                    MessageBox.Show("Usuario o Contraseña Invalidos.");
                }
            }
            else
            {
               ABMUsuarioAltaForm altaUsuario = new ABMUsuarioAltaForm();
               this.Hide();
               altaUsuario.Show();
            }
        }
        private void abrirPantallaBotonesPorRoles(List<Funcionalidad> funcionalidades)
        {
            FuncionalidadUtil.Funcionalidades = funcionalidades;
            Form botonesPorRoles = new AbmRol.SeleccionarFuncionalidadForm1(funcionalidades);
            botonesPorRoles.Show();
            this.Hide();
        }
    }
}
