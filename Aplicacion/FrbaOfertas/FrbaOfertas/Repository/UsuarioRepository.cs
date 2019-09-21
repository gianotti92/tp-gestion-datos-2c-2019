﻿using FrbaOfertas.Entities;

namespace FrbaOfertas.Repository
{
    public interface UsuarioRepository
    {
        Usuario getUsuario(string nombreUsuario);
        void saveUsuario(Usuario usuario);
    }
}