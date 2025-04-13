using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique_CF.INTERFACES;
using Projet_Commerce_Electronique.MODELS;

namespace Projet_Commerce_Electronique.CONTROLLERS
{
    public class ClientController
    {
        IGeniricRepository<Client> clientRepository;

        public ClientController(IGeniricRepository<Client> clientRepository)
        {
            this.clientRepository = clientRepository;
        }

        public void AjouterClient(Client client)
        {
            clientRepository.insert(client);
        }

        public List<Client> GetAllClients()
        {
            return clientRepository.GetAll().ToList();
        }

        public Client GetClientById(int clientId)
        {
            return clientRepository.getByID(clientId);
        }

        public void UpdateClient(Client client)
        {
            clientRepository.update(client);
        }

        public void DeleteClient(int clientId)
        {
            var client = clientRepository.getByID(clientId);
            if (client != null)
            {
                clientRepository.deleteByID(client);
            }
        }
      


    }
}
