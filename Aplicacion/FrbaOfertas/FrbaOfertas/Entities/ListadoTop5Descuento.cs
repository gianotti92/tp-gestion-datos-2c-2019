using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Entities
{
    public class ListadoTop5Descuento

    {
        public decimal idProveedor { get; set; }
        public String RazonSocial { get; set; }
        public decimal mayorPorcentajeOfrecido { get; set; }

        public ListadoTop5Descuento(decimal v1, string v2, decimal v3)
        {
            this.idProveedor = v1;
            this.RazonSocial = v2;
            this.mayorPorcentajeOfrecido = v3;
        }
    }
}
