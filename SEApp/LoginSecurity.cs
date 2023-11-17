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

        /* When the "Edit" button is clicked.
         * checks if a row is selected in the DataGridView.
         * If a row is selected, it retrieves values from the selected row and populates the text boxes for editing.
         * If no row is selected, it displays an error message.*/
        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the DataGridView
            if (dgvUserData.SelectedRows.Count > 0)
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
                // Display an error message if no row is selected for editing
                MessageBox.Show("Please select a row to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
