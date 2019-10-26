﻿using System;
 using System.Collections.Generic;

namespace FrbaOfertas.Entities
{
    public class Usuario
    {
        public string userName { get; set; }
        public TipoUsuario tipoUsuario { get; set; }
        public string contrasena { get; set; }
        public Boolean habilitado { get; set; }
        public int intento { get; set; }

        public List<Rol> roles { get; set; }

        public Usuario(bool habilitado, int intento, List<Rol> roles)
        {
            this.habilitado = habilitado;
            this.intento = intento;
            this.roles = roles;
        }
    }
}