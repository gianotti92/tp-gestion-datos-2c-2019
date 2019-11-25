using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Entities
{
    public class Compra
    {
        public int id { get; set; }
        public int idOferta { get; set; }
        public int idCliente { get; set; }
        public DateTime fecha { get; set; }
        public long? cupon { get; set; }
        public DateTime? fechaConsumo { get; set; }
        public int? idFactura { get; set; }
        public int cantidad { get; set; }

        public Compra()
        {
            cupon = null;
            fechaConsumo = null;
            idFactura = null;
        }
    }
}
