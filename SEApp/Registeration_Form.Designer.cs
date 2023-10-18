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
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(70, 218);
            Username.Name = "Username";
            Username.Size = new Size(75, 20);
            Username.TabIndex = 0;
            Username.Text = "Username";
            Username.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
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
            panel1.Location = new Point(188, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(438, 549);
            panel1.TabIndex = 1;
            // 
            // tbRole
            // 
            tbRole.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbRole.FormattingEnabled = true;
            tbRole.Location = new Point(201, 441);
            tbRole.Name = "tbRole";
            tbRole.Size = new Size(173, 28);
            tbRole.TabIndex = 15;
            tbRole.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Lname
            // 
            Lname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Lname.Location = new Point(201, 395);
            Lname.Name = "Lname";
            Lname.Size = new Size(173, 27);
            Lname.TabIndex = 14;
            // 
            // tbFname
            // 
            tbFname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbFname.Location = new Point(201, 350);
            tbFname.Name = "tbFname";
            tbFname.Size = new Size(173, 27);
            tbFname.TabIndex = 13;
            // 
            // tbEmail
            // 
            tbEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbEmail.Location = new Point(201, 301);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(173, 27);
            tbEmail.TabIndex = 12;
            // 
            // tbPassword
            // 
            tbPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbPassword.Location = new Point(201, 260);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(173, 27);
            tbPassword.TabIndex = 11;
            // 
            // tbUsername
            // 
            tbUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbUsername.Location = new Point(201, 215);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(173, 27);
            tbUsername.TabIndex = 10;
            tbUsername.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(349, 155);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // CompanyRole
            // 
            CompanyRole.AutoSize = true;
            CompanyRole.Location = new Point(70, 441);
            CompanyRole.Name = "CompanyRole";
            CompanyRole.Size = new Size(106, 20);
            CompanyRole.TabIndex = 6;
            CompanyRole.Text = "Comapny Role";
            // 
            // lastName
            // 
            lastName.AutoSize = true;
            lastName.Location = new Point(66, 398);
            lastName.Name = "lastName";
            lastName.Size = new Size(79, 20);
            lastName.TabIndex = 5;
            lastName.Text = "Last Name";
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.Location = new Point(70, 353);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(84, 20);
            FirstName.TabIndex = 3;
            FirstName.Text = "First Name ";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(66, 308);
            Email.Name = "Email";
            Email.Size = new Size(113, 20);
            Email.TabIndex = 2;
            Email.Text = "Company Email";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(70, 263);
            Password.Name = "Password";
            Password.Size = new Size(70, 20);
            Password.TabIndex = 1;
            Password.Text = "Password";
            Password.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(85, 496);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 16;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Registeration_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 683);
            Controls.Add(panel1);
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
        private Button button1;
    }
}