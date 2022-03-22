using System;
using System.Collections.Generic;

namespace AddressBook
{
    class Contacts
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public string City;
        public string State;
        public int ZipCode = 0;
        public int PhoneNumber = 0;
        public string Email;
        public Contacts()
        {
            Console.Write("Enter First Name: ");
            FirstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            LastName = Console.ReadLine();
            Console.Write("Enter Address: ");
            Address = Console.ReadLine();
            Console.Write("Enter City: ");
            City = Console.ReadLine();
            Console.Write("Enter State: ");
            State = Console.ReadLine();
            Console.Write("Enter Zip Code: ");
            ZipCode = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Phone Number: ");
            PhoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Email Address: ");
            Email = Console.ReadLine();
        }
    }
    class AddressBook
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            Contacts book = new Contacts();
        }
    }
}