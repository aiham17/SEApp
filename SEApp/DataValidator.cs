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
        // Method for validating user inputs
        public static bool ValidateInputs(string username, string password, string fname, string lname, string email, int companyRole)
        {
            // Check if username is empty or whitespace
            if (string.IsNullOrWhiteSpace(username))
            {
                // Display an error message if username is missing
                MessageBox.Show("Username is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Regular expression pattern for validating username
            string usernamePattern = @"^[a-zA-Z]{3,}$";
            if (!Regex.IsMatch(username, usernamePattern))
            {
                // Display an error message if username format is incorrect
                MessageBox.Show("Username must only contain letters and be at least 3 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if password is empty
            if (string.IsNullOrWhiteSpace(password))
            {
                // Display an error message if password is missing
                MessageBox.Show("Password is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if password is at least 8 characters long
            if (password.Length < 8)
            {
                // Display an error message if password is too short
                MessageBox.Show("Password must be at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if email is empty
            if (string.IsNullOrWhiteSpace(email))
            {
                // Display an error message if email is missing
                MessageBox.Show("Email is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Regular expression pattern for validating email address
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                // Display an error message if email format is incorrect
                MessageBox.Show("Invalid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if first name is empty
            if (string.IsNullOrWhiteSpace(fname))
            {
                // Display an error message if first name is missing
                MessageBox.Show("First name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if last name is empty
            if (string.IsNullOrWhiteSpace(lname))
            {
                // Display an error message if last name is missing
                MessageBox.Show("Last name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Regular expression pattern for validating names
            string namePattern = @"^[a-zA-Z]{3,}$";
            if (!Regex.IsMatch(fname, namePattern))
            {
                // Display an error message if first name format is incorrect
                MessageBox.Show("First name must only contain letters and be at least 3 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(lname, namePattern))
            {
                // Display an error message if last name format is incorrect
                MessageBox.Show("Last name must only contain letters and be at least 3 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if a valid company role is selected
            if (companyRole < 0)
            {
                // Display an error message if company role is missing
                MessageBox.Show("Company role is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // If all validations pass, return true
            return true;
        }
    }
}