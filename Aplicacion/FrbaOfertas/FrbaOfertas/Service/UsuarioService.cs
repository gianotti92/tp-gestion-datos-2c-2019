﻿﻿using FrbaOfertas.Entities;
using FrbaOfertas.Repository;

namespace FrbaOfertas.Service
{
    public class UsuarioService
    {
        private UsuarioRepository usuarioRepository;

        public UsuarioService(UsuarioRepository usuarioRepository)
        {
            this.usuarioRepository = usuarioRepository;
        }

        public Usuario searchUsuario(string nombreUsuario)
        {
            return usuarioRepository.getUsuario(nombreUsuario);
        }

        public void saveUsuario(Usuario usuario)
        {
            usuarioRepository.saveUsuario(usuario);
        }
    }
}