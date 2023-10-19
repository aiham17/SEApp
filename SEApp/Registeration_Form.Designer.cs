namespace SEApp
{
    partial class Registeration_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registeration_Form));
            Username = new Label();
            panel1 = new Panel();
            btnRegister = new Button();
            btnClear = new Button();
            tbRole = new ComboBox();
            Lname = new TextBox();
            tbFname = new TextBox();
            tbEmail = new TextBox();
            tbPassword = new TextBox();
            tbUsername = new TextBox();
            pictureBox1 = new PictureBox();
            CompanyRole = new Label();
            lastName = new Label();
            FirstName = new Label();
            Email = new Label();
            Password = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(55, 252);
            Username.Margin = new Padding(4, 0, 4, 0);
            Username.Name = "Username";
            Username.Size = new Size(91, 25);
            Username.TabIndex = 0;
            Username.Text = "Username";
            Username.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(tbRole);
            panel1.Controls.Add(Lname);
            panel1.Controls.Add(tbFname);
            panel1.Controls.Add(tbEmail);
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(tbUsername);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(CompanyRole);
            panel1.Controls.Add(lastName);
            panel1.Controls.Add(FirstName);
            panel1.Controls.Add(Email);
            panel1.Controls.Add(Password);
            panel1.Controls.Add(Username);
            panel1.Location = new Point(235, 52);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(548, 686);
            panel1.TabIndex = 1;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(285, 610);
            btnRegister.Margin = new Padding(4, 4, 4, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(138, 46);
            btnRegister.TabIndex = 17;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(66, 595);
            btnClear.Margin = new Padding(4, 4, 4, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(138, 45);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // tbRole
            // 
            tbRole.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbRole.FormattingEnabled = true;
            tbRole.Location = new Point(219, 531);
            tbRole.Margin = new Padding(4, 4, 4, 4);
            tbRole.Name = "tbRole";
            tbRole.Size = new Size(284, 33);
            tbRole.TabIndex = 15;
            tbRole.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Lname
            // 
            Lname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Lname.Location = new Point(219, 474);
            Lname.Margin = new Padding(4, 4, 4, 4);
            Lname.Name = "Lname";
            Lname.Size = new Size(284, 31);
            Lname.TabIndex = 14;
            // 
            // tbFname
            // 
            tbFname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbFname.Location = new Point(219, 418);
            tbFname.Margin = new Padding(4, 4, 4, 4);
            tbFname.Name = "tbFname";
            tbFname.Size = new Size(284, 31);
            tbFname.TabIndex = 13;
            // 
            // tbEmail
            // 
            tbEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbEmail.Location = new Point(219, 356);
            tbEmail.Margin = new Padding(4, 4, 4, 4);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(284, 31);
            tbEmail.TabIndex = 12;
            tbEmail.TextChanged += tbEmail_TextChanged;
            // 
            // tbPassword
            // 
            tbPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbPassword.Location = new Point(219, 305);
            tbPassword.Margin = new Padding(4, 4, 4, 4);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(284, 31);
            tbPassword.TabIndex = 11;
            // 
            // tbUsername
            // 
            tbUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbUsername.Location = new Point(219, 249);
            tbUsername.Margin = new Padding(4, 4, 4, 4);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(284, 31);
            tbUsername.TabIndex = 10;
            tbUsername.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(55, 22);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(436, 194);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // CompanyRole
            // 
            CompanyRole.AutoSize = true;
            CompanyRole.Location = new Point(55, 531);
            CompanyRole.Margin = new Padding(4, 0, 4, 0);
            CompanyRole.Name = "CompanyRole";
            CompanyRole.Size = new Size(128, 25);
            CompanyRole.TabIndex = 6;
            CompanyRole.Text = "Comapny Role";
            // 
            // lastName
            // 
            lastName.AutoSize = true;
            lastName.Location = new Point(50, 478);
            lastName.Margin = new Padding(4, 0, 4, 0);
            lastName.Name = "lastName";
            lastName.Size = new Size(95, 25);
            lastName.TabIndex = 5;
            lastName.Text = "Last Name";
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.Location = new Point(55, 421);
            FirstName.Margin = new Padding(4, 0, 4, 0);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(102, 25);
            FirstName.TabIndex = 3;
            FirstName.Text = "First Name ";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(50, 365);
            Email.Margin = new Padding(4, 0, 4, 0);
            Email.Name = "Email";
            Email.Size = new Size(136, 25);
            Email.TabIndex = 2;
            Email.Text = "Company Email";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(55, 309);
            Password.Margin = new Padding(4, 0, 4, 0);
            Password.Name = "Password";
            Password.Size = new Size(87, 25);
            Password.TabIndex = 1;
            Password.Text = "Password";
            Password.Click += label2_Click;
            // 
            // Registeration_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1070, 784);
            Controls.Add(panel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Registeration_Form";
            Text = "RegisterationForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
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
        private TextBox Lname;
        private TextBox tbFname;
        private TextBox tbEmail;
        private TextBox tbPassword;
        private ComboBox tbRole;
        private Button btnClear;
        private Button btnRegister;
    }
}