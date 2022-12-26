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
    public partial class hesapSilme : Form
    {
        public hesapSilme()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=EREN\\ROOT;Initial Catalog=E-ticaret;Integrated Security=True");
        SqlDataReader dr;
        SqlCommand cmd = new SqlCommand();
        string name;
        string email;
        string pass;
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            this.Hide();
            profile.ShowDialog();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
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
            hesapSilme sil = new hesapSilme();
            this.Hide();
            sil.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            urunSat ekle = new urunSat();
            this.Hide();
            ekle.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select uyeadi,uyeemail,uyesifre from uye where uyeid = '" + Login.MemberId + "'";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                name = dr[0].ToString();
                email = dr[1].ToString();
                pass = dr[2].ToString();
            }

            if(memberMail.Equals(email) && memberName.Equals(name) && memberPass.Equals(pass))
            {
                MessageBox.Show("Hesabınız silindi. Anasayfaya yönlendiriliyorsunuz. ", "Bilgilendirme", MessageBoxButtons.OK);
                Main m = new Main();
                m.ShowDialog();
                this.Hide();
            }
        }
    }
}
