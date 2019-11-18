using FrbaOfertas.Entities;
using FrbaOfertas.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Service
{
    public class CargarSalgoService
    {
        private CargarSalgoRepository CargarSalgoDao;

        public CargarSalgoService(CargarSalgoRepository cargarSalgoDao)
        {
            CargarSalgoDao = cargarSalgoDao;
        }

        public void SaveCargarSaldo(CargaSaldo cargaSaldo)
        {
            CargarSalgoDao.Save(cargaSaldo);
        }
    }
}
