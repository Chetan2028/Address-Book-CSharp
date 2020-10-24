using System;
using System.Collections.Generic;
using System.Text;

namespace UserAddressBook
{
    class AddressBook
    {
        /// <summary>
        /// Adds the contact.
        /// </summary>
        public void AddContact()
        {
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter your address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter your city name");
            string city = Console.ReadLine();
            Console.WriteLine("Enter your state");
            string state = Console.ReadLine();
            Console.WriteLine("Enteryour zip code");
            int zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your phone number");
            int phoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Email-Id");
            string email = Console.ReadLine();

            ///Creates a reference of Contact class
            Contact contact = new Contact(firstName, lastName, address, city, state, zip, phoneNumber, email);
            Console.WriteLine(contact);
        }
    }
}
