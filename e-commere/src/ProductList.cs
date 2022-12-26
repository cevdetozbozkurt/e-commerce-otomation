using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace e_commere.src
{
    internal class ProductList : System.Windows.Forms.ScrollableControl
    {
        public static void CreatePanel(int numberOfItem, Form form)
        {
            //ürün sayısına göre resim ve bilgi listelemek için listeler oluşturuldu.
            List<Panel> panel = new List<Panel>();
            List<PictureBox> pictureBoxes = new List<PictureBox>();
            List<LinkLabel> linkLabels = new List<LinkLabel>();
            List<System.Windows.Forms.Label> labels = new List<System.Windows.Forms.Label>();
            List<byte[]> bytes = new List<byte[]>();
            List<string> titles = new List<string>();
            List<string> price = new List<string>();

            SqlConnection con = new SqlConnection("Data Source=EREN\\ROOT;Initial Catalog=E-ticaret;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select resim1 from urunresim";
            SqlDataReader dr = cmd.ExecuteReader();
            //gelen ürünleri aşağıya kaydırarak görebilmek için yapılandırma
            FlowLayoutPanel layoutPanel = new FlowLayoutPanel();
            layoutPanel.Dock = DockStyle.None;
            layoutPanel.BackColor = Color.Transparent;
            layoutPanel.Location = new Point(145, 95);
            layoutPanel.Size = new Size(647, 360);
            layoutPanel.AutoScroll = true;
            form.Controls.Add(layoutPanel);
            while (dr.Read())
            {
                if (dr["resim1"] != null)
                {
                    bytes.Add((byte[])dr["resim1"]);
                }
            }
            dr.Close();
            //her ürünün ismini ve fiyatını almak için sql komutu yazıldı
            cmd.CommandText = "select urunadi,urunfiyati from urun";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                titles.Add((string)dr["urunadi"]);
                price.Add(dr["urunfiyati"].ToString());
            }

            int witdh = 118;
            int height = 0;

            for (int i = 0; i < numberOfItem; i++, height++)
            {
                if (height == 4)
                {
                    height = 0;
                }

                panel.Add(new Panel());
                panel[i].BorderStyle = BorderStyle.FixedSingle;
                panel[i].Location = new Point(199 + (height * 139), witdh);
                panel[i].Size = new Size(133, 175);
                panel[i].Margin = new Padding(3, 2, 3, 2);
                panel[i].Anchor = AnchorStyles.None;
                panel[i].TabIndex = 70;

                layoutPanel.Controls.Add(panel[i]);
                pictureBoxes.Add(new PictureBox());
                panel[i].Controls.Add(pictureBoxes[i]);
                pictureBoxes[i].Location = new Point(3, 2);
                pictureBoxes[i].Size = new Size(125, 117);
                pictureBoxes[i].SizeMode = PictureBoxSizeMode.StretchImage;

                pictureBoxes[i].Image = Image.FromStream(new MemoryStream(bytes[i]));
                if ((i + 1) % 4 == 0)
                {
                    witdh = 305;

                }

                linkLabels.Add(new LinkLabel());
                panel[i].Controls.Add(linkLabels[i]);
                linkLabels[i].Location = new System.Drawing.Point(14, 120);
                linkLabels[i].Size = new System.Drawing.Size(70, 30);
                linkLabels[i].AutoSize = true;
                linkLabels[i].TabIndex = 20;
                linkLabels[i].LinkColor = Color.Black;
                linkLabels[i].ActiveLinkColor = Color.Transparent;

               // linkLabels[i].LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(new object(),new System.Windows.Forms.LinkClickedEventArgs("www.google.com"));
                linkLabels[i].Text = titles[i];

                labels.Add(new System.Windows.Forms.Label());
                panel[i].Controls.Add(labels[i]);
                labels[i].Location = new Point(70, 160);
                labels[i].Size = new Size(70, 30);
                labels[i].Text = price[i] + "TL";
            }
            con.Close();
            dr.Close();
        }
    }
}
