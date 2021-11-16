﻿using System;

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
                    Console.WriteLine("Enter options : \n 1. Create Contacts \n 2. Add New Contact \n 3. Edit Contact \n 4. Delete Contact \n 5. Exit");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter the Contact details of FirstName, LastName, Address, City, State, Zip, Ph.no, Email");
                            ContactManager newcontact = new ContactManager()
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
                        Console.WriteLine("Enter the Contact to be Add : FirstName, LastName, Addr, City, State, Zip, Ph.No, Email.");
                        Console.WriteLine("Enter the Contact to be Add: ");
                        ContactManager contact = new ContactManager();
                        NewContact addressBook = new NewContact();
                        addressBook.AddContact(contact);
                        contact.FirstName = Console.ReadLine();
                        contact.LastName = Console.ReadLine();
                        contact.Address = Console.ReadLine();
                        contact.City = Console.ReadLine();
                        contact.State = Console.ReadLine();
                        contact.Zip = Console.ReadLine();
                        contact.PhoneNumber = Console.ReadLine();
                        contact.Email = Console.ReadLine();
                        addressBook.Display();
                        break;
                    case 3:
                        Console.WriteLine("Enter the Contact Name to be Edit: ");
                        string name = Console.ReadLine();
                        NewContact edit = new NewContact();
                        edit.EditContact(name);
                        edit.Display();
                        break;
                    case 4:
                        Console.WriteLine("Enter the Contact Name to be Deleted: ");
                        string user = Console.ReadLine();
                        NewContact del = new NewContact();
                        del.DeleteContact(user);
                        del.Display();
                        break;
                    case 5:
                            flag = false;
                            break;
                    }
                }
            }
        }
    }
