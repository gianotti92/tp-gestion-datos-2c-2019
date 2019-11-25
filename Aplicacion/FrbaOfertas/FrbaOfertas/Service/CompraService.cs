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

        public List<int> buscarcompras()
        {
            List<int> ids = new List<int>();
            ids.Add(57306);
            return new List<int>();
        }

        public void updateCompra(List<int> ofertasCompradasIds, int numeroFactura)
        {
            CompraDao.updateCompra(ofertasCompradasIds, numeroFactura);
        }
    }
}
