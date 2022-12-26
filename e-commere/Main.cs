using e_commere.src;
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
using static System.Net.Mime.MediaTypeNames;

namespace e_commere
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        CategoryProvider provider = new CategoryProvider();
        SqlConnection con = new SqlConnection("Data Source=EREN\\ROOT;Initial Catalog=E-ticaret;Integrated Security=True");
        SqlDataReader dr;
        SqlCommand cmd = new SqlCommand();
        string text;
        string productCount;
        private void Main_Load(object sender, EventArgs e)
        {
            cmbCategories.DataSource = provider.FillCombobox();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select count(*) from urun";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                productCount = dr[0].ToString();
            }
            ProductList.CreatePanel(int.Parse(productCount),this);
            dr.Close();
            con.Close();            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            //this.Show();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog();
            this.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.ShowDialog();
            this.Hide();
        }

        private void cmbSubCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void button17_Click(object sender, EventArgs e)
        {
            Ürünlerim dn = new Ürünlerim();
            dn.ShowDialog();

        }
    }
}
