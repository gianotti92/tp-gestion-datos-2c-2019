using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Entities
{
    class PersonLogin
    {
        private string usuario;
        private string contrasena;

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }




    }
}
