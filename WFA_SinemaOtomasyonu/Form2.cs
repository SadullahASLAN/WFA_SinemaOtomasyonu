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
    public partial class Form2 : Form
    {
        public Form2(Control ctrl)
        {
            InitializeComponent();
            pcb = ctrl as PictureBox;
            txtKoltukNo.Text = ctrl.Name;
        }

        PictureBox pcb;

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void BtnOnayla_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdSoyad.Text) || string.IsNullOrWhiteSpace(txtTCNo.Text) || (!rbBay.Checked && !rbBayan.Checked))
            {
                MessageBox.Show("Lütfen tüm alanları alanları doldurunuz.");
            }
            else
            {
                Musteri musteri = new Musteri();
                musteri.adSoyad = txtAdSoyad.Text;
                try
                {
                    musteri.TCNo = txtTCNo.Text;
                }
                catch
                {
                    MessageBox.Show("T.C. Kimlik numarası 11 haneli olmalıdır.");
                    return;
                }
                musteri.cinsiyet = rbBay.Checked;
                musteri.koltukNo = txtKoltukNo.Text;
                Form1.KoltukDurum(musteri);
                this.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (pcb.Tag != null)
            {
                Musteri musteri = pcb.Tag as Musteri;
                txtAdSoyad.Text = musteri.adSoyad;
                txtTCNo.Text = musteri.TCNo;
                if (musteri.cinsiyet)
                {
                    rbBay.Checked = true;
                }
                else
                {
                    rbBayan.Checked = true;

                }
            }
        }

        private void BtnIptal_Click(object sender, EventArgs e)
        {
            DialogResult iptal = MessageBox.Show("Silmek istiyormusunuz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iptal == DialogResult.Yes)
            {
                pcb.Tag = null;
                Form1.KoltukDurum(pcb.Tag);
                this.Close();
            }
        }
    }
}
