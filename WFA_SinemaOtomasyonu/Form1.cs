using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_SinemaOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string harfler = "FEDCBA";
            int x = 6;
            for (int j = 0; j < 13; j++)
            {
                int y = 19;
                for (int i = 0; i < 6; i++)
                {
                    if ((i % 2 != 0 && j != 12) || (j > 1 && j < 10))
                    {
                        PictureBox pcb = new PictureBox();
                        pcb.Name = harfler[i].ToString() + (j + 1).ToString();
                        pcb.Height = pcb.Width = 50;
                        pcb.BackColor = Color.Black;
                        pcb.Location = new Point(x, y);
                        pcb.Image = Image.FromFile(@"..\..\image\imagesmavi.jpg");
                        pcb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pcb.Click += Pcb_Click;
                        gbKoltuklar.Controls.Add(pcb);
                    }
                    else if (j == 12)
                    {
                        Label lblharf = new Label();
                        lblharf.Height = 50;
                        lblharf.Width = 20;
                        lblharf.BorderStyle = BorderStyle.FixedSingle;
                        lblharf.TextAlign = ContentAlignment.MiddleCenter;
                        lblharf.Text = harfler[i].ToString();
                        lblharf.Location = new Point(x, y);
                        gbKoltuklar.Controls.Add(lblharf);
                    }
                    y += 56;
                }
                if (j != 12)
                {
                    Label lblsayi = new Label();
                    lblsayi.Height = 20;
                    lblsayi.Width = 50;
                    lblsayi.BorderStyle = BorderStyle.FixedSingle;
                    lblsayi.TextAlign = ContentAlignment.MiddleCenter;
                    lblsayi.Text = (j + 1).ToString();
                    lblsayi.Location = new Point(x, y);
                    gbKoltuklar.Controls.Add(lblsayi);
                }
                if (j % 2 == 0)
                {
                    x += 56 + 10;
                }
                else if (j == 5)
                {
                    x += 56 + 8;
                }
                else
                {
                    x += 56;
                }
            }
        }

        static PictureBox pcb;

        private void Pcb_Click(object sender, EventArgs e)
        {
            pcb = (PictureBox)sender;
            Form2 frm = new Form2(pcb);
            frm.ShowDialog();
        }

        public static void KoltukDurum(object musteri)
        {
            pcb.Tag = musteri;
            if (pcb.Tag != null)
            {
                pcb.Image = Image.FromFile(@"..\..\image\imageskirmizi.jpg");
            }
            else
            {
                pcb.Image = Image.FromFile(@"..\..\image\imagesmavi.jpg");
            }
        }

        private void BtnGunlukAnaliz_Click(object sender, EventArgs e)
        {
            List<Musteri> musteriler = new List<Musteri>();
            foreach (Control ctrl in gbKoltuklar.Controls)
            {
                if (ctrl is PictureBox && ctrl.Tag != null)
                {
                    musteriler.Add(ctrl.Tag as Musteri);
                }
            }
            Form3 frm = new Form3(musteriler);
            frm.ShowDialog();

        }
    }
}
