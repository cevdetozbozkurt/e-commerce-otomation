using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_commere
{
    public partial class DataView : Form
    {
        public DataView()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=EREN\\ROOT;Initial Catalog=E-ticaret;Integrated Security=True");

        private void DataView_Load(object sender, EventArgs e)
        {
            listele();
        }

        public void listele()
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select Urunadi,urunfiyati from Urun",connection);
                sqlDataAdapter.Fill(ds);
                Button btn = new Button();
                dataGridView1.DataSource = ds.Tables[0];

                dataGridView1.Columns[1].HeaderText = "Ürün Adı";
                dataGridView1.Columns[1].HeaderText = "Ürün Fiyatı";
                dataGridView1.Columns[1].HeaderText = "Satın Al";
               

            }
            catch(SqlException e)
            {
                MessageBox.Show("hata oluştu = " + e.Message,"hata",MessageBoxButtons.OK);
            }
            finally
            {
                connection.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
