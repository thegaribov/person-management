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
        public static void Add(string name, string lastname, string fathername, string fin, string mail)
        {
            Models.Employee employe = new Models.Employee(name, lastname, fathername, fin, mail);
            _employees.Add(employe);

        }
        public static void Remove(int id)
        {
            for (int i = 0; i < _employees.Count; i++)
            {
                if (_employees[i].Id == id)
                {
                    _employees.RemoveAt(i);
                    break;
                }
            }
            for (int i = id -1 ; i < _employees.Count; i++)
            {
                _employees[i].Id -= 1;
            }

        }
       
        public static Models.Employee GetEmployee(int id)
        {
            for (int i = 0; i < _employees.Count; i++)
            {
                if (_employees[i].Id == id)
                {
                    return _employees[i];

                }
            }
            return null;
        }
        public static void Update(int id, string name, string lastname, string fathername, string fin, string mail)
        {

            for (int i = 0; i < _employees.Count; i++)
            {
                if (_employees[i].Id == id)
                {
                    _employees[i].Name = name;
                    _employees[i].LastName = lastname;
                    _employees[i].FatherName = fathername;
                    _employees[i].Fin = fin;
                    _employees[i].Email = mail;
                    break;


                }
            }
        }
        public static bool IsFinUnique(string fin)
        {
            for (int i = 0; i < _employees.Count; i++)
            {
                if(fin == _employees[i].Fin)
                {
                    return false;
                }

            }
            return true;
        }
        public static bool IsEmailUnique(string mail)
       {
           for (int i = 0; i < _employees.Count; i++)
           {

                if (mail == _employees[i].Email)
                {
                    return false;
                }
           }
           return true;

        }

        public static List<Models.Employee> GetAll()
        {
            return _employees;
        }
        


    }
}