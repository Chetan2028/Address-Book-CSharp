using System;
using System.Collections.Generic;
using System.Text;

namespace UserAddressBook
{
    interface AddressBookImplementation
    {
        /// <summary>
        /// Adds the contact.
        /// </summary>
        public void AddContact();

        /// <summary>
        /// Views the contact.
        /// </summary>
        public void ViewContact();

        /// <summary>
        /// Deletes the contact.
        /// </summary>
        public void DeleteContact();

        /// <summary>
        /// Edits the contact.
        /// </summary>
        public void EditContact();
    }
}
