using FrbaOfertas.Entities;

namespace FrbaOfertas.Repository
{
    public interface FacturaRepository
    {
        int save(Factura factura);
    }
}