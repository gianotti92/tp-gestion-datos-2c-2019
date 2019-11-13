using System;

namespace FrbaOfertas.Entities
{
    public class Factura
    {
        public DateTime inicio { get; set; }
        public DateTime fin { get; set; }
        public DateTime fechaFacturacion { get; set; }
        public int proveedorId { get; set; }
    }
}