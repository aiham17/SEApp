using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
      
        // Implemented the dashboard buttons
        private void btnSetting_Click(object sender, EventArgs e)
        {
            // Create an instance of the SettingsForm
            SettingsForm settingsForm = new SettingsForm();

            settingsForm.Show();

            // Close the current form (Dashboard form)
            this.Close();
        }

        private void btnAddOrAdjustVendors_Click(object sender, EventArgs e)
        {
            // Create an instance of the AddAdjustForm
            AddAdjustForm addAdjustForm = new AddAdjustForm();

            // Show the AddAdjustForm
           
            addAdjustForm.Show();

            // Close the current form (Dashboard form)
            this.Close();

        }

        private void btnVendorsAndProducts_Click(object sender, EventArgs e)
        {

            // Create an instance of the VendorsProductsForm
            VendorsProductsForm vendorsProductsForm = new VendorsProductsForm();

            // Show the VendorsProductsForm
            
            vendorsProductsForm.Show();

            // Close the current form (Dashboard form)
            this.Close();

        }

        // 
        private void btnDashBoard_Click(object sender, EventArgs e)
        {


            // Create an instance of the Dashboard Form
            Dashboard dashboard = new Dashboard();

            // Show the Dashboard form
            dashboard.Show();

            // Hide the current form (Dashboard form)
            this.Hide();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {


            // Create an instance of the LoginForm
            LoginForm loginForm = new LoginForm();

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
        // Added pie chart and Implemented it to display the ActiveVendorsQuery
        private void chActiveVendors_Click(object sender, EventArgs e)
        {
            string query = sqlQuery.ActiveVendorsQuery;
            DataTable result = connectDB.ExecuteQuery(query);

            // Clear any existing data in the chart
            chActiveVendors.Series.Clear();

            // Add a new series to the chart
            Series series = new Series("ActiveVendors");
            series.ChartType = SeriesChartType.Pie;

            // Add data points to the series
            foreach (DataRow row in result.Rows)
            {
                string companyName = row["Company_Name"].ToString();
                series.Points.AddXY(companyName, 1);
            }

            // Set label properties
            series["PieLabelStyle"] = "Disabled"; // Disable regular pie labels
            series.IsValueShownAsLabel = true; // Show data point values as labels inside the slices

            // Add the series to the chart
            chActiveVendors.Series.Add(series);

            // Set some chart properties if needed
            chActiveVendors.Titles.Add("Active Vendors");
            chActiveVendors.ChartAreas[0].Area3DStyle.Enable3D = true;

            // Show the chart
            chActiveVendors.Show();

        }
        // Added Bar chart and Implemented it to display the HighestPerformingVendorsQuery
        private void chHPVendors_Click(object sender, EventArgs e)
        {

            string query = sqlQuery.HighestPerformingVendorsQuery;
            DataTable result = connectDB.ExecuteQuery(query);

            chHPVendors.Series.Clear();
            chHPVendors.ChartAreas[0].AxisX.Title = "Company Name";
            chHPVendors.ChartAreas[0].AxisY.Title = "Total Products";

            // Set the chart title
            chHPVendors.Titles.Add("Highest Performing Vendors");

            foreach (DataRow row in result.Rows)
            {
                string companyName = row["Company_Name"].ToString();
                int totalProducts = Convert.ToInt32(row["TotalProducts"]);

                chHPVendors.Series.Add(companyName);
                chHPVendors.Series[companyName].Points.AddXY(companyName, totalProducts);
            }
        }

        
    }
}
