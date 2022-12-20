﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;

namespace e_commere
{
    internal class CategoryProvider
    {
        SqlConnection con = new SqlConnection("Data Source=EREN\\ROOT;Initial Catalog=E-ticaret;Integrated Security=True");

        public List<Categories> categories { get; set; }
        public List<SubCategories> subCategories { get; set; }

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
            cmd.CommandText = "select KategoriAdi,kategoriid from Kategori";
            SqlDataReader dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
                Categories category = new Categories();
                category.CategoryID1 = dr[1].ToString();
                category.CategoryName1 = dr[0].ToString();
                categories.Add(category);
                
            }
            
            dr.Close();
            cmd.CommandText = "select KategoriAdi, altkategoriadi, kategori.kategoriid, altkategori.kategoriid from Kategori inner join altkategori on kategori.kategoriid = altkategori.kategoriid";
            dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
                SubCategories subCategory = new SubCategories();
                subCategory.KategoriId = dr[2].ToString();
                subCategory.AltKategoriName = dr[1].ToString();
                subCategories.Add(subCategory);
                Debug.WriteLine(dr[1]);
            }
            
            con.Close();
            dr.Close();
        }
        //selin bir şey ekledi
        //selin iki şey ekledi
        public List<string> FillCombobox()
        {
            return categories.Select(x => x.CategoryName1).ToList();
        }

        public List<string> FilterCategory(string topCategoryid)
        {
            if (subCategories.All(x => x.KategoriId.Equals(topCategoryid)))
            {
                return subCategories.Select(x => x.AltKategoriName).ToList();
            }
            return null;
        }
    }
}
