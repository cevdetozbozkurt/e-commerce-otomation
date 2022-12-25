namespace e_commere
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.eMailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.eMailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.enteringButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // eMailLabel
            // 
            this.eMailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eMailLabel.AutoSize = true;
            this.eMailLabel.BackColor = System.Drawing.Color.Transparent;
            this.eMailLabel.Location = new System.Drawing.Point(52, 104);
            this.eMailLabel.Name = "eMailLabel";
            this.eMailLabel.Size = new System.Drawing.Size(51, 16);
            this.eMailLabel.TabIndex = 0;
            this.eMailLabel.Text = "E-Mail :";
            this.eMailLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Location = new System.Drawing.Point(30, 144);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(73, 16);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password :";
            this.passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // eMailTextBox
            // 
            this.eMailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eMailTextBox.ForeColor = System.Drawing.Color.Silver;
            this.eMailTextBox.Location = new System.Drawing.Point(118, 101);
            this.eMailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eMailTextBox.Name = "eMailTextBox";
            this.eMailTextBox.Size = new System.Drawing.Size(175, 22);
            this.eMailTextBox.TabIndex = 2;
            this.eMailTextBox.Text = "email veya telefon giriniz";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTextBox.ForeColor = System.Drawing.Color.Silver;
            this.passwordTextBox.Location = new System.Drawing.Point(118, 138);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(175, 22);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.Text = "***********";
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // enteringButton
            // 
            this.enteringButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enteringButton.Location = new System.Drawing.Point(118, 213);
            this.enteringButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enteringButton.Name = "enteringButton";
            this.enteringButton.Size = new System.Drawing.Size(137, 25);
            this.enteringButton.TabIndex = 4;
            this.enteringButton.Text = "Giriş Yap";
            this.enteringButton.UseVisualStyleBackColor = true;
            this.enteringButton.Click += new System.EventHandler(this.enteringButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(997, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.eMailLabel);
            this.panel1.Controls.Add(this.eMailTextBox);
            this.panel1.Controls.Add(this.passwordLabel);
            this.panel1.Controls.Add(this.enteringButton);
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Location = new System.Drawing.Point(374, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 309);
            this.panel1.TabIndex = 7;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Location = new System.Drawing.Point(158, 256);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(87, 16);
            this.linkLabel2.TabIndex = 20;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Hesabım yok";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(207, 174);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(96, 16);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şifremi unuttum";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(125, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 27);
            this.label8.TabIndex = 18;
            this.label8.Text = "GİRİŞ YAP";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(109, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 95);
            this.label1.TabIndex = 61;
            this.label1.Text = "DROPİT   ";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1056, 670);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label eMailLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox eMailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button enteringButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}