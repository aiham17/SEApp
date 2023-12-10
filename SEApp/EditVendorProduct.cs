using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SEApp.structContainer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SEApp
{
    public partial class EditVendorProduct : Form
    {
        // Adam: Gets the vendorName and productName from the VendorProducts Form
        public string vendorName { get; set;}
        public string productName { get; set;}

        // Adam: Creates instances to allow this form to access the Database class.
        private Database connectDB;

        // Adam: Used to store all the Vendor Information to then be displayed
        DataTable vendorData = new DataTable();
        DataTable contactInfo = new DataTable();
        int vendorID, productID, contactID;
        string cloud;
        public EditVendorProduct()
        {
            InitializeComponent();

            // Adam: Allows this form to access the database class
            connectDB = Database.getConnectString();
        }

        // Adam:When the close button is clicked, the user is returned to the VendorProducts Form
        private void btnClose_Click(object sender, EventArgs e)
        {
            VendorsProductsForm open = new VendorsProductsForm();
            open.Show();
            this.Close();
        }

        // Adam: When the user clicks the Citisoft Logo, they are returned to the Dashboard
        private void pbCitisoftLogo_Click(object sender, EventArgs e)
        {
            this.Close();           
            Dashboard dash = new Dashboard();
            dash.Show();
        }




        /*Adam: When the user clicks the save button, it will try to assign each value entered into the struct editVendor and then pass it to the methods in the Database class
         * This then will attempt to update the vendor in the database and if it cannot the error message: Cannot save the changes to the Database pops up
         * Changed variable names to the struct found in companyInfo. Connor made the initial one, I had to make changes to it because there were errors and wrongly used variable types within it. Can see that in the his github commit
         */
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                companyInfo.vendorInfo editVendor = new companyInfo.vendorInfo();
                contactID = Int32.Parse(cmbContactID.Text.ToString());
                editVendor.vendor = tbVendorName.Text;
                editVendor.website = LLVendorWebsite.Text;
                editVendor.description = rtbDescription.Text;
                editVendor.additionalInfo = rtbAddInfo.Text;
                editVendor.address = rtbAddress.Text;
                editVendor.teleNumber = tbTeleNumber.Text;               
                editVendor.employees = tbEmployees.Text;

                // Used to validate that an integer has been entered into the Number Of Employees Text box
                bool integer = DataValidator.validateInt(editVendor.employees);

                // IF the boolean integer is True then it will continue the variable assignment and pass this information to the Database Class. Otherwise it displays an error message
                if (integer)
                {
                    editVendor.eYear = dtpVendorEstablished.Text;
                    editVendor.reviewDate = dtpLastReviewDate.Text;
                    editVendor.demoDate = dtpDemoDate.Text;
                    editVendor.intPro = Convert.ToInt32(cbInternalProServices.Checked);
                    editVendor.software = tbSoftwareName.Text;
                    editVendor.softwareType = tbSoftwareType.Text;
                    editVendor.businessArea = tbBusinessArea.Text;
                    editVendor.module = tbModule.Text;
                    editVendor.financialService = tbFinancialServices.Text;
                    editVendor.cloud = cmbCloud.Text;

                    // These methods are called and passed all the necessary vendor information, to then be updated in the Database.
                    connectDB.updateVendor(editVendor.vendor, editVendor.website, editVendor.description, editVendor.additionalInfo, editVendor.employees, editVendor.eYear, editVendor.reviewDate, editVendor.demoDate, editVendor.intPro, vendorID);
                    connectDB.updateContact(editVendor.address, editVendor.teleNumber, contactID);
                    connectDB.updateProduct(editVendor.software, editVendor.softwareType, editVendor.businessArea, editVendor.module, editVendor.financialService, editVendor.cloud, productID);
                    MessageBox.Show("The changes made have been successful");
                    this.Close();
                    VendorsProductsForm open = new VendorsProductsForm();
                    open.Show();
                }
                else
                {
                    MessageBox.Show("An whole number needs to be added to employees");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("The changes made could not be saved to the database");
            }
            
            
        }

        

        // Adam: Loads all the vendor and product data stored in the datatable into their respective fields on the form
        private void EditVendorProduct_Load(object sender, EventArgs e)
        {

            try
            {
                vendorData = connectDB.getVendorProductInfo(vendorName, productName);
                vendorID = (int)vendorData.Rows[0][0];
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

        
        //Adam: This method opens the URL Link when clicked
        private void LLVendorWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(LLVendorWebsite.Text);
        }

        //Adam: Selects the different contact information depending upon the selected ContactID. And then updates the text boxes with this data
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

        //Adam: Deletes the selected product displayed, depending upon whether the user's role is an Admin or Owner and they click Yes on the Message Box.
        // If they click no, they are returned to the VendorProducts Form
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            string username = LoginForm.GetLoggedInUsername();
            string userRole = connectDB.GetUserRole(username);
            if (userRole == "0" || userRole == "1")
            {
                DialogResult delete = MessageBox.Show("Do you wish to delete this Product?", "Delete Product", MessageBoxButtons.YesNo);
                if (delete == DialogResult.Yes)
                {
                    connectDB.deleteProduct(productID);
                    this.Close();
                    VendorsProductsForm open = new VendorsProductsForm();
                    open.Show();
                }
                else if (delete == DialogResult.No)
                {
                    this.Close();
                    VendorsProductsForm open = new VendorsProductsForm();
                    open.Show();
                }
            }
        }

        // Adam: Opens the associated pdf document with the vendor and its products. Not all of them have one so a message box will pop informing the user
        // if there isnt one.
        // https://stackoverflow.com/questions/12335618/file-path-for-project-files
        // The website above I used to enable a temporary file path to be created so the pdf document can be opened no matter the machine
        private void btnOpenPDF_Click(object sender, EventArgs e)
        {
            string fileName = connectDB.getPdfName(vendorID, productID);
            if(fileName != null)
            {
                string filePath = Path.Combine(Environment.CurrentDirectory, @"PDF Documents\", fileName);
                System.Diagnostics.Process.Start(filePath);
            }
            else
            {
                MessageBox.Show("No PDF Documents are attached", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
           
            
        }

        //Adam: Deletes the selected Vendor displayed, depending upon whether the user's role is an Admin or Owner and they click Yes on the Message Box.
        // If they click no, they are returned to the VendorProducts Form
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string username = LoginForm.GetLoggedInUsername();
            string userRole = connectDB.GetUserRole(username);
            if (userRole == "0" || userRole == "1")
            {
                DialogResult delete = MessageBox.Show("Do you wish to delete this vendor?", "Delete Vendor", MessageBoxButtons.YesNo);
                if (delete == DialogResult.Yes)
                {
                    connectDB.deleteVendorProduct(vendorID);
                    this.Close();
                    VendorsProductsForm open = new VendorsProductsForm();
                    open.Show();
                }
                else if (delete == DialogResult.No)
                {
                    this.Close();
                    VendorsProductsForm open = new VendorsProductsForm();
                    open.Show();
                }
            }
        }

        //Adam:
        /* The btnEditVendor_Click method checks the user's role and if they have permission (admin or owner).
         * It then checks if a row is selected in the DataGridView (dgvVendorProduct).
         * If both conditions are met, it opens the EditVendorProduct form with the selected vendor and product names; 
         * otherwise, it displays error messages.*/
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
