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
    public partial class Form3 : Form
    {
        public Form3(List<Musteri> musteri)
        {
            InitializeComponent();
            musteriler = musteri;
        }

        List<Musteri> musteriler;

        private void Form3_Load(object sender, EventArgs e)
        {
            int bayan = 0, erkek = 0;
            for (int i = 0; i < musteriler.Count; i++)
            {
                lstIzleyiciler.Items.Add(musteriler[i].adSoyad);
                if (musteriler[i].cinsiyet)
                {
                    erkek++;
                }
                else
                {
                    bayan++;
                }
            }
            lblToplamIzleyici.Text = musteriler.Count.ToString();
            lblErkekIzleyici.Text = erkek.ToString();
            lblBayanIzleyici.Text = bayan.ToString();
        }
    }
}
