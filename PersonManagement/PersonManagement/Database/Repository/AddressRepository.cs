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
                    break;
                }
            }
            for (int i = id + 1; i < adresList.Count; i++)
            {
                adresList[i].Id = i - 1;
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
        public static int GetId(string name)
        {
            for (int i = 0; i < adresList.Count; i++)
            {
                if (name == adresList[i].Name)
                {
                    return adresList[i].Id;
                }
            }
            return -1;
        }










    }
}
