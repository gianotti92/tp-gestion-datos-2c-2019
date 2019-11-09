using System.Collections.Generic;
using FrbaOfertas.Entities;

namespace FrbaOfertas.Repository
{
    public interface ProovedorRepository
    {
        List<Proovedor> searchProovedores();
        void save(Proovedor proveedor);
    }
}