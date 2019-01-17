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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            
            // Loads the contacts text file and creates the contacts when loading the program,

            string displayContacts;
            string Local = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            StreamReader sr = new StreamReader(Local + "/contacts.txt");

            while ((displayContacts = sr.ReadLine()) != null)
            {
                // using an array to save the contacts tempoarily, and once you get to a , that is the next part of the array
                
                string[] contactSplit = displayContacts.Split(new string[] { "," }, StringSplitOptions.None);

                Manager.AddContact(contactSplit[0], contactSplit[1], contactSplit[2], contactSplit[3], contactSplit[4], contactSplit[5], contactSplit[6], contactSplit[7], contactSplit[8], contactSplit[9], contactSplit[10], contactSplit[11], true);
            }
            sr.Close();
        }

        // Button that exits the application

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Message box making sure that you are wanting to exit the application

            DialogResult dialogResult = MessageBox.Show("          Are you sure you want to exit?", "Why you exiting?", MessageBoxButtons.YesNo);
                
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
        
        // Button that opens the Add a Contact Form

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddContact addContact = new AddContact();
            addContact.Show();
        }

        // Button that opens the Edit a Contact Form

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditContact editContact = new EditContact();
            editContact.Show();
        }

        // Button that opens the Delete a Contact Form

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteContact deleteContact = new DeleteContact();
            deleteContact.Show();
        }

        // Button that open the Print Directory Form 

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            PrintDirectory printDirectory = new PrintDirectory();
            printDirectory.Show();
        }
    }
}
