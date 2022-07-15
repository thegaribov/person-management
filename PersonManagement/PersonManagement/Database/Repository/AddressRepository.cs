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

        private static List<Address> adresList = new List<Address>();

        public static List<Address> GetAll()
        {
            return adresList;
        }

        public static void Remove(int id)
        {
            for (int i = 0; i < adresList.Count; i++)
            {
                if (id == adresList[i].Id)
                {
                    adresList.RemoveAt(i);
                }
            }
        }

        public static List<Address> Add(string name)
        {
            Address adress = new Address(name);

            adresList.Add(adress);
            return adresList;
        }

        public static void Update(int id, string name)
        {
            Address adress = new Address(name);
            for (int i = 0; i < adresList.Count; i++)
            {
                if (id == adresList[i].Id)
                {
                    adresList[i].Name = name;
                }
            }

        }










    }
}
