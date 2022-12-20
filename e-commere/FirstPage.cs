using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_commere
{
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        CategoryProvider provider = new CategoryProvider();

        private void FirstPage_Load(object sender, EventArgs e)
        {
            cmbCategories.DataSource = provider.FillCombobox();
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSubCategories.DataSource = provider.FilterCategory("qwe");
            Debug.WriteLine("wsd");
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            FirstPage fp = new FirstPage(); // Kullanıcıyı sürekli çıkmaktan engellemk
            fp.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FirstPage fp = new FirstPage();
            fp.ShowDialog();
        }
    }
}
