﻿using FrbaOfertas.Entities;
using System.Collections.Generic;

namespace FrbaOfertas.Repository
{
    public interface UsuarioRepository
    {
        Usuario getUsuario(string nombreUsuario);
        void saveUsuario(Usuario usuario);
        List<Usuario> GetAll();
    }
}