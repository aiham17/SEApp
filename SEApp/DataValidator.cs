using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SEApp
{
    public static class DataValidator
    {
        // Constants for minimum lengths
        private const int MinUsernameLength = 3;
        private const int MinPasswordLength = 8;
        private const int MinNameLength = 3;

        // Constants for regular expression patterns
        private const string UsernamePattern = @"^[a-zA-Z]{3,}$";
        private const string EmailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        private const string NamePattern = @"^[a-zA-Z]{3,}$";

        // Constants for error messages
        private const string UsernameRequiredMessage = "Username is required.";
        private const string UsernameFormatErrorMessage = "Username must only contain letters and be at least 3 characters long.";
        private const string PasswordRequiredMessage = "Password is required.";
        private const string PasswordLengthErrorMessage = "Password must be at least 8 characters long.";
        private const string EmailRequiredMessage = "Email is required.";
        private const string InvalidEmailErrorMessage = "Invalid email address.";
        private const string FirstNameRequiredMessage = "First name is required.";
        private const string LastNameRequiredMessage = "Last name is required.";
        private const string CompanyRoleRequiredMessage = "Company role is required.";

       // Constants for error messages in ValidateSupportFormInputs
        private const string NameRequiredMessage = "Name is required.";
        private const string TopicRequiredMessage = "Topic is required.";
        private const string MessageRequiredMessage = "Message is required.";
        private const string NameFormatErrorMessage = "Name must only contain letters and be at least 3 characters long.";

        public static bool ValidateUserInputs(string username, string password, string fname, string lname, string email, int companyRole)
        {
            // Check if username is empty or whitespace
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show(UsernameRequiredMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Regular expression pattern for validating username
            if (!Regex.IsMatch(username, UsernamePattern))
            {
                MessageBox.Show(UsernameFormatErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if password is empty
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(PasswordRequiredMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if password is at least 8 characters long
            if (password.Length < MinPasswordLength)
            {
                MessageBox.Show(PasswordLengthErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if email is empty
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show(EmailRequiredMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Regular expression pattern for validating email address
            if (!Regex.IsMatch(email, EmailPattern))
            {
                MessageBox.Show(InvalidEmailErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if first name is empty
            if (string.IsNullOrWhiteSpace(fname))
            {
                MessageBox.Show(FirstNameRequiredMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if last name is empty
            if (string.IsNullOrWhiteSpace(lname))
            {
                MessageBox.Show(LastNameRequiredMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Regular expression pattern for validating names
            if (!Regex.IsMatch(fname, NamePattern))
            {
                MessageBox.Show(NameFormatErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(lname, NamePattern))
            {
                MessageBox.Show(NameFormatErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if a valid company role is selected
            if (companyRole < 0)
            {
                MessageBox.Show(CompanyRoleRequiredMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // If all validations pass, return true
            return true;
        }

        public static bool loginValidator(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a Username & Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if the username format is valid
            if (!Regex.IsMatch(username, UsernamePattern))
            {
                MessageBox.Show("Incorrect Username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if the password meets the minimum length requirement
            if (password.Length < MinPasswordLength)
            {
                MessageBox.Show("Incorrect Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        // Used to validate integer values entered into a text box. Will return true if it is an integer otherwise false
        public static bool validateInt(string number)
        {
            int integer;
            return int.TryParse(number, out integer) && integer != 0;
        }

        // Added ValidateSupportFormInputs method for the Support ticket form 
        public static bool ValidateSupportFormInputs(string name, string email, string topic, string message)
        {
            // Check if name is empty or whitespace
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show(NameRequiredMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Regular expression pattern for validating names
            if (!Regex.IsMatch(name, NamePattern))
            {
                MessageBox.Show(NameFormatErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Regular expression pattern for validating email address
            if (!Regex.IsMatch(email, EmailPattern))
            {
                MessageBox.Show(InvalidEmailErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if title is empty
            if (string.IsNullOrWhiteSpace(topic))
            {
                MessageBox.Show(TopicRequiredMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if message is empty
            if (string.IsNullOrWhiteSpace(message))
            {
                MessageBox.Show(MessageRequiredMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // If all validations pass, return true
            return true;
        }

    }
}
