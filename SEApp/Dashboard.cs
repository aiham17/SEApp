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
    public partial class Dashboard : Form
    {
        public Dashboard ()
        {
            InitializeComponent();
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

      

        private void btnTotalNumberOfVendors_Click(object sender, EventArgs e)
        {

        }

        private void btnActiveVendors_Click(object sender, EventArgs e)
        {

        }

        private void btnHighestPerformingVendors_Click(object sender, EventArgs e)
        {

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
