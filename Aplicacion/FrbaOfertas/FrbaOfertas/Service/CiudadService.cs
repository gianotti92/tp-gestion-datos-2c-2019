using System.Collections.Generic;
using FrbaOfertas.Entities;
using FrbaOfertas.Repository;

namespace FrbaOfertas.Service
{
    public class CiudadService
    {
        private CiudadRepository _ciudadRepository;

        public CiudadService(CiudadRepository ciudadRepository)
        {
            _ciudadRepository = ciudadRepository;
        }

        public List<Ciudad> searchCiudades()
        {
            return _ciudadRepository.searchCiudadees();
        }
    }
}