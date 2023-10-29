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

        // Create an instance of the LoginForm
        LoginForm loginForm = new LoginForm();

        // Create an instance of the SettingsForm
        SettingsForm settingsForm = new SettingsForm();

        // Create an instance of the AddAdjustForm
        AddAdjustForm addAdjustForm = new AddAdjustForm();

        // Create an instance of the VendorsProductsForm
        VendorsProductsForm vendorsProductsForm = new VendorsProductsForm();

        // Create an instance of the Dashboard Form
        Dashboard dashboard = new Dashboard();



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
            // Show the SettingsForm
            settingsForm.Show();

            // Close the current form (Dashboard form)
            this.Close();
        }

        private void btnAddOrAdjustVendors_Click(object sender, EventArgs e)
        {
            // Show the AddAdjustForm
            addAdjustForm.Show();

            // Close the current form (Dashboard form)
            this.Close();

        }

        private void btnVendorsAndProducts_Click(object sender, EventArgs e)
        {
            // Show the VendorsProductsForm
            vendorsProductsForm.Show();

            // Close the current form (Dashboard form)
            this.Close();

        }

        // 
        private void btnDashBoard_Click(object sender, EventArgs e)
        {
        
            // Show the Dashboard form
            dashboard.Show();

            // Close the current form (Dashboard form)
            this.Close();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
        
            // Show the LoginForm
            loginForm.Show();

            // Close the current form (Dashboard form)
            this.Close();

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
            StringBuilder message = new StringBuilder();
            foreach (DataRow row in result.Rows)
            {
                message.AppendLine("Company Name: " + row["Company_Name"].ToString());
                // Add other columns as needed
            }
            MessageBox.Show(message.ToString(), "Active Vendors:");
        }
        // calling HighestPerformingVendorsQuery from sqlQuery class
        private void btnHighestPerformingVendors_Click(object sender, EventArgs e)
        {
            string query = sqlQuery.HighestPerformingVendorsQuery;
            DataTable result = connectDB.ExecuteQuery(query);
            StringBuilder message = new StringBuilder();
            foreach (DataRow row in result.Rows)
            {
                message.AppendLine($"Company Name: {row["Company_Name"]}\nTotal Products:{row["TotalProducts"]}\n");
            }

            MessageBox.Show(message.ToString(), "Top 3 Highest Performing Vendors");

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
