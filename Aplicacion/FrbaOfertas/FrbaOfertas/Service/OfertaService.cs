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
        
        public List<Oferta> searchOfertas(string descripcion, int provId)
        {
            return ofertaRepository.searchOfertas(descripcion, provId);
        }

        public void saveOferta(Oferta oferta)
        {
            ofertaRepository.saveOferta(oferta);
        }
    }
}