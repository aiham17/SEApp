namespace SEApp
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddOrAdjustVendors = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.btnVendorsAndProducts = new System.Windows.Forms.Button();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.chActiveVendors = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chHPVendors = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chActiveVendors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chHPVendors)).BeginInit();
            this.SuspendLayout();
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
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.btnAddOrAdjustVendors.TabIndex = 3;
            this.btnAddOrAdjustVendors.Text = "Add or Adjust Vendors";
            this.btnAddOrAdjustVendors.UseVisualStyleBackColor = false;
            this.btnAddOrAdjustVendors.Click += new System.EventHandler(this.btnAddOrAdjustVendors_Click);
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
            this.btnSetting.TabIndex = 4;
            this.btnSetting.Text = "Settings";
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // button13
            // 
            this.button13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button13.BackColor = System.Drawing.SystemColors.Window;
            this.button13.Location = new System.Drawing.Point(837, 126);
            this.button13.Margin = new System.Windows.Forms.Padding(4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(213, 382);
            this.button13.TabIndex = 14;
            this.button13.Text = "Project Status\n\nShows number of current projects not started, working on and fini" +
    "shed";
            this.button13.UseVisualStyleBackColor = false;
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
            this.btnVendorsAndProducts.TabIndex = 15;
            this.btnVendorsAndProducts.Text = "Vendors and Products";
            this.btnVendorsAndProducts.UseVisualStyleBackColor = false;
            this.btnVendorsAndProducts.Click += new System.EventHandler(this.btnVendorsAndProducts_Click);
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
            this.btnDashBoard.TabIndex = 16;
            this.btnDashBoard.Text = "DashBoard";
            this.btnDashBoard.UseVisualStyleBackColor = false;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
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
            this.btnLogout.TabIndex = 20;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // chActiveVendors
            // 
            chartArea1.Name = "ChartArea1";
            this.chActiveVendors.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chActiveVendors.Legends.Add(legend1);
            this.chActiveVendors.Location = new System.Drawing.Point(530, 42);
            this.chActiveVendors.Name = "chActiveVendors";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chActiveVendors.Series.Add(series1);
            this.chActiveVendors.Size = new System.Drawing.Size(300, 300);
            this.chActiveVendors.TabIndex = 21;
            this.chActiveVendors.Text = "chart1";
            this.chActiveVendors.Click += new System.EventHandler(this.chActiveVendors_Click);
            // 
            // chHPVendors
            // 
            chartArea2.Name = "ChartArea1";
            this.chHPVendors.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chHPVendors.Legends.Add(legend2);
            this.chHPVendors.Location = new System.Drawing.Point(212, 29);
            this.chHPVendors.Name = "chHPVendors";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chHPVendors.Series.Add(series2);
            this.chHPVendors.Size = new System.Drawing.Size(300, 300);
            this.chHPVendors.TabIndex = 22;
            this.chHPVendors.Text = "chart1";
            this.chHPVendors.Click += new System.EventHandler(this.chHPVendors_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.chHPVendors);
            this.Controls.Add(this.chActiveVendors);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnDashBoard);
            this.Controls.Add(this.btnVendorsAndProducts);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnAddOrAdjustVendors);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.Text = "Dashbaord";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chActiveVendors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chHPVendors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnAddOrAdjustVendors;
        private Button btnSetting;
        private Button button13;
        private Button btnVendorsAndProducts;
        private Button btnDashBoard;
        private Button btnLogout;
        private System.Windows.Forms.DataVisualization.Charting.Chart chActiveVendors;
        private System.Windows.Forms.DataVisualization.Charting.Chart chHPVendors;
    }
}