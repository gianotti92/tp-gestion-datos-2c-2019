using System.Collections.Generic;
using FrbaOfertas.Entities;
using FrbaOfertas.Repository;

namespace FrbaOfertas.Service
{
    public class ProovedorService
    {
        private ProovedorRepository proovedorRepository;

        public ProovedorService(ProovedorRepository proovedorRepository)
        {
            this.proovedorRepository = proovedorRepository;
        }

        public List<Proovedor> searchProovedores()
        {
            return proovedorRepository.searchProovedores();
        }
    }
}