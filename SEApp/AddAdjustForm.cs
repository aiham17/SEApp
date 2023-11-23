using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            return DataValidator.ValidateInputs(tbCname.text, tbSname.text, tbWebsite.text, tbStype.text, datetimepicker2.selectedIndex, tbTelephoneno.text, tbNoemployees.text, dateTimePicker1.selectedIndex, cmbRole.selectedIndex, tbdescription.text, tbAddress.text, tbBarea.text, tbModules.text, tbFSCT.text, tbAdditionalinfo.text);

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
