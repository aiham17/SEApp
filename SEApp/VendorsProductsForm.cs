﻿using System.Data;
using System.Data.SqlClient;
namespace SEApp
{
    public partial class VendorsProductsForm : Form
    {
        private Database connectDB;

        public VendorsProductsForm()
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

        private void btnAddOrAdjustVendors_Click(object sender, EventArgs e)
        {
            // Create an instance of the AddAdjustForm
            AddAdjustForm addAdjustForm = new AddAdjustForm();

            addAdjustForm.Show();
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

        private void VendorsProductsForm_Load(object sender, EventArgs e)
        {
            DataTable vendorProData = connectDB.getVendorProducts();
            vendorProData.Columns.Remove("VendorID1");
            dgvVendorProduct.DataSource = vendorProData;
            // TODO: This line of code loads data into the 'vendorProducts.VendorInfo' table. You can move, or remove it, as needed.
            this.vendorInfoTableAdapter.Fill(this.vendorProducts.VendorInfo);
            // TODO: This line of code loads data into the 'vendorProducts.ProductInfo' table. You can move, or remove it, as needed.
            this.productInfoTableAdapter.Fill(this.vendorProducts.ProductInfo);

        }
    }
}
