using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagement.Database.Models
{
    class Employee
    {
       
        public int Id { get; set; }
        private static int IdCounter = 1;
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string Fin { get; set; }
        public string Email { get; set; }

        public Employee(string name, string lastName, string fatherName, string fin, string email)
        {
            Id = IdCounter++;

            Name = name;
            LastName = lastName;
            FatherName = fatherName;
            Fin = fin;
            Email = email;



        }
    }
}
