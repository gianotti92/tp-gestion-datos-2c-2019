using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Entities
{
    public class CargaSaldo
    {
        public int id { get; set; }
        public int idCliente { get; set; }
        public DateTime fecha { get; set; }
        public double monto { get; set; }
        public TipoPago tipoPago { get; set; }
        public int numeroTarjeta { get; set; }
        public string nombreTarjeta { get; set; }
        public DateTime fechaVencimientoTarjeta { get; set; }
        public int codigoSeguridadTarjeta { get; set; }
    }
}
