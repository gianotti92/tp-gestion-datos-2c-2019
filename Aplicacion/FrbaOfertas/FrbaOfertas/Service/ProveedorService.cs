using System.Collections.Generic;
using FrbaOfertas.Entities;
using FrbaOfertas.Repository;

namespace FrbaOfertas.Service
{
    public class ProveedorService
    {
        private ProovedorRepository proovedorRepository;

        public ProveedorService(ProovedorRepository proovedorRepository)
        {
            this.proovedorRepository = proovedorRepository;
        }

        public List<Proovedor> searchProovedores()
        {
            return proovedorRepository.searchProovedores();
        }

        public void save(Proovedor proveedor)
        {
            proovedorRepository.save(proveedor);
        }
    }
}