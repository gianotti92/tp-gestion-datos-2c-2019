using FrbaOfertas.Entities;
using FrbaOfertas.Repository;

namespace FrbaOfertas.Service
{
    public class FacturaService
    {
        private FacturaRepository _facturaRepository;

        public FacturaService(FacturaRepository facturaRepository)
        {
            _facturaRepository = facturaRepository;
        }

        public int save(Factura factura)
        {
           return  _facturaRepository.save(factura);
        }
    }
}