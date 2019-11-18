using FrbaOfertas.Entities;

namespace FrbaOfertas.Repository
{
    public interface ClienteRepository
    {
        void guardarCliente(Cliente cliente);
        Cliente GetByUsername(string username);
        void Update(Cliente cliente);
    }
}