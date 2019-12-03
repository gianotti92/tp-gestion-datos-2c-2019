using FrbaOfertas.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Repository
{
    public interface CompraRepository
    {
        int Save(Compra compra);
        void updateCompra(List<Compra> ofertasCompradasIds, int numeroFactura);
        Compra GetCompra(int idCompra);
        List<Compra> GetTodasCompras();
        List<Compra> getComprasSinFactura(int provId, DateTime fechaInicio, DateTime fechaFin);
        void updateCompra(int ofertasCompradasIds, DateTime fechaConsumo);
    }
}
