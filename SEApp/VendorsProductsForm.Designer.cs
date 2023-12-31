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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendorsProductsForm));
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.btnVendorsAndProducts = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnAddOrAdjustVendors = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvVendorProduct = new System.Windows.Forms.DataGridView();
            this.vendorInfoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vendorProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorProducts = new SEApp.VendorProducts();
            this.productInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnRevertData = new System.Windows.Forms.Button();
            this.btnVendor = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.cmbContactInfo = new System.Windows.Forms.ComboBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.btnExportPDF = new System.Windows.Forms.Button();
            this.cmbCompanyAge = new System.Windows.Forms.ComboBox();
            this.lblCompanyAge = new System.Windows.Forms.Label();
            this.productInfoTableAdapter = new SEApp.VendorProductsTableAdapters.ProductInfoTableAdapter();
            this.vendorInfoTableAdapter = new SEApp.VendorProductsTableAdapters.VendorInfoTableAdapter();
            this.btnActiveVendors = new System.Windows.Forms.Button();
            this.btnRatings = new System.Windows.Forms.Button();
            this.cmbCloud = new System.Windows.Forms.ComboBox();
            this.lblCloudServices = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditVendor = new System.Windows.Forms.Button();
            this.tbDisplayedUsername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendorProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInfoBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.BackColor = System.Drawing.SystemColors.Window;
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogout.Location = new System.Drawing.Point(-2, 507);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(196, 50);
            this.btnLogout.TabIndex = 32;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDashBoard.BackColor = System.Drawing.SystemColors.Window;
            this.btnDashBoard.Location = new System.Drawing.Point(-2, 86);
            this.btnDashBoard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(197, 48);
            this.btnDashBoard.TabIndex = 31;
            this.btnDashBoard.Text = "DashBoard";
            this.btnDashBoard.UseVisualStyleBackColor = false;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // btnVendorsAndProducts
            // 
            this.btnVendorsAndProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVendorsAndProducts.BackColor = System.Drawing.SystemColors.Window;
            this.btnVendorsAndProducts.Location = new System.Drawing.Point(-2, 158);
            this.btnVendorsAndProducts.Margin = new System.Windows.Forms.Padding(4);
            this.btnVendorsAndProducts.Name = "btnVendorsAndProducts";
            this.btnVendorsAndProducts.Size = new System.Drawing.Size(196, 50);
            this.btnVendorsAndProducts.TabIndex = 30;
            this.btnVendorsAndProducts.Text = "Vendors and Products";
            this.btnVendorsAndProducts.UseVisualStyleBackColor = false;
            this.btnVendorsAndProducts.Click += new System.EventHandler(this.btnVendorsAndProducts_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSetting.BackColor = System.Drawing.SystemColors.Window;
            this.btnSetting.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetting.Location = new System.Drawing.Point(-2, 400);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(196, 50);
            this.btnSetting.TabIndex = 29;
            this.btnSetting.Text = "Settings";
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnAddOrAdjustVendors
            // 
            this.btnAddOrAdjustVendors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddOrAdjustVendors.BackColor = System.Drawing.SystemColors.Window;
            this.btnAddOrAdjustVendors.Location = new System.Drawing.Point(-2, 214);
            this.btnAddOrAdjustVendors.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddOrAdjustVendors.Name = "btnAddOrAdjustVendors";
            this.btnAddOrAdjustVendors.Size = new System.Drawing.Size(196, 50);
            this.btnAddOrAdjustVendors.TabIndex = 28;
            this.btnAddOrAdjustVendors.Text = "Add Vendors";
            this.btnAddOrAdjustVendors.UseVisualStyleBackColor = false;
            this.btnAddOrAdjustVendors.Click += new System.EventHandler(this.btnAddOrAdjustVendors_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // dgvVendorProduct
            // 
            this.dgvVendorProduct.AllowUserToOrderColumns = true;
            this.dgvVendorProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendorProduct.Location = new System.Drawing.Point(4, 62);
            this.dgvVendorProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvVendorProduct.Name = "dgvVendorProduct";
            this.dgvVendorProduct.RowHeadersWidth = 62;
            this.dgvVendorProduct.RowTemplate.Height = 28;
            this.dgvVendorProduct.Size = new System.Drawing.Size(948, 341);
            this.dgvVendorProduct.TabIndex = 33;
            this.dgvVendorProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVendorProduct_CellContentClick);
            // 
            // vendorInfoBindingSource2
            // 
            this.vendorInfoBindingSource2.DataMember = "VendorInfo";
            this.vendorInfoBindingSource2.DataSource = this.vendorProductsBindingSource;
            // 
            // vendorProductsBindingSource
            // 
            this.vendorProductsBindingSource.DataSource = this.vendorProducts;
            this.vendorProductsBindingSource.Position = 0;
            // 
            // vendorProducts
            // 
            this.vendorProducts.DataSetName = "VendorProducts";
            this.vendorProducts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productInfoBindingSource
            // 
            this.productInfoBindingSource.DataMember = "ProductInfo";
            this.productInfoBindingSource.DataSource = this.vendorProductsBindingSource;
            // 
            // vendorInfoBindingSource
            // 
            this.vendorInfoBindingSource.DataMember = "VendorInfo";
            this.vendorInfoBindingSource.DataSource = this.vendorProductsBindingSource;
            // 
            // vendorInfoBindingSource1
            // 
            this.vendorInfoBindingSource1.DataMember = "VendorInfo";
            this.vendorInfoBindingSource1.DataSource = this.vendorProductsBindingSource;
            // 
            // productInfoBindingSource1
            // 
            this.productInfoBindingSource1.DataMember = "ProductInfo";
            this.productInfoBindingSource1.DataSource = this.vendorProductsBindingSource;
            // 
            // btnRevertData
            // 
            this.btnRevertData.Location = new System.Drawing.Point(4, 407);
            this.btnRevertData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRevertData.Name = "btnRevertData";
            this.btnRevertData.Size = new System.Drawing.Size(122, 28);
            this.btnRevertData.TabIndex = 36;
            this.btnRevertData.Text = "Original";
            this.btnRevertData.UseVisualStyleBackColor = true;
            this.btnRevertData.Click += new System.EventHandler(this.btnRevertData_Click);
            // 
            // btnVendor
            // 
            this.btnVendor.Location = new System.Drawing.Point(131, 407);
            this.btnVendor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVendor.Name = "btnVendor";
            this.btnVendor.Size = new System.Drawing.Size(122, 28);
            this.btnVendor.TabIndex = 37;
            this.btnVendor.Text = "Vendor Data";
            this.btnVendor.UseVisualStyleBackColor = true;
            this.btnVendor.Click += new System.EventHandler(this.btnVendor_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(258, 407);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(121, 27);
            this.btnProduct.TabIndex = 38;
            this.btnProduct.Text = "Product Data";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // cmbContactInfo
            // 
            this.cmbContactInfo.FormattingEnabled = true;
            this.cmbContactInfo.Items.AddRange(new object[] {
            "All",
            "Active",
            "Remove Filter"});
            this.cmbContactInfo.Location = new System.Drawing.Point(407, 32);
            this.cmbContactInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbContactInfo.Name = "cmbContactInfo";
            this.cmbContactInfo.Size = new System.Drawing.Size(134, 24);
            this.cmbContactInfo.TabIndex = 41;
            this.cmbContactInfo.SelectedIndexChanged += new System.EventHandler(this.cmbContactInfo_SelectedIndexChanged);
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(404, 14);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(120, 16);
            this.lblContact.TabIndex = 42;
            this.lblContact.Text = "Contact Information";
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.Location = new System.Drawing.Point(848, 29);
            this.btnExportPDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.Size = new System.Drawing.Size(103, 26);
            this.btnExportPDF.TabIndex = 43;
            this.btnExportPDF.Text = "Export";
            this.btnExportPDF.UseVisualStyleBackColor = true;
            this.btnExportPDF.Click += new System.EventHandler(this.btnExportPDF_Click);
            // 
            // cmbCompanyAge
            // 
            this.cmbCompanyAge.FormattingEnabled = true;
            this.cmbCompanyAge.Items.AddRange(new object[] {
            "<5 Years",
            "<10 Years",
            "Older"});
            this.cmbCompanyAge.Location = new System.Drawing.Point(546, 32);
            this.cmbCompanyAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCompanyAge.Name = "cmbCompanyAge";
            this.cmbCompanyAge.Size = new System.Drawing.Size(134, 24);
            this.cmbCompanyAge.TabIndex = 44;
            this.cmbCompanyAge.SelectedIndexChanged += new System.EventHandler(this.cmbCompanyAge_SelectedIndexChanged);
            // 
            // lblCompanyAge
            // 
            this.lblCompanyAge.AutoSize = true;
            this.lblCompanyAge.Location = new System.Drawing.Point(542, 14);
            this.lblCompanyAge.Name = "lblCompanyAge";
            this.lblCompanyAge.Size = new System.Drawing.Size(93, 16);
            this.lblCompanyAge.TabIndex = 45;
            this.lblCompanyAge.Text = "Company Age";
            // 
            // productInfoTableAdapter
            // 
            this.productInfoTableAdapter.ClearBeforeFill = true;
            // 
            // vendorInfoTableAdapter
            // 
            this.vendorInfoTableAdapter.ClearBeforeFill = true;
            // 
            // btnActiveVendors
            // 
            this.btnActiveVendors.Location = new System.Drawing.Point(4, 29);
            this.btnActiveVendors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActiveVendors.Name = "btnActiveVendors";
            this.btnActiveVendors.Size = new System.Drawing.Size(122, 28);
            this.btnActiveVendors.TabIndex = 34;
            this.btnActiveVendors.Text = "Active Vendors";
            this.btnActiveVendors.UseVisualStyleBackColor = true;
            this.btnActiveVendors.Click += new System.EventHandler(this.btnActiveVendors_Click);
            // 
            // btnRatings
            // 
            this.btnRatings.Location = new System.Drawing.Point(131, 29);
            this.btnRatings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRatings.Name = "btnRatings";
            this.btnRatings.Size = new System.Drawing.Size(137, 28);
            this.btnRatings.TabIndex = 35;
            this.btnRatings.Text = "Software Ratings";
            this.btnRatings.UseVisualStyleBackColor = true;
            this.btnRatings.Click += new System.EventHandler(this.btnRatings_Click);
            // 
            // cmbCloud
            // 
            this.cmbCloud.FormattingEnabled = true;
            this.cmbCloud.Items.AddRange(new object[] {
            "Based",
            "Native",
            "Enabled",
            "None",
            "Remove Filter"});
            this.cmbCloud.Location = new System.Drawing.Point(273, 32);
            this.cmbCloud.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCloud.Name = "cmbCloud";
            this.cmbCloud.Size = new System.Drawing.Size(129, 24);
            this.cmbCloud.TabIndex = 39;
            this.cmbCloud.SelectedIndexChanged += new System.EventHandler(this.cmbCloud_SelectedIndexChanged);
            // 
            // lblCloudServices
            // 
            this.lblCloudServices.AutoSize = true;
            this.lblCloudServices.Location = new System.Drawing.Point(269, 14);
            this.lblCloudServices.Name = "lblCloudServices";
            this.lblCloudServices.Size = new System.Drawing.Size(98, 16);
            this.lblCloudServices.TabIndex = 40;
            this.lblCloudServices.Text = "Cloud Services";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEditVendor);
            this.panel1.Controls.Add(this.lblCompanyAge);
            this.panel1.Controls.Add(this.cmbCompanyAge);
            this.panel1.Controls.Add(this.btnExportPDF);
            this.panel1.Controls.Add(this.lblContact);
            this.panel1.Controls.Add(this.cmbContactInfo);
            this.panel1.Controls.Add(this.lblCloudServices);
            this.panel1.Controls.Add(this.cmbCloud);
            this.panel1.Controls.Add(this.btnProduct);
            this.panel1.Controls.Add(this.btnVendor);
            this.panel1.Controls.Add(this.btnRevertData);
            this.panel1.Controls.Add(this.btnRatings);
            this.panel1.Controls.Add(this.btnActiveVendors);
            this.panel1.Controls.Add(this.dgvVendorProduct);
            this.panel1.Location = new System.Drawing.Point(223, 66);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 442);
            this.panel1.TabIndex = 46;
            // 
            // btnEditVendor
            // 
            this.btnEditVendor.Location = new System.Drawing.Point(426, 404);
            this.btnEditVendor.Name = "btnEditVendor";
            this.btnEditVendor.Size = new System.Drawing.Size(115, 31);
            this.btnEditVendor.TabIndex = 46;
            this.btnEditVendor.Text = "EditVendor";
            this.btnEditVendor.UseVisualStyleBackColor = true;
            this.btnEditVendor.Click += new System.EventHandler(this.btnEditVendor_Click);
            // 
            // tbDisplayedUsername
            // 
            this.tbDisplayedUsername.BackColor = System.Drawing.Color.Snow;
            this.tbDisplayedUsername.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDisplayedUsername.Location = new System.Drawing.Point(1071, -2);
            this.tbDisplayedUsername.Multiline = true;
            this.tbDisplayedUsername.Name = "tbDisplayedUsername";
            this.tbDisplayedUsername.ReadOnly = true;
            this.tbDisplayedUsername.Size = new System.Drawing.Size(188, 37);
            this.tbDisplayedUsername.TabIndex = 47;
            this.tbDisplayedUsername.TabStop = false;
            this.tbDisplayedUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDisplayedUsername.TextChanged += new System.EventHandler(this.tbDisplayedUsername_TextChanged);
            // 
            // VendorsProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 554);
            this.Controls.Add(this.tbDisplayedUsername);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnDashBoard);
            this.Controls.Add(this.btnVendorsAndProducts);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnAddOrAdjustVendors);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1277, 601);
            this.MinimumSize = new System.Drawing.Size(1277, 601);
            this.Name = "VendorsProductsForm";
            this.Text = "VendorsProductsForm";
            this.Load += new System.EventHandler(this.VendorsProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendorProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInfoBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLogout;
        private Button btnDashBoard;
        private Button btnVendorsAndProducts;
        private Button btnSetting;
        private Button btnAddOrAdjustVendors;
        private PictureBox pictureBox1;
        private DataGridView dgvVendorProduct;
        private BindingSource vendorProductsBindingSource;
        private VendorProducts vendorProducts;
        private BindingSource productInfoBindingSource;
        private VendorProductsTableAdapters.ProductInfoTableAdapter productInfoTableAdapter;
        private BindingSource vendorInfoBindingSource;
        private VendorProductsTableAdapters.VendorInfoTableAdapter vendorInfoTableAdapter;
        private BindingSource vendorInfoBindingSource2;
        private BindingSource vendorInfoBindingSource1;
        private BindingSource productInfoBindingSource1;
        private Button btnRevertData;
        private Button btnVendor;
        private Button btnProduct;
        private ComboBox cmbContactInfo;
        private Label lblContact;
        private Button btnExportPDF;
        private ComboBox cmbCompanyAge;
        private Label lblCompanyAge;
        private Button btnActiveVendors;
        private Button btnRatings;
        private ComboBox cmbCloud;
        private Label lblCloudServices;
        private Panel panel1;
        private TextBox tbDisplayedUsername;
        private Button btnEditVendor;
    }
}