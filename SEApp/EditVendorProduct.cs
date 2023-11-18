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
            try
            {
                DataTable vendorData = new DataTable();
                vendorData = connectDB.getVendorProductInfo(vendorName, productName);
                if(vendorData != null)
                {
                    tbVendorName.Text = vendorData.Rows[0][1].ToString();
                    tbVendorWebsite.Text = vendorData.Rows[0][2].ToString();
                    rtbDescription.Text = vendorData.Rows[0][3].ToString();
                    dtpVendorEstablished.Value = Convert.ToDateTime(vendorData.Rows[0][4].ToString());
                    tbEmployees.Text = vendorData.Rows[0][5].ToString();
                    dtpLastReviewDate.Value = Convert.ToDateTime(vendorData.Rows[0][6].ToString());
                    dtpDemoDate.Value = Convert.ToDateTime(vendorData.Rows[0][7].ToString());
                    rtbAddInfo.Text = vendorData.Rows[0][8].ToString();
                    cbInternalProServices.Checked = Convert.ToBoolean(vendorData.Rows[0][9].ToString());
                }
                else
                {
                    MessageBox.Show("An error has occurred");
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error has occurred");
            }
            
        }
    }
}
