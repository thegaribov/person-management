
using PersonManagement.Database.Models;
using PersonManagement.Database.Repository;
using System;
using System.Collections.Generic;
using PersonManagement.ApplicationLogic;

namespace PersonManagement.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose commands:");
            Console.WriteLine("Employee");
            Console.WriteLine("Address");
            while (true)
            {
                string command = Console.ReadLine();


                if (command == "Employee")
                {
                    Console.WriteLine("Add");
                    Console.WriteLine("Update");
                    Console.WriteLine("Get all");
                    Console.WriteLine("Remove");
                    string commandEmployee = Console.ReadLine();

                    if (commandEmployee == "Add")
                    {
                        Console.WriteLine("Add Employee Name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Add Employee Lastname:");
                        string lastname = Console.ReadLine();
                        Console.WriteLine("Add Employee Fathername:");
                        string fathername = Console.ReadLine();
                        Console.WriteLine("Add Employee FIN:");
                        string fin = Console.ReadLine();
                        Console.WriteLine("Add Employee Email:");
                        string mail = Console.ReadLine();
                        
                        if(Validations.IsNameTrue(name) & Validations.IsLastNameTrue(lastname) & Validations.IsFatherNameTrue(fathername) & Validations.IsFinTrue(fin) & Validations.IsEmailTrue(mail))
                        {
                            EmployeeRepository.Add(name, lastname, fathername, fin, mail);
                            Console.WriteLine($"{name} {lastname} added");
                        }
                        
                    }

                    else if (commandEmployee == "Get all")
                    {
                        List<Employee> employees = EmployeeRepository.GetAll();
                        foreach (Employee employee in employees)
                        {
                            Console.WriteLine(employee.Name + employee.LastName);                           
                        }
                    }
                    else if (commandEmployee == "Remove")
                    {
                        Console.WriteLine("Write id:");
                        int idRemove = int.Parse(Console.ReadLine());

                        EmployeeRepository.Remove(idRemove);

                    }
                    else if (commandEmployee == "Update")
                    {
                        Console.WriteLine("Write id:");
                        int id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Write Employee Name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Write Employee Lastname:");
                        string lastname = Console.ReadLine();
                        Console.WriteLine("Write Employee Fathername:");
                        string fathername = Console.ReadLine();
                        Console.WriteLine("Write Employee FIN:");
                        string fin = Console.ReadLine();
                        Console.WriteLine("Write Employee Email:");
                        string mail = Console.ReadLine();

                        EmployeeRepository.Update(id,name,lastname,fathername,fin,mail);

                    }                  
                    else
                    {
                        Console.WriteLine("command not found");
                    }

                }
                else if (command == "Address")
                {


                    Console.WriteLine("Add");
                    Console.WriteLine("Update");
                    Console.WriteLine("Get all");
                    Console.WriteLine("Remove");
                    string commandAddress = Console.ReadLine();

                    if (commandAddress == "Add")
                    {
                        Console.WriteLine("Add address name:");
                        string name = Console.ReadLine();
                        AddressRepository.Add(name);
                        Console.WriteLine($"{name} added");
                    }

                    else if (commandAddress == "Get all")
                    {
                        List<Address> addresses = AddressRepository.GetAll();
                        foreach (Address address in addresses)
                        {
                            Console.WriteLine(address.Name);
                        }
                    }
                    else if (commandAddress == "Remove")
                    {
                        Console.WriteLine("Write id:");
                        int idRemove = int.Parse(Console.ReadLine());

                        AddressRepository.Remove(idRemove);

                    }
                    else if (commandAddress == "Update")
                    {
                        Console.WriteLine("Write id:");
                        int id = int.Parse(Console.ReadLine());

                        Console.WriteLine("write name address");
                        string adressname = Console.ReadLine();

                        AddressRepository.Update(id, adressname);

                    }
                    else if (commandAddress == "Get Id")
                    {
                        Console.WriteLine(AddressRepository.GetId(Console.ReadLine()));

                    }
                    else
                    {
                        Console.WriteLine("command not found");
                    }



                }
                else
                {
                    Console.WriteLine("Command not found");
                }

            }





        }
    }


}