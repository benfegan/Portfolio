using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

/*  Contact Class
 *  ***************
 *  The contact class contains is where all the workings for displaying and saving a contact.
 *  This is also where a contact is saved to the text time in a way easy to use in the rest of the code.
 *  ***************
 */
namespace Assignment1
{
    class Contact
    {
        //Used for saving both name and number, notice string for number instead of int.
        public string Name;
        public string Number;
        //Concaternating the string together to save as one line.
        public Contact(string name, string number)
        {
            Name = name;
            Number = number;
        }
        //This is where the saving a contact to a text file is done.
        public void savingContact()
        {
            //Locates where the text file is.
            string Local = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            //Opens a new streamwriter to write to the specific text file.
            using(StreamWriter sw = new StreamWriter(Local + "/contacts.txt", true))
            {
                //What is actually written into the text file, seperating the contact with two ::
                sw.WriteLine(Name + "::" + Number);
                //Ends the StreamWriter.
                sw.Close();
            }
        }
    }
}
