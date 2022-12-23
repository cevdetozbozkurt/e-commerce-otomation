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
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace e_commere
{
    public partial class UrunEkleForm : Form
    {
        public UrunEkleForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=EREN\\ROOT;Initial Catalog=E-ticaret;Integrated Security=True");
        ProductProvider productProvider;
        CategoryProvider categoryProvider = new CategoryProvider();
        SqlDataReader dr;
        string categoryIdText;
        string subCategoryIdText;
        string imagePath1;
        string imagePath2;
        string imagePath3;
        string imagePath4;
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

        private void chosePic2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Resim Seç";
            openFileDialog.Filter = "Png(*.png)|*.png| Jpeg(*.jpeg)|*.jpeg| Jpg(*.jpg)|.jpg| Gif(*.gif)|*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(openFileDialog.FileName);
                imagePath2 = openFileDialog.FileName;
            }
        }

        private void chosePic3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Resim Seç";
            openFileDialog.Filter = "Png(*.png)|*.png| Jpeg(*.jpeg)|*.jpeg| Jpg(*.jpg)|.jpg| Gif(*.gif)|*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.Image = Image.FromFile(openFileDialog.FileName);
                imagePath3 = openFileDialog.FileName;
            }
        }

        private void chosePic4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Resim Seç";
            openFileDialog.Filter = " Png(*.png)|*.png| Jpeg(*.jpeg)|*.jpeg| Jpg(*.jpg)|.jpg| Gif(*.gif)|*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox4.Image = Image.FromFile(openFileDialog.FileName);
                imagePath4 = openFileDialog.FileName;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //database connection yapıldı.
            con.Open();

            //ürünlerin 

            //ürünlerin bilgilerini alıp database e atmak için :

            productProvider = new ProductProvider();
            productProvider.AddProduct(productCode: "123", productName.Text, productPrice.Text, productComment.Text, categoryIdText, subCategoryIdText);






            //Ürünlere Resim Eklemek için dosya okuma :
            FileStream stream = new FileStream(imagePath1, FileMode.Open, FileAccess.Read);
            FileStream stream1 = new FileStream(imagePath2, FileMode.Open, FileAccess.Read);
            FileStream stream2 = new FileStream(imagePath3, FileMode.Open, FileAccess.Read);
            FileStream stream3 = new FileStream(imagePath4, FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(stream);
            BinaryReader br1 = new BinaryReader(stream1);
            BinaryReader br2 = new BinaryReader(stream2);   
            BinaryReader br3 = new BinaryReader(stream3);
    
            byte[] pic1 = br.ReadBytes((int)stream.Length);
            byte[] pic2 = br1.ReadBytes((int)stream1.Length);
            byte[] pic3 = br2.ReadBytes((int)stream2.Length);
            byte[] pic4 = br3.ReadBytes((int)stream3.Length);
    
            br.Close();
            br1.Close();
            br2.Close();
            br3.Close();
     
            stream.Close();
            stream1.Close();
            stream2.Close();
            stream3.Close();
     

            //Seçilen resimleri database'e resim yolu verilerek aktarma:
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into UrunResim(Resim1,Resim2,Resim3,Resim4) values(@image1,@image2,@image3,@image4)";
            SqlParameter imageParameter = new SqlParameter("@image1", SqlDbType.Image);
            imageParameter.Value = pic1;
            cmd.Parameters.Add(imageParameter);
            SqlParameter imageParameter1 = new SqlParameter("@image2", SqlDbType.Image);
            imageParameter1.Value = pic2;
            cmd.Parameters.Add(imageParameter1);
            SqlParameter imageParameter2 = new SqlParameter("@image3", SqlDbType.Image);
            imageParameter2.Value = pic3;
            cmd.Parameters.Add(imageParameter2);
            SqlParameter imageParameter3 = new SqlParameter("@image4", SqlDbType.Image);
            imageParameter3.Value = pic4;
            cmd.Parameters.Add(imageParameter3);
           
            cmd.Parameters.Add("@image1",SqlDbType.Image,pic1.Length).Value = pic1;
            cmd.Parameters.Add("@image2",SqlDbType.Image,pic2.Length).Value = pic2;
            cmd.Parameters.Add("@image3",SqlDbType.Image,pic3.Length).Value = pic3;
            cmd.Parameters.Add("@image4",SqlDbType.Image,pic4.Length).Value = pic4;
          
            //cmd.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("KayıtEklendi","Kayıt",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
