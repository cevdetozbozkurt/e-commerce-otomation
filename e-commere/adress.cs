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
    public partial class adress : Form
    {
        public adress()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=EREN\\ROOT;Initial Catalog=E-ticaret;Integrated Security=True");
        SqlDataReader dr;
        SqlCommand cmd = new SqlCommand();

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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            urunSat sat = new urunSat();
            this.Hide();
            sat.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update uyeadres set adressehir = '" + ilBox1.Text + "', adresilce = '" + ilceText.Text + "', AdresPK = '"+ pkText.Text +"', adresmetni = '"+ productComment.Text+ "' where uyeid = '" + Login.MemberId + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Adresiniz güncellendi", "Bilgilendirm", MessageBoxButtons.OK);
        }
    }
}
