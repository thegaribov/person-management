using PersonManagement.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagement.Database.Repository
{
    class AddressRepository
    {
        private static List<Address> addresses = new List<Address>();


        public List<Address> Add(string name)
        {
            Address address = new Address(name);

            addresses.Add(address);

            return addresses;

        }

        public void Remove(int id)
        {
            for (int i = 0; i < addresses.Count; i++)
            {
                if (id == addresses[i].Id)
                {
                    addresses.RemoveAt(i);
                }
            }
        }

        public List<Address> GetAll()
        {
            return addresses;
        }

    }
}
