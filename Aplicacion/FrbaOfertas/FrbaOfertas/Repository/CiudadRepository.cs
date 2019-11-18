using System.Collections.Generic;
using FrbaOfertas.Entities;

namespace FrbaOfertas.Repository
{
    public interface CiudadRepository
    {
        List<Ciudad> searchCiudadees();
    }
}