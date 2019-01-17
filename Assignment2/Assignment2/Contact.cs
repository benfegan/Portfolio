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
    class Contact
    {
        // Class level variable which are accessed to print the contents of the text tile

        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Postcode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Birthdate { get; set; }
        public string Description { get; set; }
        public string ImageLocation { get; set; }

        // Contact Object
        public Contact(string title, string firstName, string lastName, string address, string city, string county, string postcode, string  phoneNumber, string email, string birthdate, string description, string imageLocation)
        {
            Title = title;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            County = county;
            Postcode = postcode;
            PhoneNumber = phoneNumber;
            Email = email;
            Birthdate = birthdate;
            Description = description;
            ImageLocation = imageLocation;
        }

        // Method that saves contact to the /contact.txt file

        public void SaveContact()
        {
            string Local = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            using(StreamWriter sw = new StreamWriter(Local + "/contacts.txt", true))
            {
                sw.WriteLine(Title + "," + FirstName + "," + LastName + "," + Address + "," + City + "," + County + "," + Postcode + "," + PhoneNumber + "," + Email + "," + Birthdate + "," + Description + "," + ImageLocation);
                sw.Close();
            }
        }
    }
}
