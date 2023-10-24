using System.Data.Common;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace SEApp
{

    public partial class Registeration_Form : Form
    {
        private Database connectDB;
        public Registeration_Form()
        {
            InitializeComponent();
            connectDB = Database.getConnectString();
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


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }


        // Need encryption and input validation here.
        // Collects the users inputs and assigns them to the struct user to then be sent and stored in the DB
        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            Database.getConnectString();
            userInfo.userRegister user = new userInfo.userRegister();
            user.userName = tbUsername.Text;
            user.password = tbPassword.Text;
            user.firstName = tbFname.Text;
            user.lastName = tbLname.Text;
            user.email = tbEmail.Text;
            user.companyRole = cmbRole.SelectedIndex;

            connectDB.saveUserInfo("INSERT INTO Userinformation (Username,Password,FirstName,LastName,Email,CompanyRole) VALUES (@Username, @Password, @FirstName,@LastName,@Email,@CompanyRole)", user.userName, user.password, user.firstName, user.lastName, user.email, user.companyRole);
        }
    }
}