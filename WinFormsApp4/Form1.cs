using System.Security.Cryptography;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        List<Kisi> kisiler;
        public Form1()
        {
            InitializeComponent();
            OrnekVerileriYukle();
            KisileriListele();
        }

        private void KisileriListele()
        {
            listBox1.Items.Clear();
            foreach (Kisi kisi in kisiler)
            {
                listBox1.Items.Add(kisi);
            }
        }

        private void OrnekVerileriYukle()
        {
            kisiler = new List<Kisi>()
            {
                new Kisi() { Ad = "Polat" , Soyad = "Alemdar" },
                new Kisi() { Ad = "Memati" , Soyad = "Ba�" },
                new Kisi() { Ad = "Seyfullah" , Soyad = "Y�rdem" },
                new Kisi() { Ad = "Laz" , Soyad = "Ziya" }
            };

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            if (txtAd.Text == "" || txtSoyad.Text == "")
            {
                MessageBox.Show("isim soy isim bo� olmamal�d�r");
            }
            else
            {
                Kisi kisi = new Kisi();
                kisi.Ad = txtAd.Text;
                kisi.Soyad = txtSoyad.Text;

                kisiler.Add(kisi);
                KisileriListele();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Kisi silinecekKisi = (Kisi)listBox1.SelectedItem;
                kisiler.Remove(silinecekKisi);
                KisileriListele();
                // return;  void metod olsa bile direk koddan c�kmak �c�n kullanab�l�yoruz. bundan sonra else yazmadan direk mevcut
                // kodu yazab�l�rs�n
            }
            else
            {
                MessageBox.Show("silmek i�in oge sec�n");

            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems == null)
            {
                MessageBox.Show("duzenlemek �c�n oge sec�n");
                return;
            }

            Kisi kisi = (Kisi)listBox1.SelectedItem;
            Form2 form2 = new Form2(kisi);
            form2.ShowDialog();
            KisileriListele();
            listBox1.SelectedItem = kisi;
        }

        private void btnYukari_Click(object sender, EventArgs e)
        {
            int sid = listBox1.SelectedIndex; // sid selectec index
            if (sid < 1) return;

            SeciliKisiyiTasi(sid - 1);
        }

        private void btnAsagi_Click(object sender, EventArgs e)
        {
            int sid = listBox1.SelectedIndex; // sid selectec index
            if (sid < 0 || sid == kisiler.Count - 1) return;

            SeciliKisiyiTasi(sid + 1);
        }

        private void SeciliKisiyiTasi(int yeniIndex)
        {
            Kisi secilenKisi = (Kisi)listBox1.SelectedItem;
            kisiler.Remove(secilenKisi);
            kisiler.Insert(yeniIndex, secilenKisi);
            KisileriListele();
            listBox1.SelectedIndex = yeniIndex;
        }
    }
}