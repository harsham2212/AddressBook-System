using Address_Book;
using System;

namespace AddressBook_System
{
    class Program
    {
        static void Main(string[] args)
        {
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("Welcome to AddressBook Program");
                    Console.WriteLine("Enter options : \n 1. Create Contacts \n 2. Exit");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter the Contact details of FirstName, LastName, Address, City, State, Zip, Ph.no, Email");
                            ContactManager contact = new ContactManager()
                            {
                                FirstName = Console.ReadLine(),
                                LastName = Console.ReadLine(),
                                Address = Console.ReadLine(),
                                City = Console.ReadLine(),
                                State = Console.ReadLine(),
                                Zip = Console.ReadLine(),
                                PhoneNumber = Console.ReadLine(),
                                Email = Console.ReadLine(),
                            };
                            break;
                        case 2:
                            flag = false;
                            break;
                    }
                }
            }
        }
    }
