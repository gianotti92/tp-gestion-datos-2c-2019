﻿using System;
using FrbaOfertas.Entities;
using FrbaOfertas.Repository;

namespace FrbaOfertas.Service

{
    public class UsuarioLoginService
    {
        private FuncionalidadService funcionalidadService;
        private RolService rolService;
        private UsuarioService usuarioService;

        public UsuarioLoginService(FuncionalidadService funcionalidadService, RolService rolService,
            UsuarioService usuarioService)
        {
            this.funcionalidadService = funcionalidadService;
            this.rolService = rolService;
            this.usuarioService = usuarioService;
        }
        public void agregarReintento(string userName)
        {
            Usuario usuario = usuarioService.searchUsuario(userName);
            usuario.intento++;
            usuarioService.UpdateUsuario(usuario);
        }

        public void limpiarReintentos(string userName)
        {
            Usuario usuario = usuarioService.searchUsuario(userName);
            usuario.intento = 0;
            usuarioService.UpdateUsuario(usuario);
        }

        public Usuario searchUsuario(string name)
        {
            return usuarioService.searchUsuario(name);
        }

        public void saveUsuarioInhabilitado(Usuario usuario)
        {
            usuarioService.UpdateUsuario(usuario);
        }
    }
}