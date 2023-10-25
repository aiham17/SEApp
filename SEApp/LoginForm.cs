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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = tbUsername.Text;
            string password = tbPassword.Text;

            // Validate inputs
            DataValidator.ValidateInputs(userName, password, "", "", "", 0);
        }



        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void accountCreationLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Create an instance of the login Form
            Registeration_Form registerationForm = new Registeration_Form();

            // Show the Registeration_ Form
            registerationForm.Show();


            // Hide the current form(Login form)
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the text in the input fields
            tbUsername.Text = "";
            tbPassword.Text = "";
   
            // Set focus to the first input field (tbUsername)
            tbUsername.Focus();
        }
    }
}
