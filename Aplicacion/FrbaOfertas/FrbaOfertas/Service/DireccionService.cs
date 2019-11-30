using FrbaOfertas.Entities;
using FrbaOfertas.Repository;

namespace FrbaOfertas.Service
{
   
    public class DireccionService
    {
        private DireccionRepository direccionRepository;

        public DireccionService(DireccionRepository direccionRepository)
        {
            this.direccionRepository = direccionRepository;
        }

        public Direccion CreateDireccion(Direccion direccion, bool esCliente)
        {
            return direccionRepository.createDireccion(direccion, esCliente);
        }

        public int createCodigoPostal(string codigoPostal)
        {
           return direccionRepository.createCodigoPostal(codigoPostal);
        }

        public Direccion getDireccion(int id)
        {
            return direccionRepository.GetById(id);
        }
    }
}