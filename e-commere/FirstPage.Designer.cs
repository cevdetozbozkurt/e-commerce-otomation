namespace e_commere
{
    partial class FirstPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstPage));
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.cmbSubCategories = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbCategories
            // 
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(20, 70);
            this.cmbCategories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(166, 24);
            this.cmbCategories.TabIndex = 0;
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.cmbCategories_SelectedIndexChanged);
            // 
            // cmbSubCategories
            // 
            this.cmbSubCategories.FormattingEnabled = true;
            this.cmbSubCategories.Location = new System.Drawing.Point(20, 108);
            this.cmbSubCategories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSubCategories.Name = "cmbSubCategories";
            this.cmbSubCategories.Size = new System.Drawing.Size(166, 24);
            this.cmbSubCategories.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(17, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategoriler";
            // 
            // FirstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSubCategories);
            this.Controls.Add(this.cmbCategories);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FirstPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FirstPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.ComboBox cmbSubCategories;
        private System.Windows.Forms.Label label1;
    }
}