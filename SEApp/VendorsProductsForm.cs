﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

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
        public void setDataSource(DataTable sourcedData, DataGridView display)
        {
            display.DataSource = null;
            display.DataSource = sourcedData;
            //display.Columns["Description"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //display.Columns["Additional_Info"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //display.Columns["Address"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //display.Columns["Contact_Telephone"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            
            display.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            display.ReadOnly = true;
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
            setDataSource(vendorProData, dgvVendorProduct);
            
            // TODO: This line of code loads data into the 'vendorProducts.VendorInfo' table. You can move, or remove it, as needed.
            //this.vendorInfoTableAdapter.Fill(this.vendorProducts.VendorInfo);
            // TODO: This line of code loads data into the 'vendorProducts.ProductInfo' table. You can move, or remove it, as needed.
            //this.productInfoTableAdapter.Fill(this.vendorProducts.ProductInfo);

        }

        private void btnActiveVendors_Click(object sender, EventArgs e)
        {
            vendorProData = connectDB.getVendorProducts(sqlQuery.activeVendorData);
            
            setDataSource(vendorProData, dgvVendorProduct);
            
        }

        private void btnRatings_Click(object sender, EventArgs e)
        {
            vendorProData = connectDB.getVendorProducts(sqlQuery.vendorProRatings);
            setDataSource(vendorProData, dgvVendorProduct);
        }

        private void btnRevertData_Click(object sender, EventArgs e)
        {
            vendorProData = connectDB.getVendorProducts(sqlQuery.getVendorProductData);
            vendorProData.Columns.Remove("VendorID1");
            setDataSource(vendorProData, dgvVendorProduct);
        }

        private void btnVendor_Click(object sender, EventArgs e)
        {
            vendorProData = connectDB.getVendorProducts(sqlQuery.allVendors);
            setDataSource(vendorProData, dgvVendorProduct);
        }

        
        private void btnProduct_Click(object sender, EventArgs e)
        {
            vendorProData = connectDB.getVendorProducts(sqlQuery.allProducts);
            setDataSource(vendorProData, dgvVendorProduct);
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
                setDataSource(vendorProData, dgvVendorProduct);
            }
            catch
            {
                MessageBox.Show("This filter has an encountered an error. Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Filters the data table by either showing all contact information for all vendors or only active ones
        private void cmbContactInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (cmbContactInfo.SelectedIndex)
                {
                    case 0:
                        vendorProData = connectDB.getVendorProducts(sqlQuery.allContact);
                        break;
                    case 1:
                        vendorProData = connectDB.getVendorProducts(sqlQuery.activeContact);
                        break;
                    default:
                        vendorProData = connectDB.getVendorProducts(sqlQuery.allVendors);
                        break;
                }
                setDataSource(vendorProData, dgvVendorProduct);

            }
            catch
            {
                MessageBox.Show("This filter has an encountered an error. Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Filters the companies based of age, and sets a range for them to be apart of: 0-5 years, 6-10 year and then 10+
        private void cmbCompanyAge_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (cmbCompanyAge.SelectedIndex)
                {
                    case 0:
                        vendorProData = connectDB.getVendorProducts(sqlQuery.zeroFiveVendor);
                        break;
                    case 1:
                        vendorProData = connectDB.getVendorProducts(sqlQuery.fiveTenVendor);
                        break;
                    case 2:
                        vendorProData = connectDB.getVendorProducts(sqlQuery.tenVendor);
                        break;
                    default:
                        break;
                }
                setDataSource(vendorProData, dgvVendorProduct);
            }
            catch
            {
                MessageBox.Show("This filter has an encountered an error. Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


       // Exports the data in the data grid to a PDF Document 
        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            exportPDF pdf = new exportPDF();
            pdf.exportPDFDoc(dgvVendorProduct);
            
        }
    }
}
