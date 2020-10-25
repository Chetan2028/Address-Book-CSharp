namespace UserAddressBook
{
    public class Contact
    {
        /// Variables
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public int zip;
        public long phoneNumber;
        public string email;

        /// <summary>
        /// Initializes a new instance of the <see cref="Contact"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="address">The address.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="zip">The zip.</param>
        /// <param name="phoneNumber">The phone number.</param>
        /// <param name="email">The email.</param>
        public Contact(string firstName, string lastName, string address, string city, string state, int zip, long phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        /// <summary>
        /// Gets the first name.
        /// </summary>
        /// <returns></returns>
        public string GetFirstName()
        {
            return firstName;
        }
        /// <summary>
        /// Gets the last name.
        /// </summary>
        /// <returns></returns>
        public string GetLastName()
        {
            return lastName;
        }
        /// <summary>
        /// Gets the address.
        /// </summary>
        /// <returns></returns>
        public string GetAddress()
        {
            return address;
        }
        /// <summary>
        /// Gets the city.
        /// </summary>
        /// <returns></returns>
        public string GetCity()
        {
            return city;
        }
        /// <summary>
        /// Gets the state.
        /// </summary>
        /// <returns></returns>
        public string GetState()
        {
            return state;
        }
        /// <summary>
        /// Gets the email.
        /// </summary>
        /// <returns></returns>
        public string GetEmail()
        {
            return email;
        }
        /// <summary>
        /// Gets the phone number.
        /// </summary>
        /// <returns></returns>
        public long GetPhoneNumber()
        {
            return phoneNumber;
        }
        /// <summary>
        /// Gets the zip.
        /// </summary>
        /// <returns></returns>
        public int GetZip()
        {
            return zip;
        }
        /// <summary>
        /// Sets the first name.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        public void SetFirstName(string firstName)
        {
            this.firstName = firstName;
        }
        /// <summary>
        /// Sets the last name.
        /// </summary>
        /// <param name="lastName">The last name.</param>
        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }
        /// <summary>
        /// Sets the address.
        /// </summary>
        /// <param name="address">The address.</param>
        public void SetAddress(string address)
        {
            this.address = address;
        }
        /// <summary>
        /// Sets the city.
        /// </summary>
        /// <param name="city">The city.</param>
        public void SetCity(string city)
        {
            this.city = city;
        }
        /// <summary>
        /// Sets the state.
        /// </summary>
        /// <param name="state">The state.</param>
        public void SetState(string state)
        {
            this.state = state;
        }
        /// <summary>
        /// Sets the zip.
        /// </summary>
        /// <param name="zip">The zip.</param>
        public void SetZip(int zip)
        {
            this.zip = zip;
        }
        /// <summary>
        /// Sets the phone number.
        /// </summary>
        /// <param name="phoneNumber">The phone number.</param>
        public void SetPhoneNumber(long phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }
        /// <summary>
        /// Sets the email.
        /// </summary>
        /// <param name="email">The email.</param>
        public void SetEmail(string email)
        {
            this.email = email;
        }
        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        override
        public string ToString()
        {
            return "FirstName : " + firstName + " LastName : " + lastName + " Address : " + address + " City : " + city + "State : " + state +
                " Zip Code :" + zip + " Phone Number : " + phoneNumber + " Email Id : " + email;
        }
    }
}
