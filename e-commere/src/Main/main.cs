using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace e_commere.src.Main
{
    internal class main
    {
        public int error = 1;

        SqlConnection con = new SqlConnection();

        public main()
        {
            con = new SqlConnection(@"Data Source=EREN\ROOT;Initial Catalog=E-ticaret;Integrated Security=True");
        }
        public void open()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void close()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        SqlCommand cmd = new SqlCommand("Select * from Urun");
        
    }
}
