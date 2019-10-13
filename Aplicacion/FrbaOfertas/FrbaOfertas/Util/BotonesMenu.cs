using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FrbaOfertas.Entities;

namespace FrbaOfertas.Util
{
    public class BotonesMenu
    {
        private static List<Funcionalidad> funcionalidades;

        public static void agregarBotones(List<Funcionalidad> botones)
        {
            botones = funcionalidades;
        }
        
        public static List<Funcionalidad> botonesMenu()
        {
            return funcionalidades;
        }
    }
    
     
}