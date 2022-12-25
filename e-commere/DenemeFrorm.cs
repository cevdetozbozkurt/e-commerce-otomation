using e_commere.src;
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
    public partial class DenemeFrorm : Form
    {
        public DenemeFrorm()
        {
            InitializeComponent();
        }

        private void DenemeFrorm_Load(object sender, EventArgs e)
        {
            ProductList.CreatePanel(8,this);
        }
    }
}
