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
            this.forgetPassword = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // eMailLabel
            // 
            this.eMailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eMailLabel.AutoSize = true;
            this.eMailLabel.BackColor = System.Drawing.Color.Transparent;
            this.eMailLabel.Location = new System.Drawing.Point(195, 98);
            this.eMailLabel.Name = "eMailLabel";
            this.eMailLabel.Size = new System.Drawing.Size(45, 16);
            this.eMailLabel.TabIndex = 0;
            this.eMailLabel.Text = "E-Mail";
            this.eMailLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Location = new System.Drawing.Point(195, 129);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(67, 16);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // eMailTextBox
            // 
            this.eMailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eMailTextBox.Location = new System.Drawing.Point(294, 98);
            this.eMailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eMailTextBox.Name = "eMailTextBox";
            this.eMailTextBox.Size = new System.Drawing.Size(175, 22);
            this.eMailTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTextBox.Location = new System.Drawing.Point(294, 129);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(175, 22);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // enteringButton
            // 
            this.enteringButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enteringButton.Location = new System.Drawing.Point(311, 166);
            this.enteringButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enteringButton.Name = "enteringButton";
            this.enteringButton.Size = new System.Drawing.Size(137, 25);
            this.enteringButton.TabIndex = 4;
            this.enteringButton.Text = "Giriş Yap";
            this.enteringButton.UseVisualStyleBackColor = true;
            this.enteringButton.Click += new System.EventHandler(this.enteringButton_Click);
            // 
            // forgetPassword
            // 
            this.forgetPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.forgetPassword.Location = new System.Drawing.Point(311, 195);
            this.forgetPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.forgetPassword.Name = "forgetPassword";
            this.forgetPassword.Size = new System.Drawing.Size(137, 25);
            this.forgetPassword.TabIndex = 5;
            this.forgetPassword.Text = "Şifremi Unuttum";
            this.forgetPassword.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(652, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.forgetPassword);
            this.Controls.Add(this.enteringButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.eMailTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.eMailLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label eMailLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox eMailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button enteringButton;
        private System.Windows.Forms.Button forgetPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}