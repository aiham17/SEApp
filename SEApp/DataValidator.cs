using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace SEApp
{
    // Implemented the DataValidator class for distinct input validation responsibilities.
    // DataValidator focuses exclusively on validating user inputs, ensuring accuracy and validity across different components of the application.
    // This separation of concerns enhances maintainability and promotes a cleaner, more organized codebase.

    public static class DataValidator
    {
        public static bool ValidateInputs(string username, string password, string fname, string lname, string email)
        {

            // Check if any of the input fields are empty or contain only whitespace
            if (string.IsNullOrWhiteSpace(username) ||
              string.IsNullOrWhiteSpace(password) ||
              string.IsNullOrWhiteSpace(fname) ||
              string.IsNullOrWhiteSpace(lname) ||
              string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if the username format is valid
            string usernamePattern = @"^[a-zA-Z]{3,}$";
            if (!Regex.IsMatch(username, usernamePattern))
            {
                MessageBox.Show("Username must only contain letters and be at least 3 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if the password meets the minimum length requirement
            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if the email format is valid
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Invalid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if the first name format is valid
            string namePattern = @"^[a-zA-Z]{3,}$";
            if (!Regex.IsMatch(fname, namePattern))
            {
                MessageBox.Show("First name must only contain letters and be at least 3 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if the last name format is valid
            if (!Regex.IsMatch(lname, namePattern))
            {
                MessageBox.Show("Last name must only contain letters and be at least 3 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}