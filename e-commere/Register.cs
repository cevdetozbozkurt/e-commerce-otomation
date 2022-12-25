using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_commere
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=4REEF\\SQLEXPRESS;Initial Catalog=E-ticaret;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
        bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
        private void registerButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "select uyeemail from uye";
            bool isAlreadyThere = false;
            ArrayList uyeemail = new ArrayList();
            SqlDataReader reader = cmd.ExecuteReader();

            try
            {
                int hata = 0;
                if (nameText.Text == string.Empty || lastNameText.Text == string.Empty || phoneNumText.Text == string.Empty || mailText.Text == string.Empty
                    || passwordText.Text == string.Empty || passwordCheckText.Text == string.Empty || addressText.Text == string.Empty)
                {
                    hata = 1;
                }
                if (!passwordText.Text.Equals(passwordCheckText.Text))
                {
                    hata = 2;
                }
                while (reader.Read())
                {
                    uyeemail.Add(reader["uyeemail"]);
                }
                foreach (string i in uyeemail)
                {
                    if (i.ToString().Equals(mailText.Text)){
                        hata = 3; 
                    }
                }
                reader.Close();

                if (hata == 1)
                {
                    MessageBox.Show("Lütfen bütün alanları doldurunuz...", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (hata == 2)
                {
                    MessageBox.Show("Girdiğiniz Şifreler Aynı olmalı...", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }else if(hata == 3)
                {
                    MessageBox.Show("Daha önce bu email ile kayıt olunmuş lütfen başka bir mail giriniz...", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }else if (!IsValidEmail(mailText.Text))
                {
                    MessageBox.Show("Lütfen düzgün bir email formatı giriniz.", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    
                    SqlCommand add = new SqlCommand("insert into Uye(UyeAdi,UyeSoyadi,UyeTelefon,UyeEmail,UyeSifre,UyeTarih) values ('" + nameText.Text + "','" + lastNameText.Text + "','" + phoneNumText.Text + "','" + mailText.Text + "','" + passwordText.Text + "','" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "')", connection);
                    int basari = add.ExecuteNonQuery();
                    if (basari == 1)
                    {
                        MessageBox.Show("Kayıt Eklendi");
                    }
                    else
                    {
                        MessageBox.Show("Kayıt eklenmedi");
                    }
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
                /*
                DataView dv = new DataView();
                dv.listele();
                this.Hide();
                dv.ShowDialog();
                this.Show();
                */
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void phoneNumText_TextChanged(object sender, EventArgs e2/*, KeyPressEventArgs e*/)
        {
            /*
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                
            }
            */
        }
    }
}
