using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace UserAddressBook
{
    public class AddressBook : AddressBookImplementation
    {
        /// Creates a list to store contact
        List<Contact> contactList = new List<Contact>();

        /// To store address book in  Dictionary of address books
        Dictionary<string, AddressBook> addressBookDictionary = new Dictionary<string, AddressBook>();

        //Dictionary to store Person name and city
        Dictionary<string, string> cityDictionary = new Dictionary<string, string>();

        //Dictionary to store Person name and state
        Dictionary<string, string> stateDictionary = new Dictionary<string, string>();

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
            Console.WriteLine("Enter your zip code");
            int zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your phone number");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your Email-Id");
            string email = Console.ReadLine();

            ///Creates a reference of Contact class
            Contact contact = new Contact(firstName, lastName, address, city, state, zip, phoneNumber, email);

            if (CheckingForSpaces(firstName, lastName))
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
        public bool CheckingForSpaces(string firstName, string lastName)
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
        public void CheckForDuplicates(Contact contact, string firstName, string lastName)
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
                    return;
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
            Console.WriteLine("Press 5 to Sort the Contacts by names");
            Console.WriteLine("Press 6 to Sort the Contacts by  zip code");
            Console.WriteLine("Press 7 to sort the Contacts by  state");
            Console.WriteLine("Press 8 to sort the Contacts by city");
            Console.WriteLine("Press 9 to exit");
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
        /// Addresses the book system display menu.
        /// </summary>
        public void AddressBookSystemDisplayMenu()
        {
            Console.WriteLine("Enter your choice");
            Console.WriteLine("Press 1 to Add a Address book");
            Console.WriteLine("Press 2 to Access a Address book");
            Console.WriteLine("Press 3 to Search person by city");
            Console.WriteLine("Press 4 to View Contacts By State or City");
            Console.WriteLine("Press  5 to Exit");
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
            while(flag)
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
                    case 5:
                        SortByNames();
                        break;
                    case 6:
                        SortByZip();
                        break;
                    case 7:
                        SortByState();
                        break;
                    case 8:
                        SortByCity();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
            
        }

        /// <summary>
        /// Gets the name of the existing book.
        /// </summary>
        /// <returns></returns>
        public string getExistingBookName()
        {
            Console.WriteLine("Enter the name of Address Book u want to access");
            string name = Console.ReadLine();
            return name;
        }

        /// <summary>
        /// Creates the Address Book
        /// </summary>
        /// <returns></returns>
        public string getAddressBookName()
        {
            Console.WriteLine("Enter the name of new Address Book");
            string name = Console.ReadLine();
            return name;
        }
        /// <summary>
        /// Addresses the book system menu.
        /// </summary>
        public void AddressBookSystemMenu()
        {
            bool flag = true;
            while (flag)
            {
                AddressBookSystemDisplayMenu();
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        string bookName = getAddressBookName();
                        if (addressBookDictionary.ContainsKey(bookName))
                        {
                            Console.WriteLine("Sorry book already exists with name " + bookName);
                        }
                        else
                        {
                            AddressBook addressBook = new AddressBook();
                            addressBookDictionary.Add(bookName, addressBook);
                            Console.WriteLine("address book with " + bookName + "  is created");
                            addressBook.AddressBookMenu();
                        }
                        break;
                    case 2:
                        string existingBookName = getExistingBookName();
                        if (addressBookDictionary.ContainsKey(existingBookName))
                        {
                            AddressBook addressBook = new AddressBook();
                            Console.WriteLine("Welcome to " + existingBookName);
                            addressBookDictionary[existingBookName].AddressBookMenu();
                        }
                        else
                        {
                            Console.WriteLine("Sorry Address book does not exists");
                        }
                        break;
                    case 3:
                        SearchContactsByCity();
                        break;
                    case 4:
                        ViewContactsByStateOrCity();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice!!!!!");
                        flag = false;
                        break;
                }
            }
        }
        /// <summary>
        /// UC8
        /// Searches the contacts by city.
        /// </summary>
        public void SearchContactsByCity()
        {
            string currentAddressBook;
            int count = 0;
            Console.WriteLine("Please enter city name");
            string city = Console.ReadLine();

            foreach (var key in addressBookDictionary.Keys)
            {
                currentAddressBook = key;
                for (int i = 0; i < addressBookDictionary[currentAddressBook].contactList.Count; i++)
                {
                    if (addressBookDictionary[currentAddressBook].contactList.ToArray()[i].GetCity().Equals(city))
                    {
                        Console.WriteLine("Contacts with city " + city + " as city in address book" + currentAddressBook + "\n"+ addressBookDictionary[currentAddressBook].contactList.ToArray()[i] + "\n");
                    }
                    else
                    {
                        count++;
                    }
                }
            }
            if (count > 0)
            {
                Console.WriteLine("No such contacts present in any existing address book");
            }
        }

        /// <summary>
        /// UC9
        /// Views the contacts by state or city.
        /// </summary>
        public void ViewContactsByStateOrCity()
        {
            int cityCount = 0;
            int stateCount = 0;
            foreach (var item in addressBookDictionary.Keys)
            {
                string currentAddressBook = item;
                for (int i = 0; i < addressBookDictionary[currentAddressBook].contactList.Count; i++)
                {
                    string state = addressBookDictionary[currentAddressBook].contactList.ToArray()[i].GetState();
                    string city = addressBookDictionary[currentAddressBook].contactList.ToArray()[i].GetCity();
                    string firstName = addressBookDictionary[currentAddressBook].contactList.ToArray()[i].GetFirstName();
                    string lastName = addressBookDictionary[currentAddressBook].contactList.ToArray()[i].GetLastName();
                    string name = firstName + " " + lastName;

                    cityDictionary.Add(name, city);
                    cityCount++;
                    stateDictionary.Add(name, state);
                    stateCount++;
                }
            }

            ///TO getcount of cites and state
            Console.WriteLine("COunt of cities : " + cityCount);
            Console.WriteLine("Count of states : " + stateCount);
            Console.WriteLine("Contacts by City : ");
            foreach (var item in cityDictionary)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            Console.WriteLine("Contacts By state");
            foreach (var item in stateDictionary)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }
        }

        /// <summary>
        /// UC11
        /// Sorts  by names.
        /// </summary>
        public void SortByNames()
        {
            List<String> nameList = new List<string>();
            foreach (Contact contact in contactList)
            {
                nameList.Add(contact.GetFirstName());
            }
            nameList.Sort();
            foreach (var element in nameList)
            {
                Console.WriteLine(element);
            }
        }

        /// <summary>
        /// Sorts zip.
        /// </summary>
        public void SortByZip()
        {
            List<int> zipList = new List<int>();
            foreach (Contact zip in contactList)
            {
                zipList.Add(zip.GetZip());
            }
            zipList.Sort();
            foreach (var item in zipList)
            {
                Console.WriteLine(item);
            }
        }
        /// <summary>
        /// Sorts city.
        /// </summary>
        public void SortByCity()
        {
            List<string> cityList = new List<string>();
            foreach (Contact city in contactList)
            {
                cityList.Add(city.GetCity());
            }
            cityList.Sort();
            foreach (var item in cityList)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Sorts the state 
        /// </summary>
        public void SortByState()
        {
            List<string> stateList = new List<string>();
            foreach(Contact state in contactList)
            {
                stateList.Add(state.GetState());
            }
            stateList.Sort();
            foreach (var item in stateList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
