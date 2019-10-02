﻿using System.Collections.Generic;

namespace FrbaOfertas.Entities
{
    public class Rol
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public bool activo { get; set; }
        public List<Funcionalidad> funcionalidades;

        public Rol()
        {
            funcionalidades = new List<Funcionalidad>();
        }
    }
}