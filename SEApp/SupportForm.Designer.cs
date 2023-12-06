namespace SEApp
{
    partial class SupportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupportForm));
            this.lblCitisoftUSA = new System.Windows.Forms.Label();
            this.lblCitisoftEMEA = new System.Windows.Forms.Label();
            this.lblCitisoftCanada = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Topic = new System.Windows.Forms.Label();
            this.tbTopic = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCitisoftUSA
            // 
            this.lblCitisoftUSA.AutoSize = true;
            this.lblCitisoftUSA.BackColor = System.Drawing.Color.White;
            this.lblCitisoftUSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCitisoftUSA.Location = new System.Drawing.Point(41, 141);
            this.lblCitisoftUSA.Name = "lblCitisoftUSA";
            this.lblCitisoftUSA.Size = new System.Drawing.Size(171, 32);
            this.lblCitisoftUSA.TabIndex = 0;
            this.lblCitisoftUSA.Text = "CitisoftUSA";
            this.lblCitisoftUSA.Click += new System.EventHandler(this.lblCitisoftUSA_Click);
            // 
            // lblCitisoftEMEA
            // 
            this.lblCitisoftEMEA.AutoSize = true;
            this.lblCitisoftEMEA.BackColor = System.Drawing.Color.White;
            this.lblCitisoftEMEA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCitisoftEMEA.Location = new System.Drawing.Point(41, 345);
            this.lblCitisoftEMEA.Name = "lblCitisoftEMEA";
            this.lblCitisoftEMEA.Size = new System.Drawing.Size(194, 32);
            this.lblCitisoftEMEA.TabIndex = 1;
            this.lblCitisoftEMEA.Text = "CitisoftEMEA";
            // 
            // lblCitisoftCanada
            // 
            this.lblCitisoftCanada.AutoSize = true;
            this.lblCitisoftCanada.BackColor = System.Drawing.Color.White;
            this.lblCitisoftCanada.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCitisoftCanada.Location = new System.Drawing.Point(41, 533);
            this.lblCitisoftCanada.Name = "lblCitisoftCanada";
            this.lblCitisoftCanada.Size = new System.Drawing.Size(216, 32);
            this.lblCitisoftCanada.TabIndex = 2;
            this.lblCitisoftCanada.Text = "CitisoftCanada";
            this.lblCitisoftCanada.Click += new System.EventHandler(this.lblCitisoftCanada_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Topic);
            this.panel1.Controls.Add(this.tbTopic);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbMessage);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Location = new System.Drawing.Point(541, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 548);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Topic
            // 
            this.Topic.AutoSize = true;
            this.Topic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Topic.Location = new System.Drawing.Point(53, 332);
            this.Topic.Name = "Topic";
            this.Topic.Size = new System.Drawing.Size(55, 20);
            this.Topic.TabIndex = 9;
            this.Topic.Text = "Topic";
            // 
            // tbTopic
            // 
            this.tbTopic.Location = new System.Drawing.Point(175, 309);
            this.tbTopic.Multiline = true;
            this.tbTopic.Name = "tbTopic";
            this.tbTopic.Size = new System.Drawing.Size(275, 43);
            this.tbTopic.TabIndex = 8;
            this.tbTopic.TextChanged += new System.EventHandler(this.tbTopic_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(117, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Send Us Message";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Snow;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(200, 496);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(203, 39);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(175, 388);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(275, 90);
            this.tbMessage.TabIndex = 2;
            this.tbMessage.TextChanged += new System.EventHandler(this.tbMessage_TextChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(175, 234);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(275, 43);
            this.tbEmail.TabIndex = 1;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(175, 155);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(275, 43);
            this.tbName.TabIndex = 0;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-6, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(476, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Please contact any of our locations below";
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Snow;
            this.btnDashboard.Location = new System.Drawing.Point(-1, -4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(189, 58);
            this.btnDashboard.TabIndex = 5;
            this.btnDashboard.Text = "Back";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // SupportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1035, 718);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCitisoftCanada);
            this.Controls.Add(this.lblCitisoftEMEA);
            this.Controls.Add(this.lblCitisoftUSA);
            this.MaximumSize = new System.Drawing.Size(1053, 765);
            this.MinimumSize = new System.Drawing.Size(1053, 765);
            this.Name = "SupportForm";
            this.Text = "SupportForm";
            this.Load += new System.EventHandler(this.SupportForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCitisoftUSA;
        private Label lblCitisoftEMEA;
        private Label lblCitisoftCanada;
        private Panel panel1;
        private TextBox tbMessage;
        private TextBox tbEmail;
        private TextBox tbName;
        private Button btnSubmit;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private Button btnDashboard;
        private TextBox tbTopic;
        private Label Topic;
    }
}