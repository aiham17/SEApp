﻿using System;
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
    public partial class LoginSecurity : Form
    {
        public LoginSecurity()
        {
            InitializeComponent();
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
    }
}