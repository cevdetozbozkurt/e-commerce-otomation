namespace e_commere
{
    partial class hesapSilme
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
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.memberName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.memberPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.memberMail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(154, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Dikkat hesabınız silindikten sonra geri kurtarılamaz.";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(223, 274);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(195, 44);
            this.button5.TabIndex = 40;
            this.button5.Text = "Hesabımı sil";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // memberName
            // 
            this.memberName.Location = new System.Drawing.Point(223, 98);
            this.memberName.Margin = new System.Windows.Forms.Padding(4);
            this.memberName.Name = "memberName";
            this.memberName.Size = new System.Drawing.Size(132, 22);
            this.memberName.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Kullanıcı adı ;";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Kullanıcı email ;";
            // 
            // memberPass
            // 
            this.memberPass.Location = new System.Drawing.Point(223, 198);
            this.memberPass.Margin = new System.Windows.Forms.Padding(4);
            this.memberPass.Name = "memberPass";
            this.memberPass.Size = new System.Drawing.Size(132, 22);
            this.memberPass.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 204);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Kullanıcı Şifre ;";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // memberMail
            // 
            this.memberMail.Location = new System.Drawing.Point(223, 144);
            this.memberMail.Margin = new System.Windows.Forms.Padding(4);
            this.memberMail.Name = "memberMail";
            this.memberMail.Size = new System.Drawing.Size(132, 22);
            this.memberMail.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(49, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 29);
            this.label8.TabIndex = 29;
            this.label8.Text = "HESAP SİLME";
            // 
            // hesapSilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(675, 400);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.memberName);
            this.Controls.Add(this.memberMail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.memberPass);
            this.Name = "hesapSilme";
            this.Text = "Hesap Silme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox memberName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox memberPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox memberMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
    }
}