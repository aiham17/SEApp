using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iTextSharp.text.pdf.PRTokeniser;
using static SEApp.structContainer;

namespace SEApp
{
    public partial class AddVendorForm : Form
    {

        // Database conection object
        private Database connectDB;

        

        // Constructor for the AddAdjustForm
        public AddVendorForm()
        {
            //initilize the database connection
            InitializeComponent();
            connectDB = Database.getConnectString();
        }

        

        //Here, we're calling the ValidateInputs method from the DataValidator class to perform input validation.

     

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            // Create an instance of the Dashboard Form
            Dashboard  dashboard = new Dashboard();
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

        private void btnAddOrAdjustVendors_Click(object sender, EventArgs e)
        {
            // Create an instance of the AddAdjustForm
            AddVendorForm addAdjustForm = new AddVendorForm();
            addAdjustForm.Show();
            this.Close();

        }

        // Connor & Adam: Created the Struct for storing the details entered by the User. Connor made the original and Adam tweaked this.
        // Connor: User Entered data assigned to the struct created. Adam: Tweaked this to allow these variables to be assigned in the correct format
        // Adam: Added the input Validation for: URLs, Telephone Number and the Integers; the method method calls: addVendor, addContact and addProduct. Put this in a try catch and added the clearing of the data fields
        //Adam: This method is used to save and add a new vendor to the database; validates specific user entered information before this is added. Otherwise an error message will be displayed.
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                companyInfo.vendorInfo addVendor = new companyInfo.vendorInfo();
                addVendor.vendor = tbVendorName.Text;
                addVendor.website = tbWebsite.Text;

                // This validates whether the URL Entered into tbWebsite follows a Http or Https scheme. If it does, this will be saved, if not however and error message occurs
                // Code from: https://stackoverflow.com/questions/7578857/how-to-check-whether-a-string-is-a-valid-http-url
                Uri uriResult;
                bool validURL = Uri.TryCreate(addVendor.website, UriKind.Absolute, out uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
                if (validURL)
                {
                    addVendor.description = rtbDescription.Text;
                    addVendor.additionalInfo = rtbAddInfo.Text;
                    addVendor.address = rtbAddress.Text;
                    addVendor.teleNumber = tbTeleNumber.Text;
                    bool validNumber = DataValidator.validatePhoneNumber(addVendor.teleNumber);

                    if (validNumber)
                    {
                        addVendor.employees = tbEmployees.Text;
                        bool integer = DataValidator.validateInt(addVendor.employees);
                        if (integer)
                        {
                            addVendor.eYear = dtpVendorEstablished.Text;
                            addVendor.reviewDate = dtpLastReviewDate.Text;
                            addVendor.demoDate = dtpDemoDate.Text;
                            addVendor.intPro = Convert.ToInt32(cbInternalProServices.Checked);
                            addVendor.software = tbSoftwareName.Text;
                            addVendor.softwareType = tbSoftwareType.Text;
                            addVendor.businessArea = tbBusinessArea.Text;
                            addVendor.module = tbModule.Text;
                            addVendor.financialService = tbFinancialServices.Text;
                            addVendor.cloud = cmbCloud.Text;
                            int vendorID = connectDB.addVendor(addVendor.vendor, addVendor.website, addVendor.description, addVendor.additionalInfo, addVendor.employees, addVendor.eYear, addVendor.reviewDate, addVendor.demoDate, addVendor.intPro);
                            connectDB.addContact(addVendor.address, addVendor.teleNumber, vendorID);
                            connectDB.addProduct(addVendor.software, addVendor.softwareType, addVendor.businessArea, addVendor.module, addVendor.financialService, addVendor.cloud, vendorID);
                            MessageBox.Show("The changes made have been successful");

                            foreach (TextBox textbox in this.Controls.OfType<TextBox>())
                            {
                                textbox.Clear();
                            }
                            foreach (RichTextBox richText in this.Controls.OfType<RichTextBox>())
                            {
                                richText.Clear();
                            }
                            foreach (ComboBox cmb in this.Controls.OfType<ComboBox>())
                            {
                                cmb.Controls.Clear();
                            }
                            foreach (CheckBox cb in this.Controls.OfType<CheckBox>())
                            {
                                if (cb.Checked)
                                {
                                    cb.Checked = false;
                                }
                            }

                        }
                        else
                        {
                            MessageBox.Show("An whole number needs to be added to employees");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid phone number");
                    }

                   
                }
                else
                {
                    MessageBox.Show("Please enter a legitimate URL for the Vendor.");
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("The changes made could not be saved to the database");
            }

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}