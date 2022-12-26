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
    public partial class Ürünlerim : Form
    {
        public Ürünlerim()
        {
            InitializeComponent();
        }

        private void DenemeFrorm_Load(object sender, EventArgs e)
        {
            ProductList.CreatePanel(8,this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ürünlerim urunum = new Ürünlerim();
            this.Hide();
            urunum.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            urunSat ekle = new urunSat();
            this.Hide();
            ekle.ShowDialog();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FirstPage fp = new FirstPage();
            this.Hide();
            fp.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            urunSat sat = new urunSat();
            this.Hide();
            sat.ShowDialog();
        }
    }
}
