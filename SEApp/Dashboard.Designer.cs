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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddOrAdjustVendors = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnVendorsAndProducts = new System.Windows.Forms.Button();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.chActiveVendors = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chHPVendors = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chLPVendors = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chHighestProduct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chLowestProduct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbDisplayedUsername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chActiveVendors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chHPVendors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chLPVendors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chHighestProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chLowestProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -2);
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
            this.btnAddOrAdjustVendors.BackColor = System.Drawing.SystemColors.Window;
            this.btnAddOrAdjustVendors.Location = new System.Drawing.Point(1, 321);
            this.btnAddOrAdjustVendors.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddOrAdjustVendors.Name = "btnAddOrAdjustVendors";
            this.btnAddOrAdjustVendors.Size = new System.Drawing.Size(195, 66);
            this.btnAddOrAdjustVendors.TabIndex = 3;
            this.btnAddOrAdjustVendors.Text = "Add Vendors";
            this.btnAddOrAdjustVendors.UseVisualStyleBackColor = false;
            this.btnAddOrAdjustVendors.Click += new System.EventHandler(this.btnAddOrAdjustVendors_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.SystemColors.Window;
            this.btnSetting.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetting.Location = new System.Drawing.Point(-2, 468);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(195, 66);
            this.btnSetting.TabIndex = 4;
            this.btnSetting.Text = "Settings";
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnVendorsAndProducts
            // 
            this.btnVendorsAndProducts.BackColor = System.Drawing.SystemColors.Window;
            this.btnVendorsAndProducts.Location = new System.Drawing.Point(-2, 226);
            this.btnVendorsAndProducts.Margin = new System.Windows.Forms.Padding(4);
            this.btnVendorsAndProducts.Name = "btnVendorsAndProducts";
            this.btnVendorsAndProducts.Size = new System.Drawing.Size(195, 66);
            this.btnVendorsAndProducts.TabIndex = 15;
            this.btnVendorsAndProducts.Text = "Vendors and Products";
            this.btnVendorsAndProducts.UseVisualStyleBackColor = false;
            this.btnVendorsAndProducts.Click += new System.EventHandler(this.btnVendorsAndProducts_Click);
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.BackColor = System.Drawing.SystemColors.Window;
            this.btnDashBoard.Location = new System.Drawing.Point(-3, 108);
            this.btnDashBoard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(196, 64);
            this.btnDashBoard.TabIndex = 16;
            this.btnDashBoard.Text = "DashBoard";
            this.btnDashBoard.UseVisualStyleBackColor = false;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Window;
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogout.Location = new System.Drawing.Point(-2, 575);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(195, 66);
            this.btnLogout.TabIndex = 20;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // chActiveVendors
            // 
            this.chActiveVendors.BackColor = System.Drawing.Color.LightSlateGray;
            chartArea1.Name = "ChartArea1";
            this.chActiveVendors.ChartAreas.Add(chartArea1);
            this.chActiveVendors.Enabled = false;
            legend1.Name = "Legend1";
            this.chActiveVendors.Legends.Add(legend1);
            this.chActiveVendors.Location = new System.Drawing.Point(978, 71);
            this.chActiveVendors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chActiveVendors.Name = "chActiveVendors";
            this.chActiveVendors.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chActiveVendors.Series.Add(series1);
            this.chActiveVendors.Size = new System.Drawing.Size(411, 352);
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
            this.chHPVendors.Location = new System.Drawing.Point(203, 432);
            this.chHPVendors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chHPVendors.Name = "chHPVendors";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chHPVendors.Series.Add(series2);
            this.chHPVendors.Size = new System.Drawing.Size(572, 300);
            this.chHPVendors.TabIndex = 22;
            this.chHPVendors.Text = "chart1";
            this.chHPVendors.Click += new System.EventHandler(this.chHPVendors_Click);
            // 
            // chLPVendors
            // 
            chartArea3.Name = "ChartArea1";
            this.chLPVendors.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chLPVendors.Legends.Add(legend3);
            this.chLPVendors.Location = new System.Drawing.Point(641, 71);
            this.chLPVendors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chLPVendors.Name = "chLPVendors";
            this.chLPVendors.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chLPVendors.Series.Add(series3);
            this.chLPVendors.Size = new System.Drawing.Size(331, 352);
            this.chLPVendors.TabIndex = 23;
            this.chLPVendors.Text = "chart1";
            this.chLPVendors.Click += new System.EventHandler(this.chLPVendors_Click);
            // 
            // chHighestProduct
            // 
            chartArea4.Name = "ChartArea1";
            this.chHighestProduct.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chHighestProduct.Legends.Add(legend4);
            this.chHighestProduct.Location = new System.Drawing.Point(809, 432);
            this.chHighestProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chHighestProduct.Name = "chHighestProduct";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chHighestProduct.Series.Add(series4);
            this.chHighestProduct.Size = new System.Drawing.Size(580, 300);
            this.chHighestProduct.TabIndex = 24;
            this.chHighestProduct.Text = "chart1";
            this.chHighestProduct.Click += new System.EventHandler(this.chHighestProduct_Click);
            // 
            // chLowestProduct
            // 
            this.chLowestProduct.BackColor = System.Drawing.Color.Silver;
            chartArea5.Name = "ChartArea1";
            this.chLowestProduct.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chLowestProduct.Legends.Add(legend5);
            this.chLowestProduct.Location = new System.Drawing.Point(203, 71);
            this.chLowestProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chLowestProduct.Name = "chLowestProduct";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chLowestProduct.Series.Add(series5);
            this.chLowestProduct.Size = new System.Drawing.Size(418, 352);
            this.chLowestProduct.TabIndex = 25;
            this.chLowestProduct.Text = "chart1";
            this.chLowestProduct.Click += new System.EventHandler(this.chLowestProduct_Click);
            // 
            // tbDisplayedUsername
            // 
            this.tbDisplayedUsername.BackColor = System.Drawing.Color.Snow;
            this.tbDisplayedUsername.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDisplayedUsername.Location = new System.Drawing.Point(1213, -2);
            this.tbDisplayedUsername.Multiline = true;
            this.tbDisplayedUsername.Name = "tbDisplayedUsername";
            this.tbDisplayedUsername.ReadOnly = true;
            this.tbDisplayedUsername.Size = new System.Drawing.Size(207, 45);
            this.tbDisplayedUsername.TabIndex = 26;
            this.tbDisplayedUsername.TabStop = false;
            this.tbDisplayedUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDisplayedUsername.TextChanged += new System.EventHandler(this.tbDisplayedUsername_TextChanged);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1420, 734);
            this.Controls.Add(this.tbDisplayedUsername);
            this.Controls.Add(this.chLowestProduct);
            this.Controls.Add(this.chHighestProduct);
            this.Controls.Add(this.chLPVendors);
            this.Controls.Add(this.chHPVendors);
            this.Controls.Add(this.chActiveVendors);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnDashBoard);
            this.Controls.Add(this.btnVendorsAndProducts);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnAddOrAdjustVendors);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1438, 781);
            this.MinimumSize = new System.Drawing.Size(1438, 781);
            this.Name = "Dashboard";
            this.Text = "Dashbaord";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chActiveVendors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chHPVendors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chLPVendors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chHighestProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chLowestProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnAddOrAdjustVendors;
        private Button btnSetting;
        private Button btnVendorsAndProducts;
        private Button btnDashBoard;
        private Button btnLogout;
        private System.Windows.Forms.DataVisualization.Charting.Chart chActiveVendors;
        private System.Windows.Forms.DataVisualization.Charting.Chart chHPVendors;
        private System.Windows.Forms.DataVisualization.Charting.Chart chLPVendors;
        private System.Windows.Forms.DataVisualization.Charting.Chart chHighestProduct;
        private System.Windows.Forms.DataVisualization.Charting.Chart chLowestProduct;
        private TextBox tbDisplayedUsername;
    }
}