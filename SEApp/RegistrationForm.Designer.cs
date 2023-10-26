using System.Drawing;

namespace SEApp
{
    partial class RegistrationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.Username = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.tbLname = new System.Windows.Forms.TextBox();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CompanyRole = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(44, 162);
            this.Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(70, 16);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.cmbRole);
            this.panel1.Controls.Add(this.tbLname);
            this.panel1.Controls.Add(this.tbFname);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.tbPassword);
            this.panel1.Controls.Add(this.tbUsername);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.CompanyRole);
            this.panel1.Controls.Add(this.lastName);
            this.panel1.Controls.Add(this.FirstName);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Location = new System.Drawing.Point(188, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 457);
            this.panel1.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(3, 404);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(199, 42);
            this.btnLogin.TabIndex = 18;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(222, 404);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(203, 42);
            this.btnRegister.TabIndex = 17;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(30, 369);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 30);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbRole
            // 
            this.cmbRole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Financial Advisor",
            "Admin",
            "Owner"});
            this.cmbRole.Location = new System.Drawing.Point(175, 340);
            this.cmbRole.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(219, 24);
            this.cmbRole.TabIndex = 15;
            // 
            // tbLname
            // 
            this.tbLname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLname.Location = new System.Drawing.Point(175, 303);
            this.tbLname.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbLname.Name = "tbLname";
            this.tbLname.Size = new System.Drawing.Size(219, 22);
            this.tbLname.TabIndex = 14;
            // 
            // tbFname
            // 
            this.tbFname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFname.Location = new System.Drawing.Point(175, 267);
            this.tbFname.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(219, 22);
            this.tbFname.TabIndex = 13;
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEmail.Location = new System.Drawing.Point(175, 228);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(219, 22);
            this.tbEmail.TabIndex = 12;
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPassword.Location = new System.Drawing.Point(175, 195);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(219, 22);
            this.tbPassword.TabIndex = 11;
            // 
            // tbUsername
            // 
            this.tbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUsername.Location = new System.Drawing.Point(175, 159);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(219, 22);
            this.tbUsername.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // CompanyRole
            // 
            this.CompanyRole.AutoSize = true;
            this.CompanyRole.Location = new System.Drawing.Point(40, 343);
            this.CompanyRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CompanyRole.Name = "CompanyRole";
            this.CompanyRole.Size = new System.Drawing.Size(97, 16);
            this.CompanyRole.TabIndex = 6;
            this.CompanyRole.Text = "Company Role";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(40, 306);
            this.lastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(72, 16);
            this.lastName.TabIndex = 5;
            this.lastName.Text = "Last Name";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(44, 270);
            this.FirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(75, 16);
            this.FirstName.TabIndex = 3;
            this.FirstName.Text = "First Name ";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(40, 234);
            this.Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(102, 16);
            this.Email.TabIndex = 2;
            this.Email.Text = "Company Email";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(44, 198);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(67, 16);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            // 
            // Registeration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(848, 502);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Registeration_Form";
            this.Text = "RegisterationForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label Username;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label CompanyRole;
        private Label lastName;
        private Label FirstName;
        private Label Email;
        private Label Password;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox tbUsername;
        private TextBox tbLname;
        private TextBox tbFname;
        private TextBox tbEmail;
        private TextBox tbPassword;
        private ComboBox cmbRole;
        private Button btnClear;
        private Button btnRegister;
        private Button btnLogin;
    }
}