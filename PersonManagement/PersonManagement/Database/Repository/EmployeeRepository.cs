using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagement.Database.Repository
{
    internal class EmployeeRepository
    {
        public static List<Models.Employee> _employees = new List<Models.Employee>();
        public void Add(string name , string lastname,string fathername,string fin ,string mail)
        {
            Models.Employee employe = new Models.Employee(name,lastname,fathername,fin,mail);
            _employees.Add(employe);

        }
        public void Delete(int id)
        {
            for(int i = 0; i < _employees.Count; i++)
            {
                if (_employees[i].Id == id)
                {
                    _employees.RemoveAt(i);
                }
            }


        }
    }
}
