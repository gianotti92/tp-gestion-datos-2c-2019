using System.Collections.Generic;
using FrbaOfertas.Entities;

namespace FrbaOfertas.Repository
{
    public interface RubroRepository
    {
        List<Rubro> searchRubros();
    }
}