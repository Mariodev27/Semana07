using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class BClient
    {

        private DClient clientData;

        public BClient()
        {
            clientData = new DClient();
        }

        public List<Client> ListClients()
        {

            return clientData.ListarClientes();

        }

        public List<Client> GetByName(string Name)
        {

            List<Client> result = new List<Client>();

            DClient dClient = new DClient();

            var client = dClient.ListarClientes();

            foreach (var item in client)
            {

                if (item.Name == Name)
                {

                    result.Add(item);

                }

            }

            return result;

        }

        public List<Client> GetById(int id)
        {

            List<Client> result = new List<Client>();

            DClient dClient = new DClient();

            var client = dClient.ListarClientes();

            foreach (var item in client)
            {

                if (item.Id == id)
                {

                    result.Add(item);

                }

            }

            return result;

        }

        public void InsertClient(string name, string address, string phone)
        {

            clientData.InsertClient(name, address, phone);

        }

        public void DeleteClient(int id)
        {
            clientData.DeleteClient(id);
        }

        public void ActivateClient(int id)
        {

            clientData.ActivateClient(id);

        }

        public void UpdateClient(int id, string address, string phone)
        {

            clientData.UpdateClient(id, address, phone);

        }

    }
}