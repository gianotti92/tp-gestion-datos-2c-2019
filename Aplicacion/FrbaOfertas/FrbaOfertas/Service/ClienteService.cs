using System.Collections.Generic;
using System.Security.Policy;
using FrbaOfertas.Entities;
using FrbaOfertas.Repository;

namespace FrbaOfertas.Service
{
    public class ClienteService
    {
        private ClienteRepository clienteRepository;

        public ClienteService(ClienteRepository clienteRepository)
        {
            this.clienteRepository = clienteRepository;
        }

        public void createCliente(Cliente cliente)
        {
            clienteRepository.guardarCliente(cliente);
        }

        public Cliente GetClienteByUsername(string username)
        {
            return clienteRepository.GetByUsername(username);
        }

        public void UpdateCliente(Cliente cliente)
        {
            clienteRepository.Update(cliente);
        }

        public List<Cliente> searchClientes()
        {
            return clienteRepository.searchClientes();
        }

        public List<Cliente> searchClientesByFiltro(string nombreFiltro, string apellidoFiltro, string dniFiltro, string mailFIltro)
        {
            return clienteRepository.searchClientesxByFiltro(nombreFiltro, apellidoFiltro, dniFiltro, mailFIltro);
        }

        public void Delete(int id)
        {
            clienteRepository.delete(id);
        }
    }
}