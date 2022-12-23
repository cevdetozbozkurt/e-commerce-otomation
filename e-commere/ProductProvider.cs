using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string productComment,string categoryId, string subCategoryId)
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
            cmd.Parameters.Add("@categoryId", SqlDbType.Int, categoryId.Length).Value = Int16.Parse(categoryId);
            cmd.Parameters.Add("@subCategoryId", SqlDbType.Int, subCategoryId.Length).Value = Int32.Parse(subCategoryId);
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Now;
            cmd.ExecuteNonQuery();
            con.Close();
            
        }
    }
}
