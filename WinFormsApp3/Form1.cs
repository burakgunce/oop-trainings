using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ListeyeYazdir();


        }

        List<Musteri> _musteriler = new List<Musteri>();

        public Form1(List<Musteri> musteri) : this()
        {

            _musteriler = musteri;
            //foreach (var item in _musteriler)
            //{
            //    listBox1.Items.Add(item.AdSoyad);
            //}

        }


        private void button1_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            form2.ShowDialog();




        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            string secilenAdSoyad = listBox1.SelectedItem as string;

            if (secilenAdSoyad != null)
            {
                // Seçilen müþterinin bilgilerini bulun
                Musteri secilenMusteri = _musteriler.FirstOrDefault(m => m.AdSoyad == secilenAdSoyad);

                if (secilenMusteri != null)
                {
                    // Müþteri bilgilerini MessageBox ile göster
                    string musteriBilgileri = $"Ad Soyad: {secilenMusteri.AdSoyad}\n" +
                                              $"Telefon: {secilenMusteri.Telefon}\n" +
                                              $"Yaþ: {secilenMusteri.Yas}\n" +
                                              $"Adres: {secilenMusteri.Adres}";

                    MessageBox.Show(musteriBilgileri);
                }
            }
        }

        public void ListeyeYazdir()
        {
            foreach (Musteri item in _musteriler)
            {
                listBox1.Items.Add(item.AdSoyad);
            }
            listBox1.Items.AddRange(_musteriler.ToArray());
        }
    }
}