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
// Here is where the adding of a contact is taken place, this is the class behind the form.

    public partial class AddContact : Form
    {
        public AddContact()
        {
            InitializeComponent();
        }

        // Using a region to encase all the methods used, to keep methods and buttons seperate.

        #region Methods

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

            Manager.AddContact(inputTitle,inputFirstName,inputLastName,inputAddress,inputCity,inputCounty,inputPostcode,inputNumber,inputEmail,inputBirthdate,inputDescription,imageFileName);
        }

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
            maskedTextBoxBirthdate.Text = "";
            textBoxDescription.Text = "";
            this.pictureBoxDisplayPicture.Image = new Bitmap(global::Assignment2.Properties.Resources.Contact);
        }

        // Sets a string that can be used when the a dialog box is opened and a image is selected.

        public string imageFileName;

        #endregion

        // Using a region to encase all the buttons used, to keep the buttons apart from the methods.

        #region Buttons

        // Button that opens a dialog box for selecting an image.

        private void buttonOpenImage_Click(object sender, EventArgs e)
        {
            // Opens a new dialog box, so that the user can select an image.

            OpenFileDialog dlg = new OpenFileDialog();

            // Settings for the dialog box.

            dlg.Title = "Upload and Image.";
            dlg.InitialDirectory = "c:\\Users\\User\\Pictures";
            dlg.Filter = "JPG Files (*.JPG)|*.jpg|JPEG Files (*.JPEG)|*.jpeg|PNG Files (*.PNG)|*.png|GIF Files (*.GIF)|*.gif";
            dlg.FilterIndex = 1;

            // If statment for displaying the image.

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.pictureBoxDisplayPicture.Image = new Bitmap(dlg.OpenFile());

                imageFileName = dlg.FileName;
            }

            // Closes the dialog box.

            dlg.Dispose();

        }

        // Button that closes the form.

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Closes this instance of the form.
            this.Close();
        }

        // Button that calls the ClearFields method and clears fields.

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Called method.

            ClearFields();
        }

        // Button that calls the SaveContact method to save a new contact

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // If statment that checks if all the fields have a value, before saving.

            if(maskedTextBoxPhoneNumber.Text.Length > 13)
            {
                labelPhoneNumber.ForeColor = System.Drawing.Color.Black;
                MessageBox.Show("You have succesfully added a contact");
                SaveContact();
                ClearFields();
            }
            else
            {
                labelPhoneNumber.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show("Too short Phone Number");
            }
        }

        #endregion
    }
}
