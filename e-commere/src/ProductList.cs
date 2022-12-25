using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
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
            List<Panel> panel = new List<Panel>();
            List<PictureBox> pictureBoxes = new List<PictureBox>();
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
                form.Controls.Add(panel[i]);
                pictureBoxes.Add(new PictureBox());
                panel[i].Controls.Add(pictureBoxes[i]);
                pictureBoxes[i].Location = new Point(3, 2);
                pictureBoxes[i].Size = new Size(125, 117);
                pictureBoxes[i].SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxes[i].Image = null;
                if ((i + 1) % 4 == 0)
                {
                    witdh = 305;

                }
            }
        }
    }
}
