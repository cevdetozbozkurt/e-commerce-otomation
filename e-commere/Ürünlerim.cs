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

namespace e_commere
{
    public partial class Ürünlerim : Form
    {
        public Ürünlerim()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=EREN\\ROOT;Initial Catalog=E-ticaret;Integrated Security=True");
        private void DenemeFrorm_Load(object sender, EventArgs e)
        {
            listele();
        }
        
        public void listele()
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select Urunadi,urunfiyati,urunadet,urun.urunid from Urun inner join stok on urun.urunid = stok.urunid inner join uye on stok.uyeid = uye.uyeid where uye.uyeid = '" + Login.MemberId + "'" , connection);
                sqlDataAdapter.Fill(ds);
                Button btn = new Button();
                dataGridView1.DataSource = ds.Tables[0];

                dataGridView1.Columns[1].HeaderText = "Ürün Adı";
                dataGridView1.Columns[1].HeaderText = "Ürün Fiyatı";
                dataGridView1.Columns[1].HeaderText = "Ürün Adet";
                dataGridView1.Columns[1].HeaderText = "ID";


            }
            catch (SqlException e)
            {
                MessageBox.Show("hata oluştu = " + e.Message, "hata", MessageBoxButtons.OK);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FirstPage fp = new FirstPage();
            this.Hide();
            fp.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            urunSat sat = new urunSat();
            this.Hide();
            sat.ShowDialog();
        }

        int urunAdet;

        private void button7_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            connection.Open();
            cmd.Connection = connection;
            cmd.CommandText = "select urunadet from stok where urunid = '" + int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString()) + "'";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                urunAdet = int.Parse(dr["urunadet"].ToString());
            }
            dr.Close();
            cmd.CommandText = "update stok set urunadet = " + (urunAdet - int.Parse(count.Text))+ "where  urunid = '" + int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString()) + "'";
            cmd.ExecuteNonQuery();
            connection.Close();
            listele();
        }
    }
}
