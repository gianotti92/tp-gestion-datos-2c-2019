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

        public Usuario()
        {
            habilitado = true;
            intento = 0;
            roles = new List<Rol>();
        }
    }
}