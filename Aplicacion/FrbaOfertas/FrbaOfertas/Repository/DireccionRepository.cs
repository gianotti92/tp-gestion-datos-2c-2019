using System;
using FrbaOfertas.Entities;

namespace FrbaOfertas.Repository
{
    public interface DireccionRepository
    {
        Direccion GetById(int id);
        Direccion createDireccion(Direccion direccion, bool esCliente);
        int createCodigoPostal(String codigoPostal);
    }
}