﻿using FrbaOfertas.Entities;
using System.Collections.Generic;

namespace FrbaOfertas.Repository
{
    public interface UsuarioRepository
    {
        Usuario getUsuario(string nombreUsuario);
        bool ValidateUsuario(string userName, string passWord);
        void Create(Usuario usuario);
        void Update(Usuario usuario);
        void Delete(Usuario usuario);
        List<Usuario> GetAll();
    }
}