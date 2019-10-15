using System.Collections.Generic;
using FrbaOfertas.Entities;

namespace FrbaOfertas.Repository
{
    public interface OfertaRepository
    {
        List<Oferta> searchOfertas();
        void saveOferta(Oferta oferta);
    }
}