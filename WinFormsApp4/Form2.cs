using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form2 : Form
    {
        Kisi _kisi;
        public Form2(Kisi kisi)
        {
            _kisi = kisi;
            InitializeComponent();
            txtAd.Text = _kisi.Ad;
            txtSoyad.Text = _kisi.Soyad;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;

            if (ad == "" || soyad == "")
            {
                MessageBox.Show("ad soyad alanalrı zorunlu");
                return;
            }

            _kisi.Ad = ad;
            _kisi.Soyad = soyad;
            Close();
        }
    }
}
