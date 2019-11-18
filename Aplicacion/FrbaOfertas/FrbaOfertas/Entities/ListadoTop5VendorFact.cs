using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Entities
{
   public class ListadoTop5VendorFact
    {
       public int idProveedor;
        public String RazonSocial;
        public double totalFacturacion;

        public ListadoTop5VendorFact(int v1, string v2, double v3)
        {
            this.idProveedor = v1;
            this.RazonSocial = v2;
            this.totalFacturacion = v3;
        }
    }
}
