using System.Collections.Generic;
using FrbaOfertas.Entities;

namespace FrbaOfertas.Repository
{
    public interface OfertaRepository
    {
        List<Oferta> searchOfertas();
        List<Oferta> searchOfertasVigentes(string descripcion, int provId);

        List<Oferta> searchOfertasVigentes();

        int saveOferta(Oferta oferta);
        List<Oferta> searchOfertasByProveedor(int proveedorId);
        List<int> searchAnios();
    }
}