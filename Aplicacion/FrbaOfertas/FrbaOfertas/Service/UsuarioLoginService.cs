using System;
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
        
        public Boolean esUsuarioValido(string nombreUsuario, string contrasena)
        {
            Usuario usuario = usuarioService.searchUsuario(nombreUsuario);
            if (usuario == null)
            {
                return false;
            }
            return usuario.contrasena.Equals(contrasena);
        }

        public void agregarReintento(string userName)
        {
            Usuario usuario = usuarioService.searchUsuario(userName);
            usuario.intento++;
            usuarioService.saveUsuario(usuario);
        }

        public void limpiarReintentos(string userName)
        {
            Usuario usuario = usuarioService.searchUsuario(userName);
            usuario.intento = 0;
            usuarioService.saveUsuario(usuario);
        }
    }
}