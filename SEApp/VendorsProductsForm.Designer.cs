﻿namespace SEApp
{
    partial class VendorsProductsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendorsProductsForm));
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.btnVendorsAndProducts = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnAddOrAdjustVendors = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.BackColor = System.Drawing.SystemColors.Window;
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogout.Location = new System.Drawing.Point(-1, 412);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(147, 40);
            this.btnLogout.TabIndex = 32;
            this.btnLogout.Text = "btn - Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDashBoard.BackColor = System.Drawing.SystemColors.Window;
            this.btnDashBoard.Location = new System.Drawing.Point(-1, 70);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(148, 39);
            this.btnDashBoard.TabIndex = 31;
            this.btnDashBoard.Text = "btn - DashBoard";
            this.btnDashBoard.UseVisualStyleBackColor = false;
            // 
            // btnVendorsAndProducts
            // 
            this.btnVendorsAndProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVendorsAndProducts.BackColor = System.Drawing.SystemColors.Window;
            this.btnVendorsAndProducts.Location = new System.Drawing.Point(-1, 128);
            this.btnVendorsAndProducts.Name = "btnVendorsAndProducts";
            this.btnVendorsAndProducts.Size = new System.Drawing.Size(147, 40);
            this.btnVendorsAndProducts.TabIndex = 30;
            this.btnVendorsAndProducts.Text = "btn - Vendors and Products";
            this.btnVendorsAndProducts.UseVisualStyleBackColor = false;
            // 
            // btnSetting
            // 
            this.btnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSetting.BackColor = System.Drawing.SystemColors.Window;
            this.btnSetting.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetting.Location = new System.Drawing.Point(-1, 325);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(147, 40);
            this.btnSetting.TabIndex = 29;
            this.btnSetting.Text = "btn - Settings";
            this.btnSetting.UseVisualStyleBackColor = false;
            // 
            // btnAddOrAdjustVendors
            // 
            this.btnAddOrAdjustVendors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddOrAdjustVendors.BackColor = System.Drawing.SystemColors.Window;
            this.btnAddOrAdjustVendors.Location = new System.Drawing.Point(-1, 174);
            this.btnAddOrAdjustVendors.Name = "btnAddOrAdjustVendors";
            this.btnAddOrAdjustVendors.Size = new System.Drawing.Size(147, 40);
            this.btnAddOrAdjustVendors.TabIndex = 28;
            this.btnAddOrAdjustVendors.Text = "btn - Add or Adjust Vendors";
            this.btnAddOrAdjustVendors.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // VendorsProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnDashBoard);
            this.Controls.Add(this.btnVendorsAndProducts);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnAddOrAdjustVendors);
            this.Controls.Add(this.pictureBox1);
            this.Name = "VendorsProductsForm";
            this.Text = "VendorsProductsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnLogout;
        private Button btnDashBoard;
        private Button btnVendorsAndProducts;
        private Button btnSetting;
        private Button btnAddOrAdjustVendors;
        private PictureBox pictureBox1;
    }
}