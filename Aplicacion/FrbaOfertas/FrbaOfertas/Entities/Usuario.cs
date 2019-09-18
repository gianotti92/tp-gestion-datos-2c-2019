﻿using System.Collections.Generic;

namespace FrbaOfertas.Entities
{
    public class Usuario
    {
        public int id { get; set; }
        public string userName { get; set; }
        public TipoUsuario tipoUsuario { get; set; }
        public string contrasena { get; set; }
        public EstadoUsuario estadoUsuario { get; set; }
        public int intento { get; set; }

        public List<Rol> roles { get; set; }
    }
}