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
            // Call the chart functions here to display them automatically
            chActiveVendors_Click(null, null);
            chHPVendors_Click(null, null);
            chLPVendors_Click(null, null);
            chHighestProduct_Click(null, null);
            chLowestProduct_Click(null, null);

            // Get the logged-in username
            string loggedInUsername = LoginForm.GetLoggedInUsername();

            // Set the displayed username in the TextBox along with a welcome message
            tbDisplayedUsername.Text = $"Welcome, {loggedInUsername} !";

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

            // Hide the current form (Dashboard form)
            this.Hide();
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

            // Hide the current form (Dashboard form)
            this.Hide();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {


            // Create an instance of the LoginForm
            LoginForm loginForm = new LoginForm();

            // Show the LoginForm
            loginForm.Show();

            // Hide the current form (Dashboard form)
            this.Hide();

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
        // Added Column chart and Implemented it to display the HighestPerformingVendorsQuery
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

        // Added Bar chart and Implemented it to display the LowestPerformingVendorsQuery
        private void chLPVendors_Click(object sender, EventArgs e)
        {
            string vendorQuery = sqlQuery.LowestPerformingVendorsQuery;
            DataTable vendorResult = connectDB.ExecuteQuery(vendorQuery);

            // Clear any existing data in the chart
            chLPVendors.Series.Clear();


            // Create a new series for the chart
            Series series = new Series();

            // Set the chart type (Bar)
            series.ChartType = SeriesChartType.Bar;

            // Add data points to the series
            foreach (DataRow row in vendorResult.Rows)
            {
                string companyName = row["Company_Name"].ToString();
                int totalProducts = Convert.ToInt32(row["TotalProducts"]);

                series.Points.AddXY(companyName, totalProducts);
            }

            // Add the series to the chart
            chLPVendors.Series.Add(series);

            if (chLPVendors.Series.Count > 0)
            {
                chLPVendors.Series[0].IsVisibleInLegend = false;
            }



            // Set the minimum and maximum values for the Y-axis
            chLPVendors.ChartAreas[0].AxisY.Minimum = 0;
            chLPVendors.ChartAreas[0].AxisY.Maximum = 5;

            chLPVendors.Titles.Add("Lowest Performing Vendors");
            // Set the title for the Y-axis
            chLPVendors.ChartAreas[0].AxisY.Title = "Total Products";

        }

        // Added Spline chart and Implemented it to display theHighestPerformingProductsQuery
        private void chHighestProduct_Click(object sender, EventArgs e)
        {
            string query = sqlQuery.HighestPerformingProductsQuery;
            DataTable result = connectDB.ExecuteQuery(query);

            // Clear any existing data in the chart
            chHighestProduct.Series.Clear();

            // Create a new series for the chart
            Series series = new Series();
            series.ChartType = SeriesChartType.Spline;

            // Add data to the series
            foreach (DataRow row in result.Rows)
            {
                string softwareName = row["Software_Name"].ToString();
                double overallRating = Convert.ToDouble(row["OverallRating"]);

                // Add a data point to the series
                DataPoint dataPoint = new DataPoint();
                dataPoint.SetValueY(overallRating);
                dataPoint.AxisLabel = softwareName;
                series.Points.Add(dataPoint);
            }

            // Add the series to the chart
            chHighestProduct.Series.Add(series);

            if (chHighestProduct.Series.Count > 0)
            {
                chHighestProduct.Series[0].IsVisibleInLegend = false;
            }

            // Set chart title and axis labels as needed
            chHighestProduct.Titles.Add("Highest Performing Products");
            chHighestProduct.ChartAreas[0].AxisX.Title = "Software Name";
            chHighestProduct.ChartAreas[0].AxisY.Title = "Overall Rating";
        }

        // Added Doughnut chart and Implemented it to display the LowestPerformingProductsQuery
        private void chLowestProduct_Click(object sender, EventArgs e)
        {
            string lowestRatingQuery = sqlQuery.LowestPerformingProductsQuery;
            DataTable queryResult = connectDB.ExecuteQuery(lowestRatingQuery);

            // Clear any existing data in the chart
            chLowestProduct.Series.Clear();
            chLowestProduct.Titles.Clear();
            chLowestProduct.Legends.Clear();

            // Create a new series
            Series series = new Series("LowestRatedProducts");
            series.ChartType = SeriesChartType.Doughnut;

            // Add the series to the chart
            chLowestProduct.Series.Add(series);

            // Create a legend
            Legend legend = new Legend("Legend");
            legend.Docking = Docking.Bottom;
            chLowestProduct.Legends.Add(legend);

            // Iterate through the query result and add data points to the series
            foreach (DataRow row in queryResult.Rows)
            {
                string productName = row["Software_Name"].ToString();
                double lowestRating = Convert.ToDouble(row["LowestRating"]);

                DataPoint dataPoint = new DataPoint();
                dataPoint.SetValueY(lowestRating);

                // Set the data point label to include rating
                dataPoint.Label = $"{lowestRating:F1}";

                // Add the data point to the series
                series.Points.Add(dataPoint);

                // Add the product name to the legend
                series.Points[series.Points.Count - 1].LegendText = productName;
            }

            // Set chart title
            chLowestProduct.Titles.Add("Lowest Rated Products");
        }

        private void tbDisplayedUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }

}