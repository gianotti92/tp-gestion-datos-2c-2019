using System.Collections.Generic;
using FrbaOfertas.Entities;
using FrbaOfertas.Repository;

namespace FrbaOfertas.Service
{
    public class OfertaService
    {
        private OfertaRepository ofertaRepository;
        public OfertaService(OfertaRepository ofertaRepository)
        {
            this.ofertaRepository = ofertaRepository;
        }

        public List<Oferta> searchOfertas()
        {
            return ofertaRepository.searchOfertas();
        }

        public void saveOferta(Oferta oferta)
        {
            ofertaRepository.saveOferta(oferta);
        }
    }
}