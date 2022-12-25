namespace e_commere
{
    partial class sifreleriYonet
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
            this.button5 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.memberName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.memberMail = new System.Windows.Forms.TextBox();
            this.memberSurname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(280, 268);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(127, 34);
            this.button5.TabIndex = 40;
            this.button5.Text = "Şifremi Değiştir";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Magenta;
            this.linkLabel1.Location = new System.Drawing.Point(308, 326);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(99, 16);
            this.linkLabel1.TabIndex = 39;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şifremi Unuttum";
            // 
            // memberName
            // 
            this.memberName.Location = new System.Drawing.Point(275, 118);
            this.memberName.Margin = new System.Windows.Forms.Padding(4);
            this.memberName.Name = "memberName";
            this.memberName.Size = new System.Drawing.Size(132, 22);
            this.memberName.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Eski Şifrem ;";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Yeni Şifrem ;";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 216);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Yeni Şifrem ;";
            // 
            // memberMail
            // 
            this.memberMail.Location = new System.Drawing.Point(275, 213);
            this.memberMail.Margin = new System.Windows.Forms.Padding(4);
            this.memberMail.Name = "memberMail";
            this.memberMail.Size = new System.Drawing.Size(132, 22);
            this.memberMail.TabIndex = 38;
            // 
            // memberSurname
            // 
            this.memberSurname.Location = new System.Drawing.Point(275, 183);
            this.memberSurname.Margin = new System.Windows.Forms.Padding(4);
            this.memberSurname.Name = "memberSurname";
            this.memberSurname.Size = new System.Drawing.Size(132, 22);
            this.memberSurname.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(49, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(241, 29);
            this.label8.TabIndex = 29;
            this.label8.Text = "ŞİFRELERİ YÖNET";
            // 
            // sifreleriYonet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(675, 400);
            this.ControlBox = false;
            this.Controls.Add(this.button5);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.memberName);
            this.Controls.Add(this.memberSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.memberMail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Name = "sifreleriYonet";
            this.Text = "Şifre yönetimi";
            this.Load += new System.EventHandler(this.sifreleriYonet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox memberName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox memberMail;
        private System.Windows.Forms.TextBox memberSurname;
    }
}