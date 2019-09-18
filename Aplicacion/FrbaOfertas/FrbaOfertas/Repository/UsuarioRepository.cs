﻿using FrbaOfertas.Entities;

namespace FrbaOfertas.Repository
{
    public interface UsuarioRepository
    {
        Usuario getUsuario(string nombreUsuario);
        Usuario getUsuario(int nombreUsuario);
        void saveUsuario(Usuario usuario);
    }
}