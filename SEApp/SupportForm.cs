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
    public partial class SupportForm : Form
    {
        // Database connection object
        private Database connectDB;

        public SupportForm()
        {
            InitializeComponent();
            connectDB = Database.getConnectString();
        }

        private void lblCitisoftUSA_Click(object sender, EventArgs e)
        {

        }

        private void SupportForm_Load(object sender, EventArgs e)
        {
            


            // Populate labels with contact details
            lblCitisoftUSA.Text = "Citisoft USA\n303 Congress Street, 5th floor\nBoston, MA 02210\nUSA\n\nT +1 617 428 9580\nF +1 617 428 9588\nEmail: USA.contact@citisoft.com";
            lblCitisoftUSA.Font = new Font("Arial", 11, FontStyle.Bold); // Make the text bold

            lblCitisoftEMEA.Text = "Citisoft EMEA\n1 Gresham Street\nLondon\nEC2V 7BX\nUK\n\nEmail: emea.contact@citisoft.com";
            lblCitisoftEMEA.Font = new Font("Arial", 11, FontStyle.Bold); // Make the text bold

            lblCitisoftCanada.Text = "Citisoft Canada\n1 University Avenue, Unit 300\nToronto, ON M5J 2P1\nCanada\n\nT +1 416 686 1619\nF +1 617 428 9588\nEmail: canada.contact@citisoft.com";
            lblCitisoftCanada.Font = new Font("Arial", 11, FontStyle.Bold); // Make the text bold

          
        }

        private void lblCitisoftCanada_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Get user inputs from text boxes
            string name = tbName.Text;
            string email = tbEmail.Text;
            string topic = tbTopic.Text;
            string message = tbMessage.Text;

            // Validate user inputs
            
           
                   // Save the support ticket to the database

                    connectDB.SaveSupportTicket(name, email, topic, message);

                    // Display success message
                    MessageBox.Show("Support ticket submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear text boxes
                    ClearTextFields();
                
            
        }

        private void ClearTextFields()
        {
            // Clear text boxes
            tbName.Text = "";
            tbEmail.Text = "";
            tbTopic.Text = "";
            tbMessage.Text = "";
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMessage_TextChanged(object sender, EventArgs e)
        {

        }
        private void tbTopic_TextChanged(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

            // Create an instance of the Dashboard Form
            Dashboard dashboard = new Dashboard();

            // Show the Dashboard form
            dashboard.Show();

            // Close the current form (Support form)
            this.Hide();
        }

        
    }
}
