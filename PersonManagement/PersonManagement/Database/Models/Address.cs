using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagement.Database.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private static int IdCounter { get; set; }


        public Address(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
