using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

/* Manager Class
 * *************
 * This is used to manage mostly all things that happen with the contacts,
 * The adding delete and editing of a contact.
 * Also searching for a contact by either name or number so can be used when editing or deleting a contact.
 */
namespace Assignment1
{
    class Manager
    {
        private List<Contact> contactList = new List<Contact>(); // This contains all the contacts which are saved in the /contacts.txt file.

        // A method which adds a contact to the already created list above, an object is need to contain that information about the contact.
        public Contact addContact(string name, string number, bool load = false)
        {
            Contact newContact = new Contact(name, number);
            contactList.Add(newContact);

            // Checks to see if the contacts have been loaded.
            if(load == false)
            {
                newContact.savingContact();
            }
            // What the method returns.
            return newContact;
        }
        
        // A method that get this list of contacts and makes it accessible by other classes, by making it public.
        public List<Contact> retrieveContacts()
        {
            // What the method returns.
            return contactList;
        }

        // Method that reads the /contacts.txt file and returns the contacts by name, which is used when editing and deleting a contact.
        public Contact retrieveContactsByName(string name)
        {
            Contact foundContact = null;
            
            //Starts a loop which reads each contact by name.
            foreach(Contact contact in retrieveContacts())
            {
                //What happens in the for loop this is for the name being found.
                if(contact.Name == name)
                {
                    foundContact = contact;
                    break;
                }
            }
            // This is what the method returns.
            return foundContact;
        }

        // Method that read the /contacts.txt file and returns the contacts by number, this will also be used when editing and deleting a contact
        public Contact retrieveContactsByNumber(string number)
        {
            Contact foundContact = null;
            // Starts the loop which reads each contact by number
            foreach(Contact contact in retrieveContacts())
            {
                // What happens in the for loop this is for the number being found
                if (contact.Number == number)
                {
                    foundContact = contact;
                    break;
                }
            }
            // This is what the method returs
            return foundContact;
        }

        // Method that loads the contacts from the /contacts.txt file and splits them from the single line entry to the text file
        public void loadContacts()
        {
            // Tempoarily saves contact when loading from /contacts.txt file
            string displayContact;
            
            // Find the loaction of the /contacts.txt file
            string Local = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            // Checks if the file /contacts.txt file exists
            if (File.Exists(Local + "/contacts.txt"))
            {
                // Starts a new StreamReader reading for /contacts.txt file
                StreamReader sr = new StreamReader(Local + "/contacts.txt");

                // Reads the users input and starts a while loop
                while ((displayContact = sr.ReadLine()) != null)
                {
                    // Creates an array to load the contacts, checks for :: to split into naame and number
                    string[] displayContactSplit = displayContact.Split(new string[] { "::" }, StringSplitOptions.None);

                    // Displays the contents of the /contacts.txt file
                    addContact(displayContactSplit[0], displayContactSplit[1], true);
                }
                sr.Close();
            }
        }
        
        // Method that saves the contacts to the /contacts.txt file and saves them as one line seperating them with :: to make it easier later when reading the text file
        public void saveContacts()
        {
            // Finds where the /contacts.txt file is located
            string Local = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            
            // Opens a new StreamWriter, which allows writing to a .txt file and others 
            using (StreamWriter sw = new StreamWriter(Local + "/contacts.txt"))
            {
                // Sets a loop for every contact that has been retrieve to then be saved
                foreach(Contact contact in retrieveContacts())
                {
                    // What gets written into the text file, notice the :: seperating the contact
                    sw.WriteLine(contact.Name + "::" + contact.Number);
                }
                sw.Close();
            }
        }

        // Method that reads /contacts.txt file and deletes the contact which user has inputted to
        public void deleteContact(Contact contact)
        {
            // Deletes the users inputted contact
            contactList.Remove(contact);
            saveContacts();
        }
    }
}