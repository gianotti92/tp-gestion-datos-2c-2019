using System.Collections.Generic;
using FrbaOfertas.Entities;
using FrbaOfertas.Repository;
using System;

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

        public List<Oferta> searchOfertasByProveedor(int proveedorId)
        {
            return ofertaRepository.searchOfertasByProveedor(proveedorId);
        }

        public List<int> searchAnios()
        {
            return ofertaRepository.searchAnios();
        }

        public List<Oferta> searchOfertasAdquiridasByProveedor(int idProveedor, DateTime fechaInicio, DateTime fechaFin)
        {
            return ofertaRepository.searchOfertasAdquiridasByProveedor(idProveedor, fechaInicio, fechaFin);
        }
    }
}