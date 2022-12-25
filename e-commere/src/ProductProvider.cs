using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_commere
{
    internal class ProductProvider
    {
        SqlConnection con = new SqlConnection("Data Source=EREN\\ROOT;Initial Catalog=E-ticaret;Integrated Security=True");


        public ProductProvider()
        {

        }

        //ürünleri eklemek için 
        public void AddProduct(string productCode,string productName, string productPrice,
            string productComment,string categoryId, string subCategoryId, string numOfProduct)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            //"+"'"+ DateTime.Now+ "'"+"
            cmd.CommandText = "insert into Urun(UrunKodu,UrunAdi,UrunFiyati,UrunAciklama,UrunTarih,KategoriId,AltKategoriId)" +
                "values(@code,@name,@price,@comment,@date,@categoryId,@subCategoryId)";
            cmd.Parameters.Add("@code", SqlDbType.NVarChar, productCode.Length).Value = productCode;
            cmd.Parameters.Add("@name", SqlDbType.VarChar, productName.Length).Value = productName;
            cmd.Parameters.Add("@price", SqlDbType.Money, productPrice.Length).Value = productPrice;
            cmd.Parameters.Add("@comment", SqlDbType.Text, productComment.Length).Value = productComment;
            cmd.Parameters.Add("@categoryId", SqlDbType.Int, int.Parse(categoryId)).Value = int.Parse(categoryId);
            cmd.Parameters.Add("@subCategoryId", SqlDbType.Int, subCategoryId.Length).Value = int.Parse(subCategoryId);
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            cmd.ExecuteNonQuery();
            //son eklenen ürün olan bu ürünün id sini alıp atama yapılıyor.
            cmd.CommandText = "select top 1 urunid from urun order by urunid desc ";
            string productIdText = "";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                productIdText = dr[0].ToString();
            }
            dr.Close();
            //ürünü koyan satıcının adresi alınıyor.
            string memberAddressText = "";
            cmd.CommandText = "select adresmetni,adresilce,adressehir,adrespk from uyeadres where uyeid = '" +Login.MemberId + "'";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                memberAddressText = dr[0].ToString()+ " " + dr[2].ToString() + " " + dr[1].ToString() + " " + dr[3].ToString() ;
            }
            dr.Close();
            cmd.CommandText = "insert into Stok(urunadet,depoadres,urunid,uyeid) " +
                "values(@numOfProduct,@address,@productId,@memberId)";
            SqlParameter numOfProducts = new SqlParameter("@numOfProduct", SqlDbType.Int);
            numOfProducts.Value = int.Parse(numOfProduct);
            cmd.Parameters.Add(numOfProducts);
            SqlParameter address = new SqlParameter("@address", SqlDbType.NVarChar);
            address.Value = memberAddressText;
            cmd.Parameters.Add(address);
            SqlParameter productId = new SqlParameter("@productId", SqlDbType.Int);
            productId.Value = productIdText;
            cmd.Parameters.Add(productId);
            SqlParameter memberId = new SqlParameter("@memberId", SqlDbType.Int);
            memberId.Value = int.Parse(Login.MemberId);
            cmd.Parameters.Add(memberId);
            cmd.ExecuteNonQuery();
            con.Close();
            
        }
    }
}
