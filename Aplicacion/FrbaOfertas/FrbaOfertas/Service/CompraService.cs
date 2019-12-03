using FrbaOfertas.Entities;
using FrbaOfertas.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Service
{
    public class CompraService
    {
        private CompraRepository CompraDao;

        public CompraService(CompraRepository compraDao)
        {
            CompraDao = compraDao;
        }

        public int SaveCompra(Compra compra)
        {
            return CompraDao.Save(compra);
        }
        
        public void updateCompra(List<Compra> ofertasCompradasIds, int numeroFactura)
        {
            CompraDao.updateCompra(ofertasCompradasIds, numeroFactura);
        }

        public void updateCompra(int ofertasCompradasIds, DateTime fechaConsumo)
        {
            CompraDao.updateCompra(ofertasCompradasIds, fechaConsumo);
        }

        public Compra GetCompra(int idCompra)
        {
            return CompraDao.GetCompra(idCompra);

        }

        public List<Compra> GetTodasCompras() {
            return CompraDao.GetTodasCompras();

        }

        public List<Compra> getComprasSinFactura(int provId, DateTime fechaInicio, DateTime fechaFin)
        {
            return CompraDao.getComprasSinFactura(provId, fechaInicio, fechaFin);
        }
    }
}
