using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using Image = System.Drawing.Image;

namespace e_commere
{
    public partial class UrunEkleForm : Form
    {
        public UrunEkleForm()
        {
            InitializeComponent();
        }
        //Data Source=4REEF\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
        SqlConnection con = new SqlConnection("Data Source=4REEF\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        ProductProvider productProvider;
        CategoryProvider categoryProvider = new CategoryProvider();
        SqlDataReader dr;
        string categoryIdText;
        string subCategoryIdText;
        string imagePath1;
        string productIdText;
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UrunEkleForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = categoryProvider.FillCombobox();
        }

        private void chosePic1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Resim Seç";
            openFileDialog.Filter = "Png(*.png)|*.png| Jpeg(*.jpeg)|*.jpeg| Jpg(*.jpg)|.jpg| Gif(*.gif)|*.gif";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                imagePath1 = openFileDialog.FileName;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //database connection yapıldı.
            con.Open();
            
            //orda bir tane de ürün adedi diye text box vardı o da yok senin yaptığın şeyden dolayı onu da ekler misin veya bekle
            //ürünlerin bilgilerini alıp database e atmak için :

            productProvider = new ProductProvider();
            productProvider.AddProduct(productCode: Login.MemberId + categoryIdText + subCategoryIdText, productName.Text, productPrice.Text, productComment.Text, categoryIdText, subCategoryIdText, numOfProduct.Text);


            //Ürünlere Resim Eklemek için dosya okuma :
            FileStream stream = new FileStream(imagePath1, FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(stream);

            byte[] pic1 = br.ReadBytes((int)stream.Length);

            br.Close();
     
            stream.Close();     

            //Seçilen resimleri database'e resim yolu verilerek aktarma:
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            
            cmd.CommandText = "select urunid from urun where urunadi = '" + productName.Text + "'";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                productIdText = dr[0].ToString();
            }
            dr.Close();

            cmd.CommandText = "insert into UrunResim(Resim1,urunid) values(@image1,@id)";
            SqlParameter imageParameter = new SqlParameter("@image1", SqlDbType.Image);
            imageParameter.Value = pic1;
            cmd.Parameters.Add(imageParameter);

            SqlParameter idParameter = new SqlParameter("@id", SqlDbType.Int);
            idParameter.Value = int.Parse(productIdText);
            cmd.Parameters.Add(idParameter);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("KayıtEklendi","Kayıt",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
        }

        private void productName_TextChanged(object sender, EventArgs e)
        {

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
            UrunEkleForm ekle = new UrunEkleForm();
            this.Hide();
            ekle.ShowDialog();
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SqlDataReader dr2;
            SqlConnection con2 = new SqlConnection("Data Source=EREN\\ROOT;Initial Catalog=E-ticaret;Integrated Security=True");
            con2.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con2;
            cmd.CommandText = "select altkategoriId from altkategori where altkategoriadi =  '" + comboBox2.Text + "'";
            dr2 = cmd.ExecuteReader();
            while (dr2.Read())
            {
                subCategoryIdText = dr2[0].ToString();
            }
            dr2.Close();
            con2.Close();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select Kategori.kategoriid from altkategori inner join Kategori on Kategori.KategoriId = AltKategori.KategoriId where KategoriAdi = '" + comboBox1.Text + "'";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                categoryIdText = dr[0].ToString();
            }
            comboBox2.DataSource = categoryProvider.FilterCategory(categoryIdText);
            dr.Close();
            con.Close();
        }
    }
}
