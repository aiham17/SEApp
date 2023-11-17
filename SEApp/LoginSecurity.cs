using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SEApp
{
    public partial class LoginSecurity : Form
    {
        private Database connectDB;
        DataTable vendorProData;
        public LoginSecurity()
        {
            InitializeComponent();
            connectDB = Database.getConnectString();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            // Create an instance of the Dashboard Form
            Dashboard dashboard = new Dashboard();

            dashboard.Show();
            this.Close();
        }

        private void btnVendorsAndProducts_Click(object sender, EventArgs e)
        {
            // Create an instance of the VendorsProductsForm
            VendorsProductsForm vendorsProductsForm = new VendorsProductsForm();

            vendorsProductsForm.Show();
            this.Close();

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            // Create an instance of the SettingsForm
            SettingsForm settingsForm = new SettingsForm();

            settingsForm.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Create an instance of the LoginForm
            LoginForm loginForm = new LoginForm();

            loginForm.Show();
            this.Close();
        }

        private void dgvUserData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoginSecurity_Load(object sender, EventArgs e)
        {
            DataTable vendorProData = connectDB.getVendorProducts(sqlQuery.userInfo);
            VendorsProductsForm dataSource = new VendorsProductsForm();
            dataSource.setDataSource(vendorProData, dgvUserData);

        }

        // added functionality to btnAddOrAdjustVendors  to allow access to AddAdjustForm for admins and owners.
        private void btnAddOrAdjustVendors_Click(object sender, EventArgs e)
        {
            // Retrieve the logged-in username using the static method
            string username = LoginForm.GetLoggedInUsername();

            // Fetch the user's role from the database using the Database class
            string userRole = connectDB.GetUserRole(username);

            // Check if the user is an admin or owner
            if (userRole == "0" || userRole == "1")
            {
                // Allow access to the AddAdjustForm
                AddAdjustForm addAdjustForm = new AddAdjustForm();
                addAdjustForm.Show();
                this.Close();
            }
            else
            {
                // Display access denied message
                MessageBox.Show("Access Denied. You do not have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        /* When the Edit button is clicked.
         * checks if a row is selected in the DataGridView.
         * If a row is selected, it retrieves values from the selected row and populates the text boxes for editing.
         * If no row is selected, it displays an error message.*/
        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the DataGridView and if the selected row is not empty
            if (dgvUserData.SelectedRows.Count > 0 && dgvUserData.SelectedRows[0].Cells["UserID"].Value != null)
            {
                // Get the first selected row
                DataGridViewRow selectedRow = dgvUserData.SelectedRows[0];

                // Populate text boxes with values from the selected row for editing
                tbUsername.Text = selectedRow.Cells["Username"].Value.ToString();
                tbPassword.Text = selectedRow.Cells["Password"].Value.ToString();
                tbEmail.Text = selectedRow.Cells["Email"].Value.ToString();
            }
            else
            {
                // Display an error message if no valid row is selected for editing
                MessageBox.Show("Please select a valid row to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /* When the Save button is clicked.
         * Checks if a row is selected in the DataGridView.
         * If a row is selected, it retrieves the UserID from the selected row.
         * Gets values from text boxes and validates the new password.
         * If the new password is valid, generates a new salt, hashes the new password, and updates user information in the database.
         * Refreshes the DataGridView with updated user data, clears text boxes, and displays success/error messages.*/
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the DataGridView
            if (dgvUserData.SelectedRows.Count > 0)
            {
                // Get the first selected row
                DataGridViewRow selectedRow = dgvUserData.SelectedRows[0];

                
                // Extract the UserID from the selected row for updating the specific record
                int userID = Convert.ToInt32(selectedRow.Cells["UserID"].Value);

                // Get values from text boxes for updating user information
                string newUsername = tbUsername.Text;
                string newPassword = tbPassword.Text;
                string newEmail = tbEmail.Text;

                // Check if the new password is not empty
                if (!string.IsNullOrEmpty(newPassword))
                {
                    // Generate a new salt and hash the new password
                    string newSalt = new EncryptDecrypt().GenerateRandomSalt();
                    string newPasswordHash = new EncryptDecrypt().HashPassword(newPassword, newSalt);

                    // Update user information in the database using the Database class method
                    connectDB.UpdateUserInfo(userID, newUsername, newPasswordHash, newSalt, newEmail);

                    // Refresh the DataGridView with updated user data
                    DataTable updatedUserData = connectDB.getVendorProducts(sqlQuery.userInfo);
                    VendorsProductsForm dataSource = new VendorsProductsForm();
                    dataSource.setDataSource(updatedUserData, dgvUserData);

                    // Clear text boxes after successful update
                    tbUsername.Text = string.Empty;
                    tbPassword.Text = string.Empty;
                    tbEmail.Text = string.Empty;

                    // Display a success message
                    MessageBox.Show("User information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Display an error message if the new password is empty
                    MessageBox.Show("Password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Display an error message if no row is selected for saving changes
                MessageBox.Show("Please select a row to save changes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
