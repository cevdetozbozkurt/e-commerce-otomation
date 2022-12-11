using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
