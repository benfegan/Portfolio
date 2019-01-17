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
    public partial class EditContact : Form
    {
        public EditContact()
        {
            InitializeComponent();
        }

        #region Methods

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
            maskedTextBoxBirthdate.Text = "";
            textBoxDescription.Text = "";
            this.pictureBoxDisplayPicture.Image = new Bitmap(global::Assignment2.Properties.Resources.Contact);
        }

        public void LoadContacts()
        {
            string displayContacts;
            string Local = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            StreamReader sr = new StreamReader(Local + "/contacts.txt");

            while((displayContacts = sr.ReadLine()) !=null)
            {
                string[] contactSplit = displayContacts.Split(new string[] { "," }, StringSplitOptions.None);

                Manager.AddContact(contactSplit[0], contactSplit[1], contactSplit[2], contactSplit[3], contactSplit[4], contactSplit[5], contactSplit[6], contactSplit[7], contactSplit[8], contactSplit[9], contactSplit[10],contactSplit[11], true);
            }
            sr.Close();
        }

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

        Contact contactToEdit;

        public string imageFileName;

        #endregion

        #region Buttons

        private void buttonSearchName_Click(object sender, EventArgs e)
        {
            string inputName = textBoxSearchName.Text;

            contactToEdit = Manager.ContactByFirstName(inputName);

            if (contactToEdit != null)
            {

                if (inputName != "")
                {
                    textBoxSearchName.Text = "";

                    comboBoxTitle.Text = contactToEdit.Title;
                    textBoxFirstName.Text = contactToEdit.FirstName;
                    textBoxLastName.Text = contactToEdit.LastName;
                    textBoxAddress.Text = contactToEdit.Address;
                    textBoxCity.Text = contactToEdit.City;
                    textBoxCounty.Text = contactToEdit.County;
                    maskedTextBoxPostcode.Text = contactToEdit.Postcode;
                    maskedTextBoxPhoneNumber.Text = contactToEdit.PhoneNumber;
                    textBoxEmail.Text = contactToEdit.Email;
                    maskedTextBoxBirthdate.Text = contactToEdit.Birthdate;
                    textBoxDescription.Text = contactToEdit.Description;
                    pictureBoxDisplayPicture.Image = new Bitmap(contactToEdit.ImageLocation);
                    imageFileName = contactToEdit.ImageLocation;

                    MessageBox.Show("Contact has been successfully loaded");
                }
            }
            else
            {
                MessageBox.Show("There isn't a contact listed with that name, try again");
            }

        }

        private void buttonSearchNumber_Click(object sender, EventArgs e)
        {
            string inputNumber = maskedTextBoxSearchByNumber.Text;

            contactToEdit = Manager.ContactByNumber(inputNumber);

            if (contactToEdit != null)
            {
                if(inputNumber != "")
                {
                    maskedTextBoxSearchByNumber.Text = "";

                    comboBoxTitle.Text = contactToEdit.Title;
                    textBoxFirstName.Text = contactToEdit.FirstName;
                    textBoxLastName.Text = contactToEdit.LastName;
                    textBoxAddress.Text = contactToEdit.Address;
                    textBoxCity.Text = contactToEdit.City;
                    textBoxCounty.Text = contactToEdit.County;
                    maskedTextBoxPostcode.Text = contactToEdit.Postcode;
                    maskedTextBoxPhoneNumber.Text = contactToEdit.PhoneNumber;
                    textBoxEmail.Text = contactToEdit.Email;
                    maskedTextBoxBirthdate.Text = contactToEdit.Birthdate;
                    textBoxDescription.Text = contactToEdit.Description;
                    pictureBoxDisplayPicture.Image = new Bitmap(contactToEdit.ImageLocation);
                    imageFileName = contactToEdit.ImageLocation;

                    MessageBox.Show("Contact has been successfully loaded");
                }
            }
            else
            {
                MessageBox.Show("There isn't a contact listed with that number, try again");
            }
        }

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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            contactToEdit.Title = comboBoxTitle.Text;
            contactToEdit.FirstName = textBoxFirstName.Text;
            contactToEdit.LastName = textBoxLastName.Text;
            contactToEdit.Address = textBoxAddress.Text;
            contactToEdit.City = textBoxCity.Text;
            contactToEdit.County = textBoxCounty.Text;
            contactToEdit.Postcode = maskedTextBoxPostcode.Text;
            contactToEdit.PhoneNumber = maskedTextBoxPhoneNumber.Text;
            contactToEdit.Email = textBoxEmail.Text;
            contactToEdit.Birthdate = maskedTextBoxBirthdate.Text;
            contactToEdit.Description = textBoxDescription.Text;
            contactToEdit.ImageLocation = imageFileName;

            Manager.SaveContact();
            ClearFields();

            MessageBox.Show("You have successfully updated the contact");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
