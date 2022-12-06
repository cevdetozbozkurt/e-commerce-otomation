﻿using System;
using System.Collections;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=EREN\\ROOT;Initial Catalog=E-ticaret;Integrated Security=True");



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "select uyeemail from uye";
            bool isAlreadyThere = false;
            ArrayList uyeemail = new ArrayList();
            SqlDataReader reader = cmd.ExecuteReader();

            try
            {
                int hata = 0;
                if (nameText.Text == string.Empty || lastNameText.Text == string.Empty || phoneNumText.Text == string.Empty || mailText.Text == string.Empty
                    || passwordText.Text == string.Empty || passwordCheckText.Text == string.Empty || addressText.Text == string.Empty)
                {
                    hata = 1;
                }
                if (!passwordText.Text.Equals(passwordCheckText.Text))
                {
                    hata = 2;
                }
                while (reader.Read())
                {
                    uyeemail.Add(reader["uyeemail"]);
                }
                foreach (string i in uyeemail)
                {
                    if (i.ToString().Equals(mailText.Text)){
                        hata = 3; 
                    }
                }
                reader.Close();

                if (hata == 1)
                {
                    MessageBox.Show("Lütfen bütün alanları doldurunuz...", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (hata == 2)
                {
                    MessageBox.Show("Girdiğiniz Şifreler Aynı olmalı...", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }else if(hata == 3)
                {
                    MessageBox.Show("Daha önce bu email ile kayıt olunmuş lütfen başka bir mail giriniz...", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    
                    SqlCommand add = new SqlCommand("insert into Uye(UyeAdi,UyeSoyadi,UyeTelefon,UyeEmail,UyeSifre,UyeTarih) values ('" + nameText.Text + "','" + lastNameText.Text + "','" + phoneNumText.Text + "','" + mailText.Text + "','" + passwordText.Text + "','" + DateTime.Now + "')", connection);
                    int basari = add.ExecuteNonQuery();
                    if (basari == 1)
                    {
                        MessageBox.Show("Kayıt Eklendi");
                    }
                    else
                    {
                        MessageBox.Show("Kayıt eklenmedi");
                    }
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
                /*
                DataView dv = new DataView();
                dv.listele();
                this.Hide();
                dv.ShowDialog();
                this.Show();
                */
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
