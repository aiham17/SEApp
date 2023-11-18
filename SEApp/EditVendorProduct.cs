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
    public partial class EditVendorProduct : Form
    {
        public string vendorName { get; set;}
        public string productName { get; set;}
        private Database connectDB;
        public EditVendorProduct()
        {
            InitializeComponent();
            connectDB = Database.getConnectString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbCitisoftLogo_Click(object sender, EventArgs e)
        {
            this.Close();           
            Dashboard dash = new Dashboard();
            dash.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void EditVendorProduct_Load(object sender, EventArgs e)
        {
            DataTable vendorData = new DataTable();
            vendorData= connectDB.getVendorProductInfo(vendorName, productName);
            tbVendorName.Text = vendorData.Rows[0][1].ToString();
        }
    }
}
