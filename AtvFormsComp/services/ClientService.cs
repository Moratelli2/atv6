using AtvFormsComp.model;
using AtvFormsComp.repository;
using System.Collections.Generic;

namespace AtvFormsComp.services
{
    class ClientService
    {
        public static List<Cliente> getClients()
        {
            return ClientRepository.getClients();
        }
        public static Cliente addCliente(Cliente cliente)
        {
            return ClientRepository.addCliente(cliente);
        }

    }
}
