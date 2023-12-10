using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace SEApp
{
    public partial class VendorsProductsForm : Form
    {
        //Adam: These strings store the vendor and software names. These are passed to the EditVendor Form
        public string vendorName;
        public string productName;
        // Creates a instance to allow the form to connect to the database
        private Database connectDB;
        // Used to store the data read from the database
        DataTable vendorProData;

        
        public VendorsProductsForm()
        {
            InitializeComponent();
            //Adam: Acquire access to the Database class.
            connectDB = Database.getConnectString();

            //Aiham:
            // Get the logged-in username
            string loggedInUsername = LoginForm.GetLoggedInUsername();

            // Set the displayed username in the TextBox
            tbDisplayedUsername.Text = loggedInUsername;
        }

        //Adam
        // Sets the Data source of the Data grid with the new data when a filter is applied
        public void setDataSource(DataTable sourcedData, DataGridView display)
        {
            display.DataSource = null;
            display.DataSource = sourcedData;

            for (int i = 0; i < display.Columns.Count; i++)
            {
                display.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            }

            display.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            display.ReadOnly = true;
        }

        // Adam: Opens the Dashboard and closes the VendorProducts Form.
        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            // Create an instance of the Dashboard Form
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }

        // Adam: Reloads the VendorProducts Form.
        private void btnVendorsAndProducts_Click(object sender, EventArgs e)
        {
            // Create an instance of the VendorsProductsForm
            VendorsProductsForm vendorsProductsForm = new VendorsProductsForm();
            vendorsProductsForm.Show();
            this.Close();
        }

        // Aiham: Added the userRole check, the retrieval of the Username and the if statement.
        // added functionality to btnAddOrAdjustVendors to allow access to AddAdjustForm for admins and owners.
        // Adam: The instance creation of the AddVendorForm.
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
                AddVendorForm addAdjustForm = new AddVendorForm();
                addAdjustForm.Show();
                this.Close();
            }
            else
            {
                // Display access denied message
                MessageBox.Show("Access Denied. You do not have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        //Adam: When the Settings button is clicked, the Settings form is opened and the VendorProducts Form is closed.
        private void btnSetting_Click(object sender, EventArgs e)
        {
            // Create an instance of the SettingsForm
            SettingsForm settingsForm = new SettingsForm();

            settingsForm.Show();
            this.Close();

        }

        //Aiham:
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Create an instance of the LoginForm
            LoginForm loginForm = new LoginForm();

            loginForm.Show();
            this.Close();
        }

        /*Adam: On load, a SQL Query is sent to the Database, to grab data from the VendorInfo & ProductInfo tables.
         * This data is then stored in the DataTable vendorProData and this is set as the Data Source to be displayed
         * To the User.
         */
        private void VendorsProductsForm_Load(object sender, EventArgs e)
        {
            DataTable vendorProData = connectDB.getVendorProducts(sqlQuery.getVendorProductData);
            vendorProData.Columns.Remove("VendorID1");
            setDataSource(vendorProData, dgvVendorProduct);
            dgvVendorProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


        }

        /*Adam: If the user clicks the Active Vendors Button, a SQL Query is sent to retrieve
         * the vendors that have been reviewed in the last 6 months. Then this data is stored in 
         * the data table and set as the source of the Data Grid View.
        */
        private void btnActiveVendors_Click(object sender, EventArgs e)
        {
            vendorProData = connectDB.getVendorProducts(sqlQuery.activeVendorData);
            
            setDataSource(vendorProData, dgvVendorProduct);
            
        }

        /*Adam: If the user clicks the Ratings Data Button, a SQL Query is sent to retrieve
         * all the ratings for the Vendors and Products to then average them. This data
         * is then stored in a data table and is set as the source of the Data Grid View.
        */
        private void btnRatings_Click(object sender, EventArgs e)
        {
            vendorProData = connectDB.getVendorProducts(sqlQuery.vendorProRatings);
            setDataSource(vendorProData, dgvVendorProduct);
        }

        /*Adam: If the user clicks the Revert Data Button, a SQL Query is sent to retrieve
         * the original data that was shown when the Form loaded to then be displayed.
        */
        private void btnRevertData_Click(object sender, EventArgs e)
        {
            vendorProData = connectDB.getVendorProducts(sqlQuery.getVendorProductData);
            vendorProData.Columns.Remove("VendorID1");
            setDataSource(vendorProData, dgvVendorProduct);
        }

        /*Adam: If the user clicks the Vendor Data Button, a SQL Query is sent to retrieve
         * all and only the Vendor Data to be displayed into the Data Grid View.
        */
        private void btnVendor_Click(object sender, EventArgs e)
        {
            vendorProData = connectDB.getVendorProducts(sqlQuery.allVendors);
            setDataSource(vendorProData, dgvVendorProduct);
        }

        /*Adam: If the user clicks the Product Data Button, a SQL Query is sent to retrieve
         * all and only the Product Data to be displayed into the Data Grid View.
        */
        private void btnProduct_Click(object sender, EventArgs e)
        {
            vendorProData = connectDB.getVendorProducts(sqlQuery.allProducts);
            setDataSource(vendorProData, dgvVendorProduct);
        }

        //Adam
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

        //Adam
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
                if (dgvVendorProduct.Columns.Contains("Addresses") && dgvVendorProduct.Columns.Contains("Telephone_Numbers"))
                {
                    dgvVendorProduct.Columns["Addresses"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvVendorProduct.Columns["Telephone_Numbers"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                
                

            }
            catch
            {
                MessageBox.Show("This filter has an encountered an error. Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Adam
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

        //Adam
        // Exports the data in the data grid to a PDF Document 
        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            exportPDF pdf = new exportPDF();
            pdf.exportPDFDoc(dgvVendorProduct);
            
        }

        //Adam
        // Gets the company name or software name in the row the user has selected to then have a pop up screen to display the vendor and product information in a 
        // more readable format (EditVendorProducts Form)
        private void dgvVendorProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            int selectedRow = dgvVendorProduct.Rows.GetRowCount(DataGridViewElementStates.Selected);
            
            //int selectedVendor, selectedProduct;
            if(selectedRow > 0)
            {
                try
                {
                    EditVendorProduct open = new EditVendorProduct();
                    if (dgvVendorProduct.Columns.Contains("Company_Name") && dgvVendorProduct.Columns.Contains("Software_Name"))
                    {
                        vendorName = dgvVendorProduct.Rows[e.RowIndex].Cells["Company_Name"].Value.ToString();
                        productName = dgvVendorProduct.Rows[e.RowIndex].Cells["Software_Name"].Value.ToString();
                        
                        open.vendorName = vendorName;
                        open.productName = productName;
                        open.Show();
                        this.Close();

                    }
                    else if (dgvVendorProduct.Columns.Contains("Software_Name"))
                    {
                        productName = dgvVendorProduct.Rows[e.RowIndex].Cells["Software_Name"].Value.ToString();
                        
                        open.productName = productName;
                        open.Show();
                        this.Close();

                    }
                    else if (dgvVendorProduct.Columns.Contains("Company_Name"))
                    {
                        vendorName = dgvVendorProduct.Rows[e.RowIndex].Cells["Company_Name"].Value.ToString();
                        open.vendorName = vendorName;
                        open.Show();
                        this.Close();
                    }
                    else
                    {
                        open.Close();
                        MessageBox.Show("You cannot view extra information here");
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please do NOT SELECT the Column Name" + ex.Message);    
                }
                // Gets the the row index that the user has clicked on in the data grid.
                // Based off this selection will get the VendorID and the Product ID
                
                
                
                
                               

            }
            
        }

        private void tbDisplayedUsername_TextChanged(object sender, EventArgs e)
        {

        }


        //Aiham:

        /* The  btnEditVendor button allows an admin or owner to edit vendor information by opening the EditVendorProduct form
         * and passing the selected vendor and product names to it. 
         * If the user doesn't have the necessary permissions or if no row is selected, appropriate messages are displayed*/
        private void btnEditVendor_Click(object sender, EventArgs e)
        {
            // Retrieve the logged-in username using the static method
            string username = LoginForm.GetLoggedInUsername();

            // Fetch the user's role from the database using the Database class
            string userRole = connectDB.GetUserRole(username);

            // Check if the user is an admin or owner
            if (userRole == "0" || userRole == "1")
            {
                // Check if a row is selected in the DataGridView
                if (dgvVendorProduct.SelectedRows.Count > 0)
                {
                    // Get the first selected row
                    DataGridViewRow selectedRow = dgvVendorProduct.SelectedRows[0];

                    // Get the vendor and product names from the selected row
                    string vendorName = selectedRow.Cells["Company_Name"].Value.ToString();
                    string productName = selectedRow.Cells["Software_Name"].Value.ToString();

                    // Open the EditVendorProduct form with the selected vendor and product names
                    EditVendorProduct editVendorProductForm = new EditVendorProduct();
                    editVendorProductForm.vendorName = vendorName;
                    editVendorProductForm.productName = productName;
                    editVendorProductForm.Show();
                    this.Close();
                }
                else
                {
                    // Display error message if no row is selected
                    MessageBox.Show("Please select a row to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Display access denied message
                MessageBox.Show("Access Denied. You do not have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
