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
    public partial class SettingsForm : Form
    {
        // Database connection object
        private Database connectDB;



        public SettingsForm()
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

        // added functionality to btnAddOrAdjustVendors in the dashboard form to allow access to AddAdjustForm for admins and owners.
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

        // added functionality to  btnLoginSecurity to allow access to LoginSecurity form for admins and owners.
        private void btnLoginSecurity_Click(object sender, EventArgs e)
        {

            // Retrieve the logged-in username using the static method
            string username = LoginForm.GetLoggedInUsername();

            // Fetch the user's role from the database using the Database class
            string userRole = connectDB.GetUserRole(username);

            // Check if the user is an admin 
            if (userRole == "0")
            {
                // Allow access to the LoginSecurity form
                LoginSecurity loginSForm = new LoginSecurity();
                loginSForm.Show();
                this.Close();
            }
            else
            {
                // Display access denied message
                MessageBox.Show("Access Denied. You do not have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // added functionality to btnCompanyRole to allow access to AddAdjustForm for admins and owners.
        private void btnCompanyRole_Click(object sender, EventArgs e)
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

    }
}
