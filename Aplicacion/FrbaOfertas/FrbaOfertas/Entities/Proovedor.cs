using System.Configuration;

namespace FrbaOfertas.Entities
{
    public class Proovedor
    {
        public string usuario { get; set; }
        public int id { get; set; }
        public string cuit{ get; set; }
        public string razonSocial{ get; set; }
        public string mail{ get; set; }
        public int telefono{ get; set; }
        public string contacto{ get; set; }
        
        public int rubro { get; set; }

        public Direccion direccion { get; set; }
    }
}