using System.Collections.Generic;
using FrbaOfertas.Entities;
using FrbaOfertas.Repository;

namespace FrbaOfertas.Service
{
    public class RubroService
    {
        private RubroRepository _rubroRepository;


        public RubroService(RubroRepository rubroRepository)
        {
            _rubroRepository = rubroRepository;
        }

        public List<Rubro> searcRubros()
        {
            return _rubroRepository.searchRubros();
        }
    }
}