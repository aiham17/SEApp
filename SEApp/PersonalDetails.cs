using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEApp
{
    public partial class PersonalDetails : Form
    {
        public PersonalDetails()
        {
            InitializeComponent();

            // Get the logged-in username
            string loggedInUsername = LoginForm.GetLoggedInUsername();

            // Set the displayed username in the TextBox
            tbDisplayedUsername.Text = loggedInUsername;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void PersonalDetails_Load(object sender, EventArgs e)
        {

        }

        private void tbDisplayedUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
