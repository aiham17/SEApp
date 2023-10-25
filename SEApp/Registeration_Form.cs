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
    public partial class Registeration_Form : Form
    {
        // Database connection object
        private Database connectDB;

        // Constructor for the Registration Form
        public Registeration_Form()
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


        // This method generates a random value (salt) for each user.
        // It's crucial for password security because it ensures that even if two users have the same password,
        // their hashed passwords will be different.This helps prevent attacks like rainbow table attacks.
        private string GenerateRandomSalt()
        {
            byte[] saltBytes = new byte[16];
            using (RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetBytes(saltBytes);
            }
            return BitConverter.ToString(saltBytes).Replace("-", "").ToLower();
        }

        // This method takes a user's password and a salt, then uses the SHA-256 algorithm to securely hash the password.
        // The resulting hash is stored in the database. Hashing ensures that even if the database is compromised,
        // attackers won't have direct access to user passwords.
        // The combination of the user's unique salt and their password ensures that the resulting hash is unique to that user.
        private string HashPassword(string password, string salt)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] saltedPasswordBytes = Encoding.UTF8.GetBytes(password + salt);
                byte[] hashedBytes = sha256.ComputeHash(saltedPasswordBytes);
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        // Implement secure password hashing and salting in user registration button
        // This method now introduces password security measures by generating a random salt
        // and securely hashing user passwords before storing them in the database.
        // Additionally, input validation has been implemented to ensure data integrity during registration.
        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                string salt = GenerateRandomSalt();
                string hashedPassword = HashPassword(tbPassword.Text, salt);

                userInfo.userRegister user = new userInfo.userRegister();
                user.userName = tbUsername.Text;
                user.password = hashedPassword;
                user.salt = salt;
                user.firstName = tbFname.Text;
                user.lastName = tbLname.Text;
                user.email = tbEmail.Text;
                user.companyRole = cmbRole.SelectedIndex;

                connectDB.saveUserInfo("INSERT INTO Userinformation (Username, Password, Salt, FirstName, LastName, Email, CompanyRole) VALUES (@Username, @Password, @Salt, @FirstName, @LastName, @Email, @CompanyRole)", user.userName, user.password, user.salt, user.firstName, user.lastName, user.email, user.companyRole);

                MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            // Hide the current form (Registeration form)
            this.Hide();

        }
    }
}
