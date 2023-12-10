using System;
using System.Data.Common;
using System.Drawing.Text;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Text;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Security.Policy;

namespace SEApp
{
    public partial class RegistrationForm : Form
    {
        // Database connection object
        private Database connectDB;

       

        // Constructor for the Registration Form
        public RegistrationForm()
        {
            // Initialize the database connection
            InitializeComponent();
            connectDB = Database.getConnectString();
        }

        // calling the ValidateInputs method from the DataValidator class to perform input validation.
        private bool ValidateInputs()
        {
            // passing the user-provided data from the input fields as arguments to this method.
            // This includes the username, password, first name, last name, and email entered by the user

            return DataValidator.ValidateUserInputs(tbUsername.Text, tbPassword.Text, tbFname.Text, tbLname.Text, tbEmail.Text, cmbRole.SelectedIndex);

        }







    
        /* This register button performs input validation, checks for existing username or email, securely hashes the user's password
         * using a randomly generated salt, and saves the securely hashed password along with user information to the database.
         * Displays appropriate messages and navigates to the login form on success.*/
        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            // Validate user input data
            if (ValidateInputs())
            { 
                // Check if the username or email already exists
                bool userExists = connectDB.CheckUserExists(tbUsername.Text, tbEmail.Text);
                if (userExists)
                {
                    // Display an error message if the user already exists
                    MessageBox.Show("Username or email already exists. Please choose a different one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Generate a random salt and securely hash the user's password
                EncryptDecrypt generatePassword = new EncryptDecrypt();
                string salt = generatePassword.GenerateRandomSalt();
                string hashedPassword = generatePassword.HashPassword(tbPassword.Text, salt);

                // Create a user structure and populate it with the user's information
                structContainer.userRegister user = new structContainer.userRegister();
                user.userName = tbUsername.Text;
                user.password = hashedPassword;
                user.salt = salt;
                user.firstName = tbFname.Text;
                user.lastName = tbLname.Text;
                user.email = tbEmail.Text;
                user.companyRole = cmbRole.SelectedIndex;
                string addUser = sqlQuery.AddUser;
                connectDB.saveUserInfo(addUser, user.userName, user.password, user.salt, user.firstName, user.lastName, user.email, user.companyRole);

                MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Create an instance of the login Form
                LoginForm loginForm = new LoginForm();
                // Show the login Form
                loginForm.Show();

                // Hide the current form (Registration form)
                this.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CompanyRole_Click(object sender, EventArgs e)
        {

        }
        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }
        private void tbFname_TextChanged(object sender, EventArgs e)
        {

        }
        private void tbLname_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {


            // Clear the text in the input fields
            tbUsername.Text = "";
            tbPassword.Text = "";
            tbFname.Text = "";
            tbLname.Text = "";
            tbEmail.Text = "";
            cmbRole.SelectedIndex = -1;

            // Set focus to the first input field (tbUsername)
            tbUsername.Focus();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

            // Create an instance of the login Form
            LoginForm loginForm = new LoginForm();

            // Show the login Form
            loginForm.Show();

            // Hide the current form (Registration form)
            this.Hide();

        }

        private void FirstName_Click(object sender, EventArgs e)
        {

        }
    }
}
