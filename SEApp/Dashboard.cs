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
    // Adam
    // VendorInfo and ProductInfo Tables Populated with 15 vendors and products. Have created other tables with foreign keys
    // and primary keys ready to be populated. Need to discuss the DB ERD as there is overlapping data between Vendor table etc
    public partial class Dashboard : Form
    {
        // Database connection object
        private Database connectDB;

        // Initialize the database connection
        public Dashboard ()
        {
            InitializeComponent();
            connectDB = Database.getConnectString();
            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
      
        // Implemented the dashboard buttons
        private void btnSetting_Click(object sender, EventArgs e)
        {
            // Create an instance of the SettingsForm
            SettingsForm settingsForm = new SettingsForm();

            // Show the SettingsForm
            settingsForm.Show();

            // Hide the current form (Dashboard form)
            this.Hide();
        }

        private void btnAddOrAdjustVendors_Click(object sender, EventArgs e)
        {
            // Create an instance of the AddAdjustForm
            AddAdjustForm addAdjustForm = new AddAdjustForm();

            // Show the AddAdjustForm
            addAdjustForm.Show();

            // Hide the current form (Dashboard form)
            this.Hide();

        }

        private void btnVendorsAndProducts_Click(object sender, EventArgs e)
        {
            // Create an instance of the VendorsProductsForm
            VendorsProductsForm vendorsProductsForm = new VendorsProductsForm();

            // Show the VendorsProductsForm
            vendorsProductsForm.Show();

            // Hide the current form (Dashboard form)
            this.Hide();

        }

        // 
        private void btnDashBoard_Click(object sender, EventArgs e)
        {
           // Create an instance of the Dashboard Form
            Dashboard dashboard = new Dashboard();

            // Show the Dashboard form
            dashboard.Show();
           
            this.Hide();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Create an instance of the LoginForm
            LoginForm loginForm = new LoginForm();

            // Show the LoginForm
            loginForm.Show();

            // Close the current form (Dashboard Form)
            //this.Close();

            // Hide the current form (Dashboard Form)
            this.Hide();

        }

        // calling TotalNumberOfVendorsQuery from sqlQuery class
        private void btnTotalNumberOfVendors_Click(object sender, EventArgs e)
        {

            String query = sqlQuery.TotalNumberOfVendorsQuery;
            DataTable result = connectDB.ExecuteQuery(query);

            MessageBox.Show($"Total number of vendors: {result.Rows[0]["TotalVendors"]}");

        }
        // calling ActiveVendorsQuery from sqlQuery class
        private void btnActiveVendors_Click(object sender, EventArgs e)
        {
            string query = sqlQuery.ActiveVendorsQuery;
            DataTable result = connectDB.ExecuteQuery(query);

        }
        // calling HighestPerformingVendorsQuery from sqlQuery class
        private void btnHighestPerformingVendors_Click(object sender, EventArgs e)
        {
            string query = sqlQuery.HighestPerformingVendorsQuery;
            DataTable result = connectDB.ExecuteQuery(query);
        }

        private void btnLowestPerformingVendors_Click(object sender, EventArgs e)
        {

        }

        private void btnHighestPerformingProducts_Click(object sender, EventArgs e)
        {

        }

        private void btnLowestPerformingProducts_Click(object sender, EventArgs e)
        {

        }

        private void btnHighestPerformingMarketSectors_Click(object sender, EventArgs e)
        {

        }

        private void btnNumbersOfRequests_Click(object sender, EventArgs e)
        {

        }

        private void btnLowestPerformingMarketSectors_Click(object sender, EventArgs e)
        {

        }

       
    }
}
