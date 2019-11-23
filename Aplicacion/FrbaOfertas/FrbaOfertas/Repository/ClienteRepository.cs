using System.Collections.Generic;
using FrbaOfertas.Entities;

namespace FrbaOfertas.Repository
{
    public interface ClienteRepository
    {
        void guardarCliente(Cliente cliente);
        Cliente GetByUsername(string username);
        void Update(Cliente cliente);
        List<Cliente> searchClientes();
        List<Cliente> searchClientesxByFiltro(string nombreFiltro, string apellidoFiltro, string dniFiltro, string mailFIltro);
        void delete(int id);
    }
}