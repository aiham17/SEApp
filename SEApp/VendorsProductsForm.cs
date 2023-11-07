using System.Data;
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
            dgvVendorProduct.DataSource = vendorProData;
            dgvVendorProduct.ReadOnly = true;
            // TODO: This line of code loads data into the 'vendorProducts.VendorInfo' table. You can move, or remove it, as needed.
            //this.vendorInfoTableAdapter.Fill(this.vendorProducts.VendorInfo);
            // TODO: This line of code loads data into the 'vendorProducts.ProductInfo' table. You can move, or remove it, as needed.
            //this.productInfoTableAdapter.Fill(this.vendorProducts.ProductInfo);

        }

        private void btnActiveVendors_Click(object sender, EventArgs e)
        {
            vendorProData = connectDB.getVendorProducts(sqlQuery.ActiveVendorsQuery);
            vendorProData.Columns.Remove("Company_Name1");
            dgvVendorProduct.DataSource = vendorProData;
            dgvVendorProduct.ReadOnly = true;
        }

        private void btnRatings_Click(object sender, EventArgs e)
        {
            vendorProData = connectDB.getVendorProducts(sqlQuery.vendorProRatings);
            dgvVendorProduct.DataSource = vendorProData;
            dgvVendorProduct.ReadOnly = true;
        }

        private void btnRevertData_Click(object sender, EventArgs e)
        {
            vendorProData.Reset();
            vendorProData = connectDB.getVendorProducts(sqlQuery.getVendorProductData);
            vendorProData.Columns.Remove("VendorID1");
            dgvVendorProduct.DataSource = vendorProData;
            dgvVendorProduct.ReadOnly = true;
        }

        private void btnVendor_Click(object sender, EventArgs e)
        {
            vendorProData = connectDB.getVendorProducts(sqlQuery.allVendors);
            dgvVendorProduct.DataSource = vendorProData;
            dgvVendorProduct.ReadOnly = true;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            vendorProData = connectDB.getVendorProducts(sqlQuery.allProducts);
            dgvVendorProduct.DataSource = vendorProData;
            dgvVendorProduct.ReadOnly = true;
        }

        private void cmbCloud_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (cmbCloud.SelectedIndex)
                {
                    //Based Cloud
                    case 0:
                        //vendorProData = connectDB.getVendorProducts();

                        break;
                    //Native Cloud
                    case 1:
                        break;
                    //Enabled Cloud
                    case 2:
                        break;
                    // None
                    case 3:
                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("You cannot apply this filter to this data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
