using System.Collections.Generic;
using FrbaOfertas.Entities;
using System;

namespace FrbaOfertas.Repository
{
    public interface OfertaRepository
    {
        List<Oferta> searchOfertas();
        List<Oferta> searchOfertasVigentes(string descripcion, int provId);

        List<Oferta> searchOfertasVigentes();

        void saveOferta(Oferta oferta);
        List<Oferta> searchOfertasByProveedor(int proveedorId);
        
        List<int> searchAnios();
        List<Oferta> searchOfertasAdquiridasByProveedor(int proveedorId, DateTime fechaInicio, DateTime fechaFin);
    }
}