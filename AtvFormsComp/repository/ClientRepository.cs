using AtvFormsComp.model;
using System.Collections.Generic;

namespace AtvFormsComp.repository
{
    class ClientRepository
    {

        public static List<Cliente> clients = new List<Cliente>();

        public static Cliente addCliente(Cliente cliente)
        {
            clients.Add(cliente);
            return cliente;
        }

        public static List<Cliente> getClients()
        {
            return clients;
        }

    }
}
