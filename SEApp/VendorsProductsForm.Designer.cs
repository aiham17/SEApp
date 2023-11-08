namespace SEApp
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
            this.productInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnActiveVendors = new System.Windows.Forms.Button();
            this.btnRatings = new System.Windows.Forms.Button();
            this.btnRevertData = new System.Windows.Forms.Button();
            this.btnVendor = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.cmbCloud = new System.Windows.Forms.ComboBox();
            this.lblCloudServices = new System.Windows.Forms.Label();
            this.vendorProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorProducts = new SEApp.VendorProducts();
            this.productInfoTableAdapter = new SEApp.VendorProductsTableAdapters.ProductInfoTableAdapter();
            this.vendorInfoTableAdapter = new SEApp.VendorProductsTableAdapters.VendorInfoTableAdapter();
            this.cmbContactInfo = new System.Windows.Forms.ComboBox();
            this.lblContact = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendorProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.BackColor = System.Drawing.SystemColors.Window;
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogout.Location = new System.Drawing.Point(-2, 634);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(220, 62);
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
            this.btnDashBoard.Location = new System.Drawing.Point(-2, 108);
            this.btnDashBoard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(222, 60);
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
            this.btnVendorsAndProducts.Location = new System.Drawing.Point(-2, 198);
            this.btnVendorsAndProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVendorsAndProducts.Name = "btnVendorsAndProducts";
            this.btnVendorsAndProducts.Size = new System.Drawing.Size(220, 62);
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
            this.btnSetting.Location = new System.Drawing.Point(-2, 500);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(220, 62);
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
            this.btnAddOrAdjustVendors.Location = new System.Drawing.Point(-2, 268);
            this.btnAddOrAdjustVendors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddOrAdjustVendors.Name = "btnAddOrAdjustVendors";
            this.btnAddOrAdjustVendors.Size = new System.Drawing.Size(220, 62);
            this.btnAddOrAdjustVendors.TabIndex = 28;
            this.btnAddOrAdjustVendors.Text = "Add or Adjust Vendors";
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
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // dgvVendorProduct
            // 
            this.dgvVendorProduct.AllowUserToOrderColumns = true;
            this.dgvVendorProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendorProduct.Location = new System.Drawing.Point(255, 159);
            this.dgvVendorProduct.Name = "dgvVendorProduct";
            this.dgvVendorProduct.RowHeadersWidth = 62;
            this.dgvVendorProduct.RowTemplate.Height = 28;
            this.dgvVendorProduct.Size = new System.Drawing.Size(917, 426);
            this.dgvVendorProduct.TabIndex = 33;
            // 
            // vendorInfoBindingSource2
            // 
            this.vendorInfoBindingSource2.DataMember = "VendorInfo";
            this.vendorInfoBindingSource2.DataSource = this.vendorProductsBindingSource;
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
            // btnActiveVendors
            // 
            this.btnActiveVendors.Location = new System.Drawing.Point(255, 118);
            this.btnActiveVendors.Name = "btnActiveVendors";
            this.btnActiveVendors.Size = new System.Drawing.Size(137, 35);
            this.btnActiveVendors.TabIndex = 34;
            this.btnActiveVendors.Text = "Active Vendors";
            this.btnActiveVendors.UseVisualStyleBackColor = true;
            this.btnActiveVendors.Click += new System.EventHandler(this.btnActiveVendors_Click);
            // 
            // btnRatings
            // 
            this.btnRatings.Location = new System.Drawing.Point(398, 118);
            this.btnRatings.Name = "btnRatings";
            this.btnRatings.Size = new System.Drawing.Size(154, 35);
            this.btnRatings.TabIndex = 35;
            this.btnRatings.Text = "Software Ratings";
            this.btnRatings.UseVisualStyleBackColor = true;
            this.btnRatings.Click += new System.EventHandler(this.btnRatings_Click);
            // 
            // btnRevertData
            // 
            this.btnRevertData.Location = new System.Drawing.Point(255, 591);
            this.btnRevertData.Name = "btnRevertData";
            this.btnRevertData.Size = new System.Drawing.Size(137, 35);
            this.btnRevertData.TabIndex = 36;
            this.btnRevertData.Text = "Original";
            this.btnRevertData.UseVisualStyleBackColor = true;
            this.btnRevertData.Click += new System.EventHandler(this.btnRevertData_Click);
            // 
            // btnVendor
            // 
            this.btnVendor.Location = new System.Drawing.Point(398, 591);
            this.btnVendor.Name = "btnVendor";
            this.btnVendor.Size = new System.Drawing.Size(137, 35);
            this.btnVendor.TabIndex = 37;
            this.btnVendor.Text = "Vendor Data";
            this.btnVendor.UseVisualStyleBackColor = true;
            this.btnVendor.Click += new System.EventHandler(this.btnVendor_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(541, 591);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(136, 34);
            this.btnProduct.TabIndex = 38;
            this.btnProduct.Text = "Product Data";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // cmbCloud
            // 
            this.cmbCloud.FormattingEnabled = true;
            this.cmbCloud.Items.AddRange(new object[] {
            "Based",
            "Native",
            "Enabled",
            "None",
            "Remove"});
            this.cmbCloud.Location = new System.Drawing.Point(558, 122);
            this.cmbCloud.Name = "cmbCloud";
            this.cmbCloud.Size = new System.Drawing.Size(145, 28);
            this.cmbCloud.TabIndex = 39;
            this.cmbCloud.SelectedIndexChanged += new System.EventHandler(this.cmbCloud_SelectedIndexChanged);
            // 
            // lblCloudServices
            // 
            this.lblCloudServices.AutoSize = true;
            this.lblCloudServices.Location = new System.Drawing.Point(563, 99);
            this.lblCloudServices.Name = "lblCloudServices";
            this.lblCloudServices.Size = new System.Drawing.Size(114, 20);
            this.lblCloudServices.TabIndex = 40;
            this.lblCloudServices.Text = "Cloud Services";
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
            // productInfoTableAdapter
            // 
            this.productInfoTableAdapter.ClearBeforeFill = true;
            // 
            // vendorInfoTableAdapter
            // 
            this.vendorInfoTableAdapter.ClearBeforeFill = true;
            // 
            // cmbContactInfo
            // 
            this.cmbContactInfo.FormattingEnabled = true;
            this.cmbContactInfo.Items.AddRange(new object[] {
            "All",
            "Active"});
            this.cmbContactInfo.Location = new System.Drawing.Point(709, 122);
            this.cmbContactInfo.Name = "cmbContactInfo";
            this.cmbContactInfo.Size = new System.Drawing.Size(150, 28);
            this.cmbContactInfo.TabIndex = 41;
            this.cmbContactInfo.SelectedIndexChanged += new System.EventHandler(this.cmbContactInfo_SelectedIndexChanged);
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(709, 96);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(150, 20);
            this.lblContact.TabIndex = 42;
            this.lblContact.Text = "Contact Information";
            // 
            // VendorsProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.cmbContactInfo);
            this.Controls.Add(this.lblCloudServices);
            this.Controls.Add(this.cmbCloud);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnVendor);
            this.Controls.Add(this.btnRevertData);
            this.Controls.Add(this.btnRatings);
            this.Controls.Add(this.btnActiveVendors);
            this.Controls.Add(this.dgvVendorProduct);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnDashBoard);
            this.Controls.Add(this.btnVendorsAndProducts);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnAddOrAdjustVendors);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VendorsProductsForm";
            this.Text = "VendorsProductsForm";
            this.Load += new System.EventHandler(this.VendorsProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendorProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorProducts)).EndInit();
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
        private Button btnActiveVendors;
        private Button btnRatings;
        private Button btnRevertData;
        private Button btnVendor;
        private Button btnProduct;
        private ComboBox cmbCloud;
        private Label lblCloudServices;
        private ComboBox cmbContactInfo;
        private Label lblContact;
    }
}