using System.Security.Cryptography;
using System.Text.Json;

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

        private void VerileriOku()
        {
            try
            {
                string json = File.ReadAllText("veri.json");
                kisiler = JsonSerializer.Deserialize<List<Kisi>>(json);
            }
            catch (Exception)
            {

                OrnekVerileriYukle();
            }
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
                new Kisi() { Ad = "Memati" , Soyad = "Baþ" },
                new Kisi() { Ad = "Seyfullah" , Soyad = "Yördem" },
                new Kisi() { Ad = "Laz" , Soyad = "Ziya" }
            };

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            if (txtAd.Text == "" || txtSoyad.Text == "")
            {
                MessageBox.Show("isim soy isim boþ olmamalýdýr");
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
                int sid = listBox1.SelectedIndex;
                DialogResult cevap = MessageBox.Show("silmek istediginze emin misiniz ?", "Silme Onayý", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (cevap == DialogResult.Yes)
                {
                    Kisi silinecekKisi = (Kisi)listBox1.SelectedItem;
                    kisiler.Remove(silinecekKisi);
                    KisileriListele();
                    listBox1.SelectedIndex = Math.Min(sid, listBox1.Items.Count - 1); // en sonuncuyu secýnce uygulama patlamasýn dýye
                }

                // return;  void metod olsa bile direk koddan cýkmak ýcýn kullanabýlýyoruz. bundan sonra else yazmadan direk mevcut
                // kodu yazabýlýrsýn
            }
            else
            {
                MessageBox.Show("silmek için oge secýn");

            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems == null)
            {
                MessageBox.Show("duzenlemek ýcýn oge secýn");
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

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (listBox1.SelectedIndex > -1 && e.KeyCode == Keys.Delete)
            {
                btnSil.PerformClick();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //kisiler listesini serilize et ve kaydet
            string json = JsonSerializer.Serialize(kisiler);
            File.WriteAllText("veri.json", json);
        }

    }
}