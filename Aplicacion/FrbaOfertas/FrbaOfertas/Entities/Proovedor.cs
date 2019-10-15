using System.Configuration;

namespace FrbaOfertas.Entities
{
    public class Proovedor
    {
        public int id { get; set; }
        public int cuit{ get; set; }
        public string razonSocial{ get; set; }
        public string mail{ get; set; }
        public int telefono{ get; set; }
        public string contacto{ get; set; }
    }
}