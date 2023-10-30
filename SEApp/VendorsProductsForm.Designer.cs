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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vendorProducts = new SEApp.VendorProducts();
            this.vendorProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productInfoTableAdapter = new SEApp.VendorProductsTableAdapters.ProductInfoTableAdapter();
            this.vendorInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorInfoTableAdapter = new SEApp.VendorProductsTableAdapters.VendorInfoTableAdapter();
            this.vendorInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vendorInfoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vendorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyWebsiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.establishedYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactTelephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noEmployeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastReviewedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastDemoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internalProServicesDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfoBindingSource2)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vendorIDDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.companyWebsiteDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.establishedYearDataGridViewTextBoxColumn,
            this.contactTelephoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.noEmployeesDataGridViewTextBoxColumn,
            this.lastReviewedDataGridViewTextBoxColumn,
            this.lastDemoDataGridViewTextBoxColumn,
            this.additionalInfoDataGridViewTextBoxColumn,
            this.internalProServicesDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.vendorInfoBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(255, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(917, 426);
            this.dataGridView1.TabIndex = 33;
            // 
            // vendorProducts
            // 
            this.vendorProducts.DataSetName = "VendorProducts";
            this.vendorProducts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendorProductsBindingSource
            // 
            this.vendorProductsBindingSource.DataSource = this.vendorProducts;
            this.vendorProductsBindingSource.Position = 0;
            // 
            // productInfoBindingSource
            // 
            this.productInfoBindingSource.DataMember = "ProductInfo";
            this.productInfoBindingSource.DataSource = this.vendorProductsBindingSource;
            // 
            // productInfoTableAdapter
            // 
            this.productInfoTableAdapter.ClearBeforeFill = true;
            // 
            // vendorInfoBindingSource
            // 
            this.vendorInfoBindingSource.DataMember = "VendorInfo";
            this.vendorInfoBindingSource.DataSource = this.vendorProductsBindingSource;
            // 
            // vendorInfoTableAdapter
            // 
            this.vendorInfoTableAdapter.ClearBeforeFill = true;
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
            // vendorInfoBindingSource2
            // 
            this.vendorInfoBindingSource2.DataMember = "VendorInfo";
            this.vendorInfoBindingSource2.DataSource = this.vendorProductsBindingSource;
            // 
            // vendorIDDataGridViewTextBoxColumn
            // 
            this.vendorIDDataGridViewTextBoxColumn.DataPropertyName = "VendorID";
            this.vendorIDDataGridViewTextBoxColumn.HeaderText = "VendorID";
            this.vendorIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vendorIDDataGridViewTextBoxColumn.Name = "vendorIDDataGridViewTextBoxColumn";
            this.vendorIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.vendorIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "Company_Name";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "Company_Name";
            this.companyNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            this.companyNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // companyWebsiteDataGridViewTextBoxColumn
            // 
            this.companyWebsiteDataGridViewTextBoxColumn.DataPropertyName = "Company_Website";
            this.companyWebsiteDataGridViewTextBoxColumn.HeaderText = "Company_Website";
            this.companyWebsiteDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.companyWebsiteDataGridViewTextBoxColumn.Name = "companyWebsiteDataGridViewTextBoxColumn";
            this.companyWebsiteDataGridViewTextBoxColumn.Width = 150;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // establishedYearDataGridViewTextBoxColumn
            // 
            this.establishedYearDataGridViewTextBoxColumn.DataPropertyName = "Established_Year";
            this.establishedYearDataGridViewTextBoxColumn.HeaderText = "Established_Year";
            this.establishedYearDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.establishedYearDataGridViewTextBoxColumn.Name = "establishedYearDataGridViewTextBoxColumn";
            this.establishedYearDataGridViewTextBoxColumn.Width = 150;
            // 
            // contactTelephoneDataGridViewTextBoxColumn
            // 
            this.contactTelephoneDataGridViewTextBoxColumn.DataPropertyName = "Contact_Telephone";
            this.contactTelephoneDataGridViewTextBoxColumn.HeaderText = "Contact_Telephone";
            this.contactTelephoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.contactTelephoneDataGridViewTextBoxColumn.Name = "contactTelephoneDataGridViewTextBoxColumn";
            this.contactTelephoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 150;
            // 
            // noEmployeesDataGridViewTextBoxColumn
            // 
            this.noEmployeesDataGridViewTextBoxColumn.DataPropertyName = "No_Employees";
            this.noEmployeesDataGridViewTextBoxColumn.HeaderText = "No_Employees";
            this.noEmployeesDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.noEmployeesDataGridViewTextBoxColumn.Name = "noEmployeesDataGridViewTextBoxColumn";
            this.noEmployeesDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastReviewedDataGridViewTextBoxColumn
            // 
            this.lastReviewedDataGridViewTextBoxColumn.DataPropertyName = "Last_Reviewed";
            this.lastReviewedDataGridViewTextBoxColumn.HeaderText = "Last_Reviewed";
            this.lastReviewedDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lastReviewedDataGridViewTextBoxColumn.Name = "lastReviewedDataGridViewTextBoxColumn";
            this.lastReviewedDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastDemoDataGridViewTextBoxColumn
            // 
            this.lastDemoDataGridViewTextBoxColumn.DataPropertyName = "Last_Demo";
            this.lastDemoDataGridViewTextBoxColumn.HeaderText = "Last_Demo";
            this.lastDemoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lastDemoDataGridViewTextBoxColumn.Name = "lastDemoDataGridViewTextBoxColumn";
            this.lastDemoDataGridViewTextBoxColumn.Width = 150;
            // 
            // additionalInfoDataGridViewTextBoxColumn
            // 
            this.additionalInfoDataGridViewTextBoxColumn.DataPropertyName = "Additional_Info";
            this.additionalInfoDataGridViewTextBoxColumn.HeaderText = "Additional_Info";
            this.additionalInfoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.additionalInfoDataGridViewTextBoxColumn.Name = "additionalInfoDataGridViewTextBoxColumn";
            this.additionalInfoDataGridViewTextBoxColumn.Width = 150;
            // 
            // internalProServicesDataGridViewCheckBoxColumn
            // 
            this.internalProServicesDataGridViewCheckBoxColumn.DataPropertyName = "Internal_Pro_Services";
            this.internalProServicesDataGridViewCheckBoxColumn.HeaderText = "Internal_Pro_Services";
            this.internalProServicesDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.internalProServicesDataGridViewCheckBoxColumn.Name = "internalProServicesDataGridViewCheckBoxColumn";
            this.internalProServicesDataGridViewCheckBoxColumn.Width = 150;
            // 
            // VendorsProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfoBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnLogout;
        private Button btnDashBoard;
        private Button btnVendorsAndProducts;
        private Button btnSetting;
        private Button btnAddOrAdjustVendors;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private BindingSource vendorProductsBindingSource;
        private VendorProducts vendorProducts;
        private BindingSource productInfoBindingSource;
        private VendorProductsTableAdapters.ProductInfoTableAdapter productInfoTableAdapter;
        private BindingSource vendorInfoBindingSource;
        private VendorProductsTableAdapters.VendorInfoTableAdapter vendorInfoTableAdapter;
        private DataGridViewTextBoxColumn vendorIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn companyWebsiteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn establishedYearDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactTelephoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn noEmployeesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastReviewedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastDemoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn additionalInfoDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn internalProServicesDataGridViewCheckBoxColumn;
        private BindingSource vendorInfoBindingSource2;
        private BindingSource vendorInfoBindingSource1;
        private BindingSource productInfoBindingSource1;
    }
}