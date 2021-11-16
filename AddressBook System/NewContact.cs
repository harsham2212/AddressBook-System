﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook_System
{
    class NewContact
    {
        List<ContactManager> addressList = new List<ContactManager>();
        public void AddContact(ContactManager contact) // This Method Will Add the Details of Customer
        {
            addressList.Add(contact);
        }
        public void Display() // This Method wii Display the Details
        {
            foreach (var contact in addressList)
            {
                Console.WriteLine(contact.FirstName + " " + contact.LastName);
                Console.WriteLine("Last Name: " + contact.LastName);
                Console.WriteLine("Address : " + contact.Address);
                Console.WriteLine("City : " + contact.City);
                Console.WriteLine("State : " + contact.State);
                Console.WriteLine("Zip : " + contact.Zip);
                Console.WriteLine("PhoneNumber : " + contact.PhoneNumber);
                Console.WriteLine("Email : " + contact.Email);
            }
        }
    }
}