using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SEApp.userInfo;

namespace SEApp
{
    public partial class LoginForm : Form
    {
        private Database connectDB;
        public LoginForm()
        {
            InitializeComponent();
            connectDB = Database.getConnectString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        



        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void accountCreationLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Create an instance of the login Form
            RegistrationForm registrationForm = new RegistrationForm();

            // Show the Registration_ Form
            registrationForm.Show();


            // Hide the current form(Login form)
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the text in the input fields
            tbUsername.Text = "";
            tbPassword.Text = "";
   
            // Set focus to the first input field (tbUsername)
            tbUsername.Focus();
        }

        // Collects Users inputted username and password to then be checked against the database
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            userInfo.login login = new userInfo.login();
            string userName = tbUsername.Text;
            string password = tbPassword.Text;

            // Validate inputs
            DataValidator.ValidateInputs(userName, password, "", "", "", 0);
            connectDB.readUsername("SELECT Username FROM UserInformation WHERE Username = @User", login.username, login.password);
        }
    }
}
