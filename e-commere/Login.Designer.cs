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
            this.eMailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.eMailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.enteringButton = new System.Windows.Forms.Button();
            this.forgetPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eMailLabel
            // 
            this.eMailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eMailLabel.AutoSize = true;
            this.eMailLabel.Location = new System.Drawing.Point(219, 123);
            this.eMailLabel.Name = "eMailLabel";
            this.eMailLabel.Size = new System.Drawing.Size(53, 20);
            this.eMailLabel.TabIndex = 0;
            this.eMailLabel.Text = "E-Mail";
            this.eMailLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(219, 161);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(78, 20);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // eMailTextBox
            // 
            this.eMailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eMailTextBox.Location = new System.Drawing.Point(331, 123);
            this.eMailTextBox.Name = "eMailTextBox";
            this.eMailTextBox.Size = new System.Drawing.Size(196, 26);
            this.eMailTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTextBox.Location = new System.Drawing.Point(331, 161);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(196, 26);
            this.passwordTextBox.TabIndex = 3;
            // 
            // enteringButton
            // 
            this.enteringButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enteringButton.Location = new System.Drawing.Point(350, 207);
            this.enteringButton.Name = "enteringButton";
            this.enteringButton.Size = new System.Drawing.Size(154, 31);
            this.enteringButton.TabIndex = 4;
            this.enteringButton.Text = "Giriş Yap";
            this.enteringButton.UseVisualStyleBackColor = true;
            // 
            // forgetPassword
            // 
            this.forgetPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.forgetPassword.Location = new System.Drawing.Point(350, 244);
            this.forgetPassword.Name = "forgetPassword";
            this.forgetPassword.Size = new System.Drawing.Size(154, 31);
            this.forgetPassword.TabIndex = 5;
            this.forgetPassword.Text = "Şifremi Unuttum";
            this.forgetPassword.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.forgetPassword);
            this.Controls.Add(this.enteringButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.eMailTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.eMailLabel);
            this.Name = "Login";
            this.Text = "Giriş";
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
    }
}