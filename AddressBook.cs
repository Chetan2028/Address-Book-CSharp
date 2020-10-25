using System;
using System.Collections.Generic;
using System.Text;

namespace UserAddressBook
{
    public class AddressBook
    {
        /// Creates a list to store contact
        List<Contact> contactList;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressBook"/> class.
        /// </summary>
        public AddressBook()
        {
            contactList = new List<Contact>();
        }

        /// Adds the contact  
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
            Console.WriteLine("Enter your zip code");
            int zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your phone number");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your Email-Id");
            string email = Console.ReadLine();

            ///Creates a reference of Contact class
            Contact contact = new Contact(firstName, lastName, address, city, state, zip, phoneNumber, email);

            if(CheckingForSpaces(firstName, lastName))
            {
                Console.WriteLine("Please Enter Valid Contact Names");
            }
            else
            {
                CheckForDuplicates(contact, firstName, lastName);
            }

        }

        /// <summary>
        /// Checking whether the Name of contact contains whitespaces or null
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <returns></returns>
        public bool CheckingForSpaces(string firstName , string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName) && string.IsNullOrWhiteSpace(lastName))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Checks for duplicates.
        /// </summary>
        /// <param name="contact">The contact.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        public void CheckForDuplicates(Contact contact , string firstName , string lastName)
        {
            if (contactList.Count == 0)
            {
                contactList.Add(contact);
                Console.WriteLine("Contact Added Successfully!!!!!");
            }
            else
            {
                for (int index = 0; index < contactList.Count; index++)
                {
                    if (contactList[index].GetFirstName().Equals(firstName) && contactList[index].GetLastName().Equals(lastName))
                    {
                        Console.WriteLine("Contact already present");
                    }
                    else
                    {
                        contactList.Add(contact);
                        Console.WriteLine("Contact Added Successfully!!!!!");
                    }
                }
            }
        }
        /// <summary>
        /// Displays the menu.
        /// </summary>
        public void DisplayMenu()
        {
            Console.WriteLine("Enter your choice");
            Console.WriteLine("Press 1 to Add contact");
            Console.WriteLine("Press 2 to Edit contact");
            Console.WriteLine("Press 3 to Delete contact");
            Console.WriteLine("Press 4 to View Contact Details");
            Console.WriteLine("Press 5 to Exit");
        }

        /// <summary>
        /// This method shows the menu for editing the contact
        /// </summary>
        public void EditMenu()
        {
            Console.WriteLine("Enter 1 to Edit FirstName");
            Console.WriteLine("Enter 2 to Edit LastName");
            Console.WriteLine("Enter 3 to Edit Address");
            Console.WriteLine("Enter 4 to Edit City");
            Console.WriteLine("Enter 5 to Edit State");
            Console.WriteLine("Enter 6 to Edit PhoneNumber");
            Console.WriteLine("Enter 7 to Edit Zip");
            Console.WriteLine("Enter 8 to Edit Email");
        }
        /// <summary>
        /// This method is used to edit the contact
        /// </summary>
        public void EditContact()
        {
            Console.WriteLine("Enter your first name of the contact you want to edit");
            string userName = Console.ReadLine();

            for (int index = 0; index < contactList.Count; index++)
            {
                if (contactList[index].GetFirstName().Equals(userName))
                {
                    EditMenu();
                    EditContactList(contactList[index]);
                    Console.WriteLine("Contact's Detail is modified successfully");
                }
                else
                {
                    Console.WriteLine("First Name Not found");
                }
            }
        }

        /// <summary>
        /// Edits the contact list.
        /// </summary>
        /// <param name="contact">The contact.</param>
        public void EditContactList(Contact contact)
        {
            Console.WriteLine("Enter your choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the first name");
                    string name = Console.ReadLine();
                    contact.SetFirstName(name);
                    break;
                case 2:
                    Console.WriteLine("Enter the last name");
                    string lastName = Console.ReadLine();
                    contact.SetLastName(lastName);
                    break;
                case 3:
                    Console.WriteLine("Enter address");
                    string address = Console.ReadLine();
                    contact.SetAddress(address);
                    break;
                case 4:
                    Console.WriteLine("Enter city");
                    string city = Console.ReadLine();
                    contact.SetCity(city);
                    break;
                case 5:
                    Console.WriteLine("Enter state");
                    string state = Console.ReadLine();
                    contact.SetState(state);
                    break;
                case 6:
                    Console.WriteLine("Enter Phone Number");
                    long phoneNumber = Convert.ToInt64(Console.ReadLine());
                    contact.SetPhoneNumber(phoneNumber);
                    break;
                case 7:
                    Console.WriteLine("Enter Zip code");
                    int zip = Convert.ToInt32(Console.ReadLine());
                    contact.SetZip(zip);
                    break;
                case 8:
                    Console.WriteLine("Enter Email");
                    string email = Console.ReadLine();
                    contact.SetEmail(email);
                    break;
                default:
                    Console.WriteLine("Enter valid choice");
                    break;
            }
        }

        /// <summary>
        /// Deletes the contact.
        /// </summary>
        public void DeleteContact()
        {
            Console.WriteLine("Enter the Contact's First Name which you want to delete");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the Contact's Last nane which you want to delete");
            string lastName = Console.ReadLine();

            for (int index = 0; index < contactList.Count; index++)
            {
                if (contactList[index].GetFirstName().Equals(firstName))
                {
                    if (contactList[index].GetLastName().Equals(lastName))
                    {
                        contactList.RemoveAt(index);
                        Console.WriteLine("Contact deleted successfully!!!!!");
                    }
                }
                else
                {
                    Console.WriteLine("Contact name not  found");
                }
            }
        }

        /// <summary>
        /// This method is used to view the contact details
        /// </summary>
        public void ViewContact()
        {
            ///Checks for the length of List
            ///If it is empty then it wont display any elements
            if (contactList.Count != 0)
            {
                for (int index = 0; index < contactList.Count; index++)
                {
                    Console.WriteLine("First Name      :       " + contactList[index].GetFirstName());
                    Console.WriteLine("Last Name       :       " + contactList[index].GetLastName());
                    Console.WriteLine("Address         :       " + contactList[index].GetAddress());
                    Console.WriteLine("City            :       " + contactList[index].GetCity());
                    Console.WriteLine("State           :       " + contactList[index].GetState());
                    Console.WriteLine("Phone Number    :       " + contactList[index].GetPhoneNumber());
                    Console.WriteLine("Zip             :       " + contactList[index].GetZip());
                    Console.WriteLine("Email           :       " + contactList[index].GetEmail());
                    Console.WriteLine("/************************************************************/");
                }
            }
            else
            {
                Console.WriteLine("Address Book is empty . No contacts to display");
            }
        }
        /// <summary>
        /// This method provides the operations performed by Address Book
        /// </summary>
        public void AddressBookMenu()
        {
            bool flag = true;
            while (flag)
            {
                DisplayMenu();
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddContact();
                        break;
                    case 2:
                        EditContact();
                        break;
                    case 3:
                        DeleteContact();
                        break;
                    case 4:
                        ViewContact();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}
