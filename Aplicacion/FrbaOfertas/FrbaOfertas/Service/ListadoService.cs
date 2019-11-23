using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaOfertas.Entities;
using FrbaOfertas.Repository;

namespace FrbaOfertas.Service
{
    public class ListadoService
    {
        private ListadosRepository listadoRepository;

        public ListadoService(ListadosRepository _listadoRepository)
        {
            listadoRepository = _listadoRepository;
        }

        public  List<ListadoTop5VendorFact> top5Facturacion(Int32 anio, Int32 mes)
        {
            return listadoRepository.top5Facturacion(anio,mes);
        }
    }
}
