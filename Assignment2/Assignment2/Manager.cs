using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Assignment2
{
    static class Manager
    {
        #region Contact Object

        // List for the contact objects

        static public List<Contact> contactList = new List<Contact>();

        // Contact Object

        static public Contact AddContact (string title, string firstName, string lastName, string address, string city, string county, string postcode, string  phoneNumber, string email, string birthdate, string description, string imageLocation, bool load = false)
        {
            Contact newContact = new Contact(title, firstName, lastName, address, city, county, postcode, phoneNumber, email, birthdate, description, imageLocation);
            contactList.Add(newContact);
            if(load == false)
            {
                newContact.SaveContact();
            }
            return newContact;
        }

        // Returning found contacts

        static public List<Contact> FoundContacts()
        {
            return contactList;
        }

        #endregion

        #region Contact Methods

        // This saves the contact.

        static public void SaveContact()
        {
            // Finds where the local directoy is

            string Local = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            File.Delete(Local + "/contacts.txt");
            
            using (StreamWriter sw = new StreamWriter(Local + "/contacts.txt"))

                foreach (Contact contact in FoundContacts())
                {
                    sw.WriteLine(contact.Title + "," + contact.FirstName + "," + contact.LastName + "," + contact.Address + "," + contact.City + "," + contact.County + "," + contact.Postcode + "," + contact.PhoneNumber + "," + contact.Email + "," + contact.Description + "," + contact.ImageLocation);
                }
            
        }

        // Method for deleting a contact

        static public void DeleteContact(Contact contact)
        {
            contactList.Remove(contact);
        }

        // Method that finds a contact by name

        static public Contact ContactByFirstName(string firstName)
        {
            Contact foundContact = null;

            foreach (Contact contact in FoundContacts())
            {
                if (contact.FirstName == firstName)
                {
                    foundContact = contact;
                    break;
                }
            }
            return foundContact;
        }

        // Method that find a contact by number

        static public Contact ContactByNumber(string phoneNumber)
        {
            Contact foundContact = null;

            foreach (Contact contact in FoundContacts())
            {
                if (contact.PhoneNumber == phoneNumber)
                {
                    foundContact = contact;
                    break;
                }
            }
            return foundContact;
        }

        #endregion
    }
}