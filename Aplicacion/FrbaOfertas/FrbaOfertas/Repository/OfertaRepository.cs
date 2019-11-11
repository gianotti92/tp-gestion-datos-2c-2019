using System.Collections.Generic;
using FrbaOfertas.Entities;

namespace FrbaOfertas.Repository
{
    public interface OfertaRepository
    {
        List<Oferta> searchOfertas();
        List<Oferta> searchOfertas(string descripcion, int provId);
        void saveOferta(Oferta oferta);
    }
}