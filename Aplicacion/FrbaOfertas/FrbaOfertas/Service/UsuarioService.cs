﻿using FrbaOfertas.Entities;
using FrbaOfertas.Repository;
using System.Collections.Generic;

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

        public void CreateUsuario(Usuario usuario)
        {
            usuarioRepository.Create(usuario);
        }

        public void UpdateUsuario(Usuario usuario)
        {
            usuarioRepository.Update(usuario);
        }

        public void DeleteUsuario(Usuario usuario)
        {
            usuarioRepository.Delete(usuario);
        }

        public List<Usuario> GetAll()
        {
            return usuarioRepository.GetAll();
        }
    }
}