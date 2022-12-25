using e_commere.src;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_commere
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private static string memberId;

        public static string MemberId { get => memberId; set => memberId = value; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void enteringButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=4REEF\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandText = "select uyeemail from uye";
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            ArrayList pass = new ArrayList();
            
            bool isThere = false;
            bool isPasswordTrue = false;
            while (reader.Read())
            {
                if (eMailTextBox.Text.Equals(reader["uyeemail"]))
                {
                    
                    isThere = true;
                }
            }
            reader.Close();    
            if (isThere)
            {

                cmd.CommandText = "select uyesifre,uyeId from uye where uyeemail = " + "'" + eMailTextBox.Text + "'";
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    pass.Add(reader["uyesifre"]);
                    MemberId = reader["uyeId"].ToString();

                }
                foreach (string i in pass)
                {
                    if (i.ToString().Equals(passwordTextBox.Text))
                    {
                        isPasswordTrue = true;
                    }
                }
                reader.Close();
            }
            
            if (isPasswordTrue)
            {
                FirstPage firstPage = new FirstPage();
                this.Hide();
                firstPage.ShowDialog();
                this.Show();
            }
            else
            {

                MessageBox.Show("email veya şifre hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            conn.Close();

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Çıkış ataması yapıldı
        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void forgetPassword_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Main main= new Main(); // Ana Sayfaya dönme
            main.ShowDialog();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
