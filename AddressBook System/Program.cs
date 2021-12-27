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
                    Console.WriteLine("Welcome to AddressBook Program\n ");
                    Console.WriteLine("Enter options : \n 1. Create Contacts \n 2. Add New Contact \n 3. Edit Contact \n 4. Delete Contact \n " +
                        "5. Add Multiple Contact \n 6. Refactor Code \n 7.Check Duplicates Name\n 8.Search Person using State or City\n " +
                        "9.View by State or City\n 10. Count By State or City\n 11. AddressBook Sorting\n 12. Sorting entries by City, State or Zipcode \n " +
                        "13. Read or Write in Address Book Using File I/O \n 14. Read and Write in Address Book using CSV \n 15.Read and Write in Address Book using JSON\n " +
                        "16. Exit");
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
                        Console.WriteLine("Enter the Contact to Add : FirstName, LastName, Addr, City, State, Zip, Ph.No, Email.");
                        Console.WriteLine("Enter the Contact to Add: ");
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
                        Console.WriteLine("Enter the Contact Name to Edit: ");
                        string name = Console.ReadLine();
                        NewContact edit = new NewContact();
                        edit.EditContact(name);
                        edit.Display();
                        break;
                    case 4:
                        Console.WriteLine("Enter the Contact Name to Deleted: ");
                        string user = Console.ReadLine();
                        NewContact del = new NewContact();
                        del.DeleteContact(user);
                        del.Display();
                        break;
                    case 5:
                        Console.WriteLine("Enter the Contact to Add in form of FirstName, LastName, Addr, City, State, Zip, Ph.No, Email.");
                        Console.WriteLine("Enter the Contact to Add: ");
                        ContactManager con = new ContactManager();
                        NewContact abo = new NewContact();
                        abo.AddContact(con);
                        con.FirstName = Console.ReadLine();
                        con.LastName = Console.ReadLine();
                        con.Address = Console.ReadLine();
                        con.City = Console.ReadLine();
                        con.State = Console.ReadLine();
                        con.Zip = Console.ReadLine();
                        con.PhoneNumber = Console.ReadLine();
                        con.Email = Console.ReadLine();
                        abo.Display();
                        break;
                    case 6:
                        Console.WriteLine("Enter the Unique Contact to be added: ");
                        string nam = Console.ReadLine();
                        NewContact aboo = new NewContact();
                        aboo.AddUniqueContact(nam);
                        aboo.DisplayUniqueContacts();
                        break;
                    case 7:
                        NewContact search = new NewContact();
                        search.CheckDuplicateEntry();
                        break;
                    case 8:
                        Console.WriteLine("Select the options to Check\n 1. City \n 2. State");
                        int number = Convert.ToInt32(Console.ReadLine());
                       
                        if (number == 1)
                        {
                            NewContact City = new NewContact();
                            City.PersonInCity();
                        }
                        if (number == 2)
                        {
                            NewContact State = new NewContact();
                            State.ForState();
                        }
                        break;
                    case 9:
                        NewContact View=new NewContact();
                        View.View_person_city_state();
                        break;
                    case 10:
                        Console.WriteLine("Select the options to Check\n 1. CityCount \n 2. StateCount");
                        int num = Convert.ToInt32(Console.ReadLine());
                        if (num == 1)
                        {
                            NewContact addressBookk = new NewContact();
                            addressBookk.CityCount();
                        }
                        if (num == 2)
                        {
                            NewContact addreSsBook = new NewContact();
                            addreSsBook.StateCount();
                        }
                        break;
                    case 11:
                        NewContact sort = new NewContact();
                        sort.AddressBookSorting();
                        break;
                    case 12:
                        NewContact sortbysate = new NewContact();
                        sortbysate.Sorting();
                        break;
                    case 13:
                        NewContact read = new NewContact();
                        read.ReadFile();
                        read.WritingUsingStreamWriter();
                        break;
                    case 14:
                        NewContact.ImplementAddressBookinCsv();
                        break;
                    case 15:
                        NewContact.ImplementAddressBookinJson();
                        break;
                    case 16:
                        flag = false;
                            break;
                    }
                }
            }
        }
    }
