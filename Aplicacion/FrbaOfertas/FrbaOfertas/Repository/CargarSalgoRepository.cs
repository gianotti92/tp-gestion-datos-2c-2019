using FrbaOfertas.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Repository
{
    public interface CargarSalgoRepository
    {
        void Save(CargaSaldo cargaSaldo);
    }
}
