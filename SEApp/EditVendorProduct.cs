using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SEApp
{
    public partial class EditVendorProduct : Form
    {
        public string vendorName { get; set;}
        public string productName { get; set;}
        private Database connectDB;
        DataTable vendorData = new DataTable();
        DataTable contactInfo = new DataTable();
        int vendorID, productID;
        string cloud;
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

        // Get the text, integers or date time values entered by the user and add them into their respective columns based off VendorID, Contact ID and ProductID
        private void btnSave_Click(object sender, EventArgs e)
        {
            // UPDATE UserInformation SET Username = @Username, Password = @Password, Salt = @Salt, Email = @Email WHERE UserID = @UserID
            string vendor, website, description, additionalInfo, software, softwareType, businessArea, module, financialService, cloud, teleNumber, address, eYear, reviewDate, DemoDate, employees;
            int contactID = Int32.Parse(cmbContactID.Text.ToString());
            vendor = tbVendorName.Text;
            website = LLVendorWebsite.Text;
            description = rtbDescription.Text;
            additionalInfo = rtbAddInfo.Text;
            address = rtbAddress.Text;
            teleNumber = tbTeleNumber.Text;
            employees = tbEmployees.Text;
            eYear = dtpVendorEstablished.Text;
            reviewDate = dtpLastReviewDate.Text;
            DemoDate = dtpDemoDate.Text;

            software = tbSoftwareName.Text;
            softwareType = tbSoftwareType.Text;
            businessArea = tbBusinessArea.Text;
            module = tbModule.Text;
            financialService = tbFinancialServices.Text;
            cloud = cmbCloud.Text;

        }

        // Loads all the vendor and product data stored in the datatable into their respective fields on the form
        private void EditVendorProduct_Load(object sender, EventArgs e)
        {

            try
            {
                vendorData = connectDB.getVendorProductInfo(vendorName, productName);
                int vendorID = (int)vendorData.Rows[0][0];
                productID = (int)vendorData.Rows[0][10];
                contactInfo = connectDB.readVendorContact(contactInfo, vendorID);
                

                if ((vendorData != null) && (contactInfo!=null))
                {
                    tbVendorName.Text = vendorData.Rows[0][1].ToString();
                    LLVendorWebsite.Text = vendorData.Rows[0][2].ToString();
                    rtbDescription.Text = vendorData.Rows[0][3].ToString();
                    dtpVendorEstablished.Value = Convert.ToDateTime(vendorData.Rows[0][4].ToString());
                    tbEmployees.Text = vendorData.Rows[0][5].ToString();
                    dtpLastReviewDate.Value = Convert.ToDateTime(vendorData.Rows[0][6].ToString());
                    dtpDemoDate.Value = Convert.ToDateTime(vendorData.Rows[0][7].ToString());
                    rtbAddInfo.Text = vendorData.Rows[0][8].ToString();
                    cbInternalProServices.Checked = Convert.ToBoolean(vendorData.Rows[0][9].ToString());
                    cbInternalProServices.Enabled = false;
                    tbSoftwareName.Text = vendorData.Rows[0][12].ToString();
                    tbSoftwareType.Text = vendorData.Rows[0][13].ToString();
                    tbBusinessArea.Text = vendorData.Rows[0][14].ToString();
                    tbModule.Text = vendorData.Rows[0][15].ToString();
                    tbFinancialServices.Text = vendorData.Rows[0][16].ToString();
                    cmbContactID.DisplayMember = "ContactID";
                    cmbContactID.DataSource = contactInfo;
                    cmbCloud.DisplayMember = "Cloud_Service_Type";
                    cmbCloud.ValueMember = "ID";
                    cloud = vendorData.Rows[0][17].ToString();
                    cmbCloud.DataSource = vendorData;
                }
                else
                {
                    MessageBox.Show("An error has occurred with viewing the data");
                }

                foreach (TextBox textbox in this.Controls.OfType<TextBox>())
                {
                    textbox.ReadOnly = true;
                }
                foreach(RichTextBox richText in this.Controls.OfType<RichTextBox>())
                {
                    richText.ReadOnly = true;
                }
                
                

                
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error has occurred");
                EditVendorProduct close = new EditVendorProduct();
                close.Close();
            }
            
        }

        

        private void LLVendorWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(LLVendorWebsite.Text);
        }

        // Gets all the different contact information depending upon the selected ContactID. 
        private void cmbContactID_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox selected = (ComboBox)sender;
            string contactID = selected.Text;
            int selectedID = Int32.Parse(contactID);
            if(contactInfo.Rows.Count > 0)
            {
                for(int i = 0; i<contactInfo.Rows.Count; i++)
                {
                    int value = Convert.ToInt32(contactInfo.Rows[i][0]);
                    if (value == selectedID)
                    {
                        tbTeleNumber.Text = contactInfo.Rows[i][2].ToString();
                        rtbAddress.Text = contactInfo.Rows[i][3].ToString();
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string username = LoginForm.GetLoggedInUsername();
            string userRole = connectDB.GetUserRole(username);
            if (userRole == "0" || userRole == "1")
            {
                foreach (TextBox textbox in this.Controls.OfType<TextBox>())
                {
                    textbox.ReadOnly = false;
                }
                foreach (RichTextBox richText in this.Controls.OfType<RichTextBox>())
                {
                    richText.ReadOnly = false;
                }
                cbInternalProServices.Enabled = true;
                cmbCloud.DataSource = null;
                cmbCloud.Items.Add("Enabled");
                cmbCloud.Items.Add("Native");
                cmbCloud.Items.Add("Based");
                cmbCloud.Items.Add("NULL");
                cloud = cloud.Trim();
                int index = cmbCloud.Items.IndexOf(cloud);
                cmbCloud.SelectedIndex = index;
                cmbCloud.DisplayMember = (string)cmbCloud.Items[index];
            }
            else
            {
                MessageBox.Show("Access Denied. You do not have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            

        }
    }
}
