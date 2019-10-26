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
    }
}