﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SEApp.structContainer;

namespace SEApp
{
    public partial class LoginForm : Form
    {
        private Database connectDB;
        //Aiham
        // Static variable to store the logged-in username
        private static string loggedInUsername;

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
        // Aiham 
        //Opens a registration form upon clicking the account creation link, hiding the current login form.
        private void accountCreationLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Create an instance of the login Form
            RegistrationForm registrationForm = new RegistrationForm();

            // Show the Registration_ Form
            registrationForm.Show();


            // Hide the current form(Login form)
            this.Hide();
        }

        // Aiham

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the text in the input fields
            tbUsername.Text = "";
            tbPassword.Text = "";
   
            // Set focus to the first input field (tbUsername)
            tbUsername.Focus();
        }

        // Collects Users inputted username and password to then be checked against the database

        //Adam:
        /*  This method is used to check whether the entered username and password is stored in the database and then determine whether
         *  the user can be granted access to the application.
         *  Aiham: Added GetLoggedInUsername method to retrieve the logged-in username. 
         *  This static method returns the value stored in the loggedInUsername variable. 
         *  Utilized in SettingsForm for role-based access control. */
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (loginInputs())
            {
                structContainer.login login = new structContainer.login();
                login.username = tbUsername.Text;
                login.password = tbPassword.Text;

                // Use the readUsername method to check the login credentials entered. This passes the username and password to the readUsername Method.
                bool response = connectDB.readUsername(login.username, login.password);

                // If response is true, then the user will be granted access to the application. It will close the Login Form and Open the Dashboard.
                // Otherwise, the user is not granted access.
                if (response)
                {
                    // Store the logged-in username in the static variable
                    loggedInUsername = login.username;

                    this.Hide();
                    Dashboard open = new Dashboard();
                    open.Show();
                }
                else
                {
                    loggedInUsername = null; // Reset the username if the login fails
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }

        }




        // Aiham: Method to retrieve the logged-in username
        public static string GetLoggedInUsername()
        {
            return loggedInUsername;
        }

        // Used to open the Support Form when the password reset text is clicked.
        private void passwordRestLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Creates Instance of the Support Form and opens it.
            SupportForm open = new SupportForm();
            open.Show();
        }
    }
}
