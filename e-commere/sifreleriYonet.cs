using System;
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
    public partial class sifreleriYonet : Form
    {
        public sifreleriYonet()
        {
            InitializeComponent();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            FirstPage fp = new FirstPage();
            this.Hide();
            fp.ShowDialog();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void sifreleriYonet_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            this.Hide();
            profile.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sifreleriYonet sifre = new sifreleriYonet();
            this.Hide();
            sifre.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adress adres = new adress();
            this.Hide();
            adres.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            siparisler siparis = new siparisler();
            this.Hide();
            siparis.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ürünlerim urunum = new Ürünlerim();
            this.Hide();
            urunum.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            urunSat ekle = new urunSat();
            this.Hide();
            ekle.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            urunSat sat = new urunSat();
            this.Hide();
            sat.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string password = "";
            SqlConnection con = new SqlConnection("Data Source=EREN\\ROOT;Initial Catalog=E-ticaret;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select uyesifre from uye where uyeid = '" + Login.MemberId + "'";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                password = dr[0].ToString();
            }
            dr.Close();
            

            if (!memberPass.Text.Equals(password))
            {
                MessageBox.Show("Eski şifreniz yanlış", "hata", MessageBoxButtons.OK);
            }else if(!newPass.Text.Equals(newPass2.Text) || !newPass2.Text.Equals(newPass.Text))
            {
                MessageBox.Show("Girdiğiniz şifreler uyuşmuyor", "hata", MessageBoxButtons.OK);
            }else if (newPass.Text.Equals(password) || newPass2.Text.Equals(password))
            {
                MessageBox.Show("Yeni şifreniz eskisi ile aynı olamaz", "hata", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Şifreniz değiştirildi", "Başarı", MessageBoxButtons.OK);
                cmd.CommandText = "update Uye set uyesifre = '"+ newPass.Text +"' where uyeid = '" + Login.MemberId + "'";
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
    }
}
