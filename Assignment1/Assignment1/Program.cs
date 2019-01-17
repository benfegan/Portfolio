using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*/ Program Class
 * ***************
 * This is where all of the methods come together and this is where the main working and menu systems are.
 * All the adding editing delelting forms are created here in there on methods
 * Menu system and switch statement is used to have different options to do
 * ***************
 */

namespace Assignment1
{
    class Program
    {
        // Creates access to the other class in the solution.
        // Manger is needed for dealing with things with the contact.
        Manager manager = new Manager();
        
        // Header is needed because the header needs to be at the top of the page.
        Header header = new Header();
        
        // Method that has the menu system that is printed to the screen.
        static void menuOptions()
        {
            // What the user will see and choose an option from the list
            Console.WriteLine("");
            Console.WriteLine("   Please choose from the menu below which option you would like.");
            Console.WriteLine("");
            Console.WriteLine("  1: Add Contact");
            Console.WriteLine("  2: Edit Contact");
            Console.WriteLine("  3: Delete Contact");
            Console.WriteLine("  4: Print Directory to Screen");
            Console.WriteLine("  5: Exit");
            Console.WriteLine("");
        }

        // Method that holds the adding a contact form, this contains the prompts to the user so they can add a contact correctly.
        private void addContactMessage()
        {
            // Clears the console of anything previously so the header doesn't repeat.
            Console.Clear();
            // Header is displayed
            Header.mainHeader();
            // This is the dynamic header which appears when in the add contact form.
            Console.WriteLine("│                           Adding a Contact                       │");
            Console.WriteLine("│──────────────────────────────────────────────────────────────────│");
            Console.WriteLine("");

            // Users name being added into the directory.
            Console.WriteLine("Enter the name of the person in the directory");
            Console.Write("Name: ");
            string inputName = Console.ReadLine();
            // Takes the inputted name and gives the person adding a contact a personalised message with the addition of there name.
            Console.WriteLine("Enter the telephone number {0} ", inputName);
            Console.Write("Number: ");
            string inputNumber = Console.ReadLine();

            // Uses the manager method to save the contact.
            manager.addContact(inputName, inputNumber);

            // Message to the user saying contact has been successfully added.
            Console.WriteLine("  \n" + inputName + " Contact successfully added, press enter to return");
            Console.ReadLine();
            // Clears the console so the header and menu doesnt repeat
            Console.Clear();
        }

        // Method that holds the editing a contact form, this contains the messages the user can interactive with.
        private void editContactMessage()
        {
            // Clears the console of anything before.
            Console.Clear();
            // Displays the header seen on all pages.
            Header.mainHeader();
            // Displays the dynamic header which you will see on what page you are one.
            Console.WriteLine("│                           Editing a Contact                      │");
            Console.WriteLine("│──────────────────────────────────────────────────────────────────│");
            Console.WriteLine("");

            // Users input for the choice of how they would like to edit a contact.
            Console.WriteLine("Enter 1 to edit a contact by name and 2 for nummber");
            Console.Write("Choice: ");
            // Converting the user input from Console.ReadLine(); to an int.
            int inputEditChoice = Convert.ToInt32(Console.ReadLine());
            // Main if statement.
            if(inputEditChoice == 1)
            {
                Console.WriteLine("Enter the name of the contact you want to edit");
                Console.Write("Name: ");
                string inputEditName = Console.ReadLine();

                // Accesses the manager class and the retrieve contact by name method to see if the contact is actually in the directory.
                Contact contactToEditName = manager.retrieveContactsByName(inputEditName);

                if(contactToEditName != null)
                {
                    Console.WriteLine("Enter the name you would like to change, press enter if you don't");
                    Console.Write("Name: ");
                    string inputNewName = Console.ReadLine();
                    
                    Console.WriteLine("");
                    Console.WriteLine("Contact name has been successfully changed, press enter to continue");
                    // Makes sure that if the user skipped editing the name the name didn't change.
                    if(inputNewName != "")
                    {
                        contactToEditName.Name = inputNewName;
                    }
                    // Saves the contact to the /contacts.txt file.
                    manager.saveContacts();
                }
                // If the contacts name isn't in the directory prompt the user.
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("There isn't a contact in the directory with that name, press enter to go back");
                }
            }
            // Second if for the 2 choice in the menu.
            else if (inputEditChoice == 2)
            {
                Console.WriteLine("Enter the number of the contact you would like to change");
                Console.Write("Number: ");
                string inputEditNumber = Console.ReadLine();

                // Access the manager class and the retrieve contact by number to see if that number is in the directory.
                Contact contactToEditNumber = manager.retrieveContactsByNumber(inputEditNumber);

                if(contactToEditNumber != null)
                {
                    Console.WriteLine("Enter the number you would like to change, press enter if you don't");
                    Console.Write("Number: ");
                    string inputNewNumber = Console.ReadLine();

                    Console.WriteLine("Contact number has been succssfully changed, press enter to continue");
                    // Checks to see if the user didnt input anything and then doesn't change the number.
                    if(inputNewNumber != "")
                    {
                        contactToEditNumber.Number = inputNewNumber;
                    }
                    // Saves the contact to the /contacts.txt file.
                    manager.saveContacts();
                }
                // If the contacts number isn't in the directory give a prompt.
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("There isn't that number in the directory, press enter to go back");
                }
            }
            Console.ReadLine();
            // Clears the console so the header and menu doesnt repeat.
            Console.Clear();
        }

        // Method that hold the deleting of a contact form, this conatins the message that the user can interactive with, and select there options.
        private void deleteContactMessage()
        {
            // Clears the console so anything before isn't displayed such as the menu system.
            Console.Clear();
            // Displays the main header seen on all pages.
            Header.mainHeader();
            // Displays the dynamic header which is only seen with in the form.
            Console.WriteLine("│                           Delete a Contact                       │");
            Console.WriteLine("│──────────────────────────────────────────────────────────────────│");
            Console.WriteLine("");

            Console.WriteLine("Enter 1 to delete a contact by name and 2 for number");
            Console.Write("Choice: ");
            // Converts the Console.ReadLine(); to int so can be used.
            int inputDeleteChoice = Convert.ToInt32(Console.ReadLine());
            // Main if statment for the option of searching by name.
            if(inputDeleteChoice == 1)
            {
                Console.WriteLine("Enter the name of the contact you would like to be removed");
                Console.Write("Name: ");
                string inputDeleteName = Console.ReadLine();
                // Access the class manager method retrieve contacts by name so a contact can be searched and removed.
                Contact deletedContactName = manager.retrieveContactsByName(inputDeleteName);

                if(deletedContactName != null)
                {
                    // Deletes the contact from the /contacts.txt file by access the class manager and method deleteContact.
                    manager.deleteContact(deletedContactName);
                    
                    Console.WriteLine("");
                    Console.WriteLine("Contact successfully deleted, press enter to continue");
                    Console.ReadLine();
                }
                // If name isn't in the directory the user is notified.
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("There doesn't seem to be that name in the directory, press enter to continue");
                    Console.ReadLine();
                }
            }
            // Second part of the if for the second option search by number.
            else if (inputDeleteChoice == 2)
            {
                Console.WriteLine("Enter the number you would like to be removed");
                Console.Write("Number: ");
                string inputDeleteNumber = Console.ReadLine();
                // Access the class manager method retrieve contacts by number so a contact can be searched and removed
                Contact deletedContactNumber = manager.retrieveContactsByNumber(inputDeleteNumber);
                
                if (deletedContactNumber != null)
                {
                    // Deletes the contact from the /contacts.txt file by access the class manager and method deleteContact
                    manager.deleteContact(deletedContactNumber);
                    
                    Console.WriteLine("");
                    Console.WriteLine("Contact succesfully deleted, press enter to continue");
                    Console.ReadLine();
                }
                // If number isn't in the directory the user is prompted
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("There doesn't seem to be that number in the directory, press enter to continue");
                    Console.ReadLine();
                }
            }
            // Clears the console of all goings on and reverts back to the main menu
            Console.Clear();
        }

        // Method that hold the Directory and its look when printed to the screen.
        private void printDirectoryMessage()
        {
            // Clears anything that was previously in the console.
            Console.Clear();
            // Displays the main header seen on all pages.
            Header.mainHeader();
            // Displays the dynamic header thats only seen in this form.
            Console.WriteLine("│                        Contacts in Directory                     │");
            Console.WriteLine("│──────────────────────────────────────────────────────────────────│");
            Console.WriteLine("");
            // Displays how many contacts are currently in the directory.
            Console.WriteLine("            There is " + manager.retrieveContacts().Count + "/20 contacts currently in the directory");
            Console.WriteLine("");
            // Displays each contact in the directory
            foreach (Contact contact in manager.retrieveContacts())
            {
                //Layout of the display
                Console.WriteLine(" Name: {0} -- Number: {1}", contact.Name, contact.Number);
            }

            Console.WriteLine("");
            Console.Write("Press enter to return");
            Console.ReadLine();
            Console.Clear();
        }

        // Method that contains the switch statment, the workings behind the menu system.
        private bool selectOption(string inputtedOptionChosen)
        {
           int inputtedOptionMenu = Convert.ToInt32(inputtedOptionChosen);

            switch (inputtedOptionMenu)
            {   
                // Case 1: Adding a contact also doesnt allow anymore than 20 contacts in the directory
                case 1:
                    // Limits the amount of contacts in the directory
                    if(manager.retrieveContacts().Count < 20)
                    {
                        addContactMessage();
                    }
                    // If there are 20 contacts in the directory no more can be added
                    else
                    {
                        Console.WriteLine("\nYou have reached the limit of contacts, delete a contact");
                        Console.Write("Press enter to continue");
                        Console.ReadLine();
                        Console.Clear();
                    }
                        break;
                // Case 2: Edit a contact form
                case 2:
                        editContactMessage();
                        break;
                // Case 3: Delete a contact form
                case 3:
                        deleteContactMessage();
                        break;
                // Case 4: Prints the directory
                case 4:
                        printDirectoryMessage();
                        break;
                // Case 5: Exits the directory
                case 5:
                        Environment.Exit(0);
                        break;
                        
            }
            return false;
        }
        
        // Main method where the program is ran from and all the parts are pieced together.
        static void Main(string[] args)
        {
            // Created a new program that contains the workings of the program.
            Program container = new Program();
            container.manager.loadContacts();
            int inputtedOptionMenu = 0;
            string inputOptionMenuSelected = "";
            do
            {
                // Displays the header.
                Header.mainHeader();
                // Displays the menu options.
                menuOptions();
                // Displays the choice the user has made in the menu.
                Console.Write("Choice: ");
                inputOptionMenuSelected = Console.ReadLine();

                container.selectOption(inputOptionMenuSelected);

            }
            //Exit for the menu and quits the application
            while (inputtedOptionMenu != 5);
            Console.ReadLine();
        }
    }
}
