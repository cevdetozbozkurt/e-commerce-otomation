using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_commere.src
{
    internal class ImageProvider
    {
        public static void GetImage(PictureBox pictureBox)
        {
            SqlConnection con = new SqlConnection("Data Source=EREN\\ROOT;Initial Catalog=E-ticaret;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select Resim1 from urunresim";
            dr = cmd.ExecuteReader();
            Debug.WriteLine(dr.Read());
          
            while (dr.Read())
            {
                if (dr["Resim1"] != null /*|| dr["Resim2"] != null || dr["Resim3"] != null || dr["Resim4"] != null*/)
                {
                    /*
                    byte[] image2 = new byte[0];
                    byte[] image3 = new byte[0];
                    byte[] image4 = new byte[0];
                    image2 = (byte[])dr["Resim2"];
                    image3 = (byte[])dr["Resim3"];
                    image4 = (byte[])dr["Resim4"];
                    */

                    byte[] image1 = new byte[0];
                    image1 = (byte[])dr["Resim1"];

                    MemoryStream memoryStream = new MemoryStream(image1); 
                    pictureBox.Image = Image.FromStream(memoryStream);
                    cmd.Dispose();
                }
            }
            dr.Close();
            con.Close();
        }

    }
}
