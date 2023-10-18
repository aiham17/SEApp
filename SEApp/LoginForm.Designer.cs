namespace SEApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            Password = new Label();
            Username = new Label();
            btnClear = new Button();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(Password);
            panel1.Controls.Add(Username);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(197, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(391, 498);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(82, 455);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(231, 20);
            linkLabel2.TabIndex = 9;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Don't have an account Click here?";
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(167, 355);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(146, 20);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgotten Password?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 0, 64);
            label3.Location = new Point(112, 181);
            label3.Name = "label3";
            label3.Size = new Size(167, 31);
            label3.TabIndex = 7;
            label3.Text = "Welcome User!";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(134, 316);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(226, 36);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(134, 244);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 36);
            textBox1.TabIndex = 5;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(35, 320);
            Password.Name = "Password";
            Password.Size = new Size(70, 20);
            Password.TabIndex = 4;
            Password.Text = "Password";
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(35, 247);
            Username.Name = "Username";
            Username.Size = new Size(75, 20);
            Username.TabIndex = 3;
            Username.Text = "Username";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(45, 405);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(119, 41);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(219, 405);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(117, 41);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(326, 145);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(789, 566);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label Password;
        private Label Username;
        private Button btnClear;
        private Button btnLogin;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
    }
}