﻿using System.Data;
using System.Data.SqlClient;
namespace SEApp
{
    public partial class VendorsProductsForm : Form
    {
        private Database connectDB;
        DataTable vendorProData;

        public VendorsProductsForm()
        {
            InitializeComponent();
            connectDB = Database.getConnectString();
        }

        // Sets the Data source of the Data grid with the new data when a filter is applied
        private void setDataSource(DataTable sourcedData)
        {
            dgvVendorProduct.DataSource = null;
            dgvVendorProduct.DataSource = sourcedData;
            dgvVendorProduct.ReadOnly = true;
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
            DataTable vendorProData = connectDB.getVendorProducts(sqlQuery.getVendorProductData);
            vendorProData.Columns.Remove("VendorID1");
            setDataSource(vendorProData);
            
            // TODO: This line of code loads data into the 'vendorProducts.VendorInfo' table. You can move, or remove it, as needed.
            //this.vendorInfoTableAdapter.Fill(this.vendorProducts.VendorInfo);
            // TODO: This line of code loads data into the 'vendorProducts.ProductInfo' table. You can move, or remove it, as needed.
            //this.productInfoTableAdapter.Fill(this.vendorProducts.ProductInfo);

        }

        private void btnActiveVendors_Click(object sender, EventArgs e)
        {
            vendorProData = connectDB.getVendorProducts(sqlQuery.ActiveVendorsQuery);
            vendorProData.Columns.Remove("Company_Name1");
            setDataSource(vendorProData);
            
        }

        private void btnRatings_Click(object sender, EventArgs e)
        {
            vendorProData = connectDB.getVendorProducts(sqlQuery.vendorProRatings);
            setDataSource(vendorProData);
            
        }

        private void btnRevertData_Click(object sender, EventArgs e)
        {
           
            vendorProData = connectDB.getVendorProducts(sqlQuery.getVendorProductData);
            vendorProData.Columns.Remove("VendorID1");
            setDataSource(vendorProData);
            
        }

        private void btnVendor_Click(object sender, EventArgs e)
        {
            
            vendorProData = connectDB.getVendorProducts(sqlQuery.allVendors);
            setDataSource(vendorProData);
            
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            
            vendorProData = connectDB.getVendorProducts(sqlQuery.allProducts);
            setDataSource(vendorProData);
           
        }

        // Filters the data table shown in the data grid by cloud service type
        private void cmbCloud_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                switch (cmbCloud.SelectedIndex)
                {
                   //Based Cloud
                    case 0:
                        vendorProData = connectDB.getVendorProducts(sqlQuery.basedCloud);
                        break;
                    //Native Cloud
                    case 1:
                        vendorProData = connectDB.getVendorProducts(sqlQuery.nativeCloud);
                        break;
                    //Enabled Cloud
                    case 2:
                        vendorProData = connectDB.getVendorProducts(sqlQuery.enabledCloud);
                        break;
                    // None
                    case 3:
                        vendorProData = connectDB.getVendorProducts(sqlQuery.noCloud);
                        break;
                    default:
                        
                        vendorProData = connectDB.getVendorProducts(sqlQuery.getVendorProductData);
                        break;
                }
                setDataSource(vendorProData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("This filter has an encountered an error. Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbContactInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (cmbContactInfo.SelectedIndex)
                {
                    case 0:

                        break;
                    case 1:
                        break;
                    default:
                        break;
                }

            }
            catch
            {
                MessageBox.Show("This filter has an encountered an error. Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
