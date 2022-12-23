using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_commere
{
    public partial class Profile : Form
    {

        SqlConnection con = new SqlConnection("Data Source=EREN\\ROOT;Initial Catalog=E-ticaret;Integrated Security=True");
        SqlDataReader dr;
        SqlCommand cmd = new SqlCommand();
        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select uyeadi,uyesoyadi,uyetelefon,uyeemail,uyesifre from uye where uyeid = '" + int.Parse(Login.MemberId) + "'";
            Debug.WriteLine(int.Parse(Login.MemberId));
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                memberName.Text = dr[0].ToString();
                memberSurname.Text = dr[1].ToString();
                memberPhone.Text = dr[2].ToString();
                memberMail.Text = dr[3].ToString();
                memberPass.Text = dr[4].ToString();
            }
            con.Close();
            dr.Close();
        }
    }
}
