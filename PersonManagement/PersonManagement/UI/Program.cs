using PersonManagement.Database.Models;
using PersonManagement.Database.Repository;
using System;
using System.Collections.Generic;

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