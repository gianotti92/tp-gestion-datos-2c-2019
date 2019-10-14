using System.Collections.Generic;
using FrbaOfertas.Entities;

namespace FrbaOfertas.Utils
{
    public static class FuncionalidadUtil
    {
        private static List<Funcionalidad> funcionalidades = new List<Funcionalidad>();

        public static List<Funcionalidad> Funcionalidades
        {
            get { return funcionalidades; }
            set { funcionalidades = value; }
        }

    }
}