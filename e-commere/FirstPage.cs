using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace e_commere
{
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        CategoryProvider provider = new CategoryProvider();
        SqlConnection con = new SqlConnection("Data Source=EREN\\ROOT;Initial Catalog=E-ticaret;Integrated Security=True");
        SqlDataReader dr;
        string text;
        private void FirstPage_Load(object sender, EventArgs e)
        {
            Console.WriteLine(provider.subCategories);
            cmbCategories.DataSource = provider.FillCombobox();
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select Kategori.kategoriid from altkategori inner join Kategori on Kategori.KategoriId = AltKategori.KategoriId where KategoriAdi = '" + cmbCategories.Text + "'";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                text = dr[0].ToString();
            }
            cmbSubCategories.DataSource = provider.FilterCategory(text);
            dr.Close();
            con.Close();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text.Equals("Ürün Sat"))
            {
                urunSat urunEkleForm = new urunSat();
                urunEkleForm.ShowDialog();
                con.Close();
            }else if(comboBox1.Text.Equals("Profilim"))
            {
                //dr.Close();
                con.Close();
                Profile profile = new Profile();
                this.Hide();
                profile.ShowDialog();
            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            FirstPage fp = new FirstPage(); // Kullanıcıyı sürekli çıkmaktan engellemk
            fp.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FirstPage fp = new FirstPage();
            fp.ShowDialog();
        }

        private void cmbSubCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            urunVeYorum uvy = new urunVeYorum();
            uvy.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            urunVeYorum uvy = new urunVeYorum();
            uvy.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            urunVeYorum uvy = new urunVeYorum();
            uvy.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            urunVeYorum uvy = new urunVeYorum();
            uvy.Show();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            urunVeYorum uvy = new urunVeYorum();
            uvy.Show();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            urunVeYorum uvy = new urunVeYorum();
            uvy.Show();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            urunVeYorum uvy = new urunVeYorum();
            uvy.Show();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            urunVeYorum uvy = new urunVeYorum();
            uvy.Show();
        }
    }
}
