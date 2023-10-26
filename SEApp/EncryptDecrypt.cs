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
                MessageBox.Show("Credentials Incorrect");
                return false;
            }
            
            
        }
    }
}
