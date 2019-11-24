﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Entities
{
   public class ListadoTop5VendorFact
    {
       public decimal idProveedor;
        public String RazonSocial;
        public decimal totalFacturacion;

        public ListadoTop5VendorFact(decimal v1, string v2, decimal v3)
        {
            this.idProveedor = v1;
            this.RazonSocial = v2;
            this.totalFacturacion = v3;
        }
    }
}
