using System;
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
    public partial class Profile : Form
    {

        SqlConnection con = new SqlConnection("Data Source=EREN\\ROOT;Initial Catalog=E-ticaret;Integrated Security=True");
        SqlDataReader dr;
        SqlCommand cmd = new SqlCommand();
        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select uyeadi,uyesoyadi,uyetelefon,uyeemail,uyesifre from uye where uyeId = '" + int.Parse(Login.MemberId) + "'";
            Debug.WriteLine(int.Parse(Login.MemberId));
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                memberName.Text = dr[0].ToString();
                memberSurname.Text = dr[1].ToString();
                memberPhone.Text = dr[2].ToString();
                memberMail.Text = dr[3].ToString();
                memberPass.Text = dr[4].ToString();
            }
            con.Close();
            dr.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FirstPage fp = new FirstPage();
            this.Hide();
            fp.ShowDialog();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            hesapSilme sil = new hesapSilme();
            this.Hide();
            sil.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UrunEkleForm ekle = new UrunEkleForm();
            this.Hide();
            ekle.ShowDialog();
        }
    }
}
