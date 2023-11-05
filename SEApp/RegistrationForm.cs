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

        // Here, we're calling the ValidateInputs method from the DataValidator class to perform input validation.

        private bool ValidateInputs()
        {
            // We're passing the user-provided data from the input fields as arguments to this method.
            // This includes the username, password, first name, last name, and email entered by the user

            return DataValidator.ValidateInputs(tbUsername.Text, tbPassword.Text, tbFname.Text, tbLname.Text, tbEmail.Text, cmbRole.SelectedIndex);

        }

        

        
       
       

        // Implement secure password hashing and salting in user registration button
        // This method now introduces password security measures by generating a random salt
        // and securely hashing user passwords before storing them in the database.
        // Additionally, input validation has been implemented to ensure data integrity during registration.
        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                bool userExists = connectDB.CheckUserExists(tbUsername.Text, tbEmail.Text);
                if (userExists)
                {
                    MessageBox.Show("Username or email already exists. Please choose a different one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                EncryptDecrypt generatePassword = new EncryptDecrypt();
                string salt = generatePassword.GenerateRandomSalt();
                string hashedPassword = generatePassword.HashPassword(tbPassword.Text, salt);
                //string salt = GenerateRandomSalt();
               // string hashedPassword = HashPassword(tbPassword.Text, salt);

                userInfo.userRegister user = new userInfo.userRegister();
                user.userName = tbUsername.Text;
                user.password = hashedPassword;
                user.salt = salt;
                user.firstName = tbFname.Text;
                user.lastName = tbLname.Text;
                user.email = tbEmail.Text;
                user.companyRole = cmbRole.SelectedIndex;
                string addUser = sqlQuery.addUser;
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
