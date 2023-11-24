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

namespace SEApp
{
    public partial class AddAdjustForm : Form
    {

        // Database conection object
        private Database connectDB;

        

        // Constructor for the AddAdjustForm
        public AddAdjustForm()
        {
            //initilize the database connection
            InitializeComponent();
            connectDB = Database.getConnectString();
        }

        

        //Here, we're calling the ValidateInputs method from the DataValidator class to perform input validation.

        private bool ValidateInputs()
        {
            // We're passing the user-provided data from the input fields as arguments to this method.
            // This includes the username, password, first name, last name, and email entered by the user.

            return DataValidator.ValidateInputs(tbIndex, tbCompanyName.text, tbSoftwareName.text, tbWebsite.text, tbSoftwareType.text, datePickerCompanyEstablished.selectedIndex, tbTelephoneNo.text, tbNoEmployees.text, datePickerReviewDate.selectedIndex, cmbCloud.selectedIndex, tbProductDescription.text, tbAddress.text, tbBusinessArea.text, tbModules.text, tbFSCT.text, tbAdditionalInfo.text);
        }

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
            AddAdjustForm addAdjustForm = new AddAdjustForm();
            addAdjustForm.Show();
            this.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                companyInfo.corpInfo corp = new companyInfo.corpInfo();
                corp.Index = tbIndex.Text;
                corp.CompanyName = tbCompanyName.Text;
                corp.SoftwareName = tbSoftwareName.Text;
                corp.Website = tbWebsite.Text;
                corp.SoftwareType = tbSoftwareType.Text;
                corp.CompanyEstablished = datePickerCompanyEstablished.selectedIndex;
                corp.TelephoneNumber = tbTelephoneNo.Text;
                corp.NumberOfEmployees = tbNoEmployees.Text;
                corp.LastReviewDate = datePickerReviewDate.Text;
                corp.Cloud = cmdCloud.selectedIndex;
                corp.ProductDescription = tbProductDescription.Text;
                corp.Address = tbAddress.Text;
                corp.BusinessArea = tbBusinessArea.Text;
                corp.Modules = tbModules.Text;
                corp.FSCT = tbFSCT.Text;
                corp.AdditionalInfo = tbAdditionalInfo.Text;
                string addCompany = sqlQuery.addCompany;
                connectDB.saveCompanyInfo(addCompany, corp.Index, corp.CompanyName, corp.SoftwareName, corp.Website, corp.SoftwareType, corp.CompanyEstablished, corp.TelephoneNumber, corp.NumberOfEmployees, corp.LastReviewDate, corp.Cloud, corp.ProductDescription, corp.Address, corp.BusinessArea, corp.Modules, corp.FSCT, corp.AdditionalInfo);
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