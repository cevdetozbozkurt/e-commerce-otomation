using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace e_commere
{
    internal class CategoryProvider
    {
        SqlConnection con = new SqlConnection("Data Source=EREN\\ROOT;Initial Catalog=E-ticaret;Integrated Security=True");

        public List<Categories> categories { get; set; }

        public CategoryProvider()
        {
            categories = new List<Categories>();
            GetCategories();
        }

        private void GetCategories()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select KategoriAdi from Kategori";
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Categories category = new Categories();
                category.CategoryName1 = dr[0].ToString();
                categories.Add(category);
            }
            dr.Close();
            con.Close();

        }

        public List<string> FillCombobox()
        {
            return categories.Select(x => x.CategoryName1).ToList();
        }

    }
}
