﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaOfertas.Entities;

namespace FrbaOfertas.Repository
{
    public interface ListadosRepository
    {
       List<ListadoTop5VendorFact> Top5Facturacion(Int32 anio, Int32 semestre);
       List<ListadoTop5Descuento> Top5Descuento(Int32 anio, Int32 semestre);
    }

   
}
