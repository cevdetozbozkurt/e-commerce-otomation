﻿using System;
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
    public partial class adress : Form
    {
        public adress()
        {
            InitializeComponent();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            FirstPage fp = new FirstPage();
            this.Hide();
            fp.ShowDialog();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            this.Hide();
            profile.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sifreleriYonet sifre = new sifreleriYonet();
            this.Hide();
            sifre.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adress adres = new adress();
            this.Hide();
            adres.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            siparisler siparis = new siparisler();
            this.Hide();
            siparis.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hesapSilme sil = new hesapSilme();
            this.Hide();
            sil.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UrunEkleForm ekle = new UrunEkleForm();
            this.Hide();
            ekle.ShowDialog();
        }
    }
}