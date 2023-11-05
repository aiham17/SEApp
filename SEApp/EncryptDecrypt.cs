using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SEApp
{
    class EncryptDecrypt
    {
        // This method generates a random value (salt) for each user.
        // It's crucial for password security because it ensures that even if two users have the same password,
        // their hashed passwords will be different.This helps prevent attacks like rainbow table attacks.
        public string GenerateRandomSalt()
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
        public string HashPassword(string password, string salt)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] saltedPasswordBytes = Encoding.UTF8.GetBytes(password + salt);
                byte[] hashedBytes = sha256.ComputeHash(saltedPasswordBytes);
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }





        // Adam: (Aiham coded the hashing part in registration form, so utilised)
        //Need to encrypt the user entered password to compare both the hashed passwords to see if they match.
        // This is due to SHA256 hashing being used so we compare the hashed password with the salt stored in the database with the new version
        // based off the user input
        public bool passwordVerify(string ePassword, string salt, string password)
        {
            string newHash;
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] saltedPasswordBytes = Encoding.UTF8.GetBytes(password + salt);
                byte[] hashedBytes = sha256.ComputeHash(saltedPasswordBytes);
                newHash=  BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
            if (newHash == ePassword)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Incorrect Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            
        }
    }
}
