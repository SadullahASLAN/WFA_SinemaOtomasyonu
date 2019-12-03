using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_SinemaOtomasyonu
{
    public class Musteri
    {
        public string adSoyad { get; set; }

        private string _tcNo;
        public string TCNo
        {
            get { return _tcNo; }
            set
            {
                if (value.Length != 11)
                {
                    throw new Exception();
                }
                _tcNo = value;
            }
        }
        public bool cinsiyet { get; set; }
        public string koltukNo { get; set; }
    }
}
