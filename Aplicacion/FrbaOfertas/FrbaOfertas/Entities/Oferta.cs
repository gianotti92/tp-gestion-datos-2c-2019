using System;

namespace FrbaOfertas.Entities
{
    public class Oferta
    {
        public string id { get; set; }
        public int proovedorId{ get; set; }
        public long precio{ get; set; }
        public long precioLista{ get; set; }
        public int stockDisponible{ get; set; }
        public string descripcion{ get; set; }
        public DateTime fechaPublicacion{ get; set; }
        public DateTime fechaVencimiento{ get; set; }
        public int cantidadMaximaPorCompra{ get; set; }
    }
}