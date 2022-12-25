using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms.VisualStyles;

namespace e_commere
{
    internal class CategoryProvider
    {
        SqlConnection con = new SqlConnection("Data Source=EREN\\ROOT;Initial Catalog=E-ticaret;Integrated Security=True");

        public List<Categories> categories { get; set; }
        public List<SubCategories> subCategories { get; set; }
        public Categories category;
        public SubCategories subCategory;

        public CategoryProvider()
        {
            categories = new List<Categories>();
            subCategories = new List<SubCategories>();
            GetCategories();
            
        }

        private void GetCategories()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select KategoriAdi,KategoriId from Kategori";
            SqlDataReader dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
                category = new Categories();
                category.CategoryID1 = dr[1].ToString();
                category.CategoryName1 = dr[0].ToString();
                categories.Add(category);
                
            }
            
            dr.Close();
            cmd.CommandText = "select KategoriAdi, altkategoriadi, kategori.KategoriId, altkategori.KategoriId from Kategori inner join altkategori on kategori.KategoriId = altkategori.KategoriId";
            dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
                subCategory = new SubCategories();
                subCategory.KategoriId = dr[2].ToString();
                subCategory.AltKategoriName = dr[1].ToString();
                subCategories.Add(subCategory);
            }
            
            con.Close();
            dr.Close();
        }
        public List<string> FillCombobox()
        {
            return categories.Select(x => x.CategoryName1).ToList();
        }

        public List<string> FilterCategory(string text)
        {
            var query1 = subCategories.Where(x => x.KategoriId.Equals(text));
            return query1.Select(x => x.AltKategoriName).ToList();
        }
    }
}
