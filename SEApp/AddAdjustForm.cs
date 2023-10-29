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
    public partial class AddAdjustForm : Form
    {

        // Create an instance of the LoginForm
        LoginForm loginForm = new LoginForm();

        // Create an instance of the SettingsForm
        SettingsForm settingsForm = new SettingsForm();

        // Create an instance of the AddAdjustForm
        AddAdjustForm addAdjustForm = new AddAdjustForm();

        // Create an instance of the VendorsProductsForm
        VendorsProductsForm vendorsProductsForm = new VendorsProductsForm();

        // Create an instance of the Dashboard Form
        Dashboard dashboard = new Dashboard();

        public AddAdjustForm()
        {
            InitializeComponent();
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
            dashboard.Show();
            this.Close();
        }

        private void btnVendorsAndProducts_Click(object sender, EventArgs e)
        {
            vendorsProductsForm.Show();
            this.Close();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            settingsForm.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Close();

        }

        private void btnAddOrAdjustVendors_Click(object sender, EventArgs e)
        {
            addAdjustForm.Show();

            this.Close();
        }
    }
}
