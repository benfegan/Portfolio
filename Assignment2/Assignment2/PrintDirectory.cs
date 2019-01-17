using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class PrintDirectory : Form
    {
        public PrintDirectory()
        {
            InitializeComponent();

            // Loads the contacts in the data grid

            dataGridViewDirectory.RowTemplate.MinimumHeight = 20;
            dataGridViewDirectory.DataSource = Manager.FoundContacts();
            dataGridViewDirectory.AllowUserToAddRows = false;
            dataGridViewDirectory.AllowUserToDeleteRows = false;
            dataGridViewDirectory.Refresh();
        }

        // Button that closes the form

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
