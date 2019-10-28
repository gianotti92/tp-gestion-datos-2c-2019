using System;
using FrbaOfertas.Entities;

namespace FrbaOfertas.Repository
{
    public interface DireccionRepository
    {

        Direccion createDireccion(Direccion direccion);
        int createCodigoPostal(String codigoPostal);
    }
}