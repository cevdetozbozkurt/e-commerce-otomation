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

        SqlConnection con = new SqlConnection("Data Source=4REEF\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
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
            loadform(new sifreleriYonet());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new adress());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadform(new siparisler());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadform(new urunlerim());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            loadform(new UrunEkleForm());
        }
        
        // Panelleri ortak formda gösterme komutları
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag= f;
            f.Show();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadform(new hesapSilme());
        }
    }
}
