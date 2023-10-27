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

        private bool loginInputs()
        {
            // We're passing the user-provided data from the input fields as arguments to this method.
            // This includes the username, password.
            return DataValidator.loginValidator(tbUsername.Text, tbPassword.Text);

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
            
            if (loginInputs())
            {
                userInfo.login login = new userInfo.login();
                login.username= tbUsername.Text;
                login.password = tbPassword.Text;
                bool response;
                response = connectDB.readUsername(login.username, login.password);
                if (response==true)
                {
                    this.Hide();
                    Dashboard open = new Dashboard();
                    open.Show();
                }
            }
            
            

            
            
            
        }
    }
}
