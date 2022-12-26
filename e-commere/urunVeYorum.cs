using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_commere
{
    public partial class urunVeYorum : Form
    {

        SqlConnection con = new SqlConnection("Data Source=EREN\\ROOT;Initial Catalog=E-ticaret;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        string price;
        byte[] pic = new byte[0];
        int urunAdet;

        public urunVeYorum()
        {
            InitializeComponent();
        }

        private void urunVeYorum_Load(object sender, EventArgs e)
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select resim1,urunfiyati,urunadet from urunresim inner join urun on urun.UrunId = UrunResim.UrunId inner join stok on urun.UrunId = stok.UrunId";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                price = reader["urunfiyati"].ToString();
                if (reader["resim1"] != null)
                {
                    pic = (byte[])reader["resim1"];
                }
                urunAdet = int.Parse(reader["urunadet"].ToString());
            }
            pictureBox1.Image = Image.FromStream(new MemoryStream(pic));
            richTextBox1.Text = price;
            reader.Close();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            urunAdet--;
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update stok set urunadet = " + urunAdet + "where = " + "urunId";
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
