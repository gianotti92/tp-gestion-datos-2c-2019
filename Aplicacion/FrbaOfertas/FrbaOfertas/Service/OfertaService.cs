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

        public List<Oferta> searchOfertasVigentes()
        {
            return ofertaRepository.searchOfertasVigentes();
        }

        public List<Oferta> searchOfertasVigentes(string descripcion, int provId)
        {
            return ofertaRepository.searchOfertasVigentes(descripcion, provId);
        }

        public void saveOferta(Oferta oferta)
        {
            ofertaRepository.saveOferta(oferta);
        }
    }
}