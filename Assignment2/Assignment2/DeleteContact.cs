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
    public partial class DeleteContact : Form
    {

        public DeleteContact()
        {
            InitializeComponent();
        }

        // Using a region to encase all the methods used, to keep methods and buttons seperate.

        #region Methods

        Contact contactToDelete;

        // This clears all viewable fields, including the pictureBox back to the orignal image. Used after a contact has been added, so another can be added. Also used when the clear button is pressed.

        public void ClearFields()
        {
            comboBoxTitle.Text = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxAddress.Text = "";
            textBoxCity.Text = "";
            textBoxCounty.Text = "";
            maskedTextBoxPostcode.Text = "";
            maskedTextBoxPhoneNumber.Text = "";
            textBoxEmail.Text = "";
            textBoxDescription.Text = "";
            this.pictureBoxDisplayPicture.Image = new Bitmap(global::Assignment2.Properties.Resources.Contact);
        }

        // This loads the contacts into the contacts list and into the textboxes

        public void LoadContacts()
        {
            string displayContacts;
            string Local = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            StreamReader sr = new StreamReader(Local + "/contacts.txt");

            while ((displayContacts = sr.ReadLine()) != null)
            {
                string[] contactSplit = displayContacts.Split(new string[] { "," }, StringSplitOptions.None);

                Manager.AddContact(contactSplit[0], contactSplit[1], contactSplit[2], contactSplit[3], contactSplit[4], contactSplit[5], contactSplit[6], contactSplit[7], contactSplit[8], contactSplit[9], contactSplit[10], contactSplit[11], true);
            }
            sr.Close();
        }

        // Deletes the contact from the text file by accessing the delete contacts method from the manager

        public void DeleteContactDirectory()
        {
            Manager.DeleteContact(contactToDelete);
        }

        // This SaveContacts() methods saves the contact by passing it through the manager saving.
        
        public void SaveContact()
        {
            string inputTitle = comboBoxTitle.Text;
            string inputFirstName = textBoxFirstName.Text;
            string inputLastName = textBoxLastName.Text;
            string inputAddress = textBoxAddress.Text;
            string inputCity = textBoxCity.Text;
            string inputCounty = textBoxCounty.Text;
            string inputPostcode = maskedTextBoxPostcode.Text;
            string inputNumber = maskedTextBoxPhoneNumber.Text;
            string inputEmail = textBoxEmail.Text;
            string inputBirthdate = maskedTextBoxBirthdate.Text;
            string inputDescription = textBoxDescription.Text;
            string inputImageLocation = pictureBoxDisplayPicture.ImageLocation;

            Manager.AddContact(inputTitle, inputFirstName, inputLastName, inputAddress, inputCity, inputCounty, inputPostcode, inputNumber, inputEmail, inputBirthdate, inputDescription, imageFileName);
        }

        string imageFileName;

        #endregion

        // Using a region to encase all the buttons used, to keep the buttons apart from the methods.

        #region Buttons

        // Button used for searching a contact by name

        private void buttonSearchName_Click(object sender, EventArgs e)
        {
            string inputName = textBoxSearchName.Text;

            contactToDelete = Manager.ContactByFirstName(inputName);

            if (contactToDelete != null)
            {

                if (inputName != "")
                {
                    textBoxSearchName.Text = "";
                    MessageBox.Show("Contact has been successfully loaded");

                    // Sets all the textbox values to the contacts found from textfile

                    comboBoxTitle.Text = contactToDelete.Title;
                    textBoxFirstName.Text = contactToDelete.FirstName;
                    textBoxLastName.Text = contactToDelete.LastName;
                    textBoxAddress.Text = contactToDelete.Address;
                    textBoxCity.Text = contactToDelete.City;
                    textBoxCounty.Text = contactToDelete.County;
                    maskedTextBoxPostcode.Text = contactToDelete.Postcode;
                    maskedTextBoxPhoneNumber.Text = contactToDelete.PhoneNumber;
                    textBoxEmail.Text = contactToDelete.Email;
                    maskedTextBoxBirthdate.Text = contactToDelete.Address;
                    textBoxDescription.Text = contactToDelete.Description;
                    pictureBoxDisplayPicture.Image = new Bitmap(contactToDelete.ImageLocation);
                }
            }
            else
            {
                MessageBox.Show("There isn't a contact listed with that name, try again");
            }
        }

        // Button used for searching a contact by number

        private void buttonSearchNumber_Click(object sender, EventArgs e)
        {
            string inputNumber = maskedTextBoxSearchByNumber.Text;

            contactToDelete = Manager.ContactByNumber(inputNumber);

            if (contactToDelete != null)
            {
                if(inputNumber != "")
                {
                    MessageBox.Show("Contact has been successfully loaded");
                    maskedTextBoxSearchByNumber.Text = "";

                    // Sets all the textbox values to the contacts found from textfile

                    comboBoxTitle.Text = contactToDelete.Title;
                    textBoxFirstName.Text = contactToDelete.FirstName;
                    textBoxLastName.Text = contactToDelete.LastName;
                    textBoxAddress.Text = contactToDelete.Address;
                    textBoxCity.Text = contactToDelete.City;
                    textBoxCounty.Text = contactToDelete.County;
                    maskedTextBoxPostcode.Text = contactToDelete.Postcode;
                    maskedTextBoxPhoneNumber.Text = contactToDelete.PhoneNumber;
                    textBoxEmail.Text = contactToDelete.Email;
                    maskedTextBoxBirthdate.Text = contactToDelete.Address;
                    textBoxDescription.Text = contactToDelete.Description;
                    pictureBoxDisplayPicture.Image = new Bitmap(contactToDelete.ImageLocation);
                }
            }
            else
            {
                MessageBox.Show("There isn't a contact listed with that number, try again");
            }
        }

        // Button used for opening a dialog box which allows you to select an image

        private void buttonOpenImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Upload and Image.";
            dlg.InitialDirectory = "c:\\Users\\User\\Pictures";
            dlg.Filter = "JPG Files (*.JPG)|*.jpg|JPEG Files (*.JPEG)|*.jpeg|PNG Files (*.PNG)|*.png|GIF Files (*.GIF)|*.gif";
            dlg.FilterIndex = 1;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.pictureBoxDisplayPicture.Image = new Bitmap(dlg.OpenFile());

                imageFileName = dlg.FileName;
            }
            dlg.Dispose();
        }

        // Button that calls the ClearFields method and clears fields.

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // Button that calls the DeleteContactDirectory method and deletes the contact

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Opens a message box to make you sure that you want to delete a contacy

            DialogResult dialogResult = MessageBox.Show("          Are you sure you want to delete this contact?", "STOP!!", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                // Calls the delete method

                DeleteContactDirectory();
                
                // Saves the contact file after deleted

                Manager.SaveContact();
                ClearFields();
            }
        }

        // Button that closes the form

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
