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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }



        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void enteringButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=EREN\\ROOT;Initial Catalog=E-ticaret;Integrated Security=True");
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

                cmd.CommandText = "select uyesifre from uye where uyeemail = " + "'" + eMailTextBox.Text + "'";
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    pass.Add(reader["uyesifre"]);
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
    }
}
