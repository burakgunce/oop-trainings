using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listBox1.Tag = Form1.uruns;

            foreach (Urun urun in Form1.uruns)
            {
                listBox1.Items.Add($"{urun.UrunId}  {urun.UrunAdi}  {urun.UrunAciklamasi}");
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                List<Urun> urunListesi = (List<Urun>)listBox1.Tag;
                int selectedIndex = listBox1.SelectedIndex; 
                if (selectedIndex >= 0 && selectedIndex < urunListesi.Count)
                {
                    Urun urun = urunListesi[selectedIndex]; 

                    string message = $"Ürün ID: {urun.UrunId}\nÜrün Adı: {urun.UrunAdi}\nÜretim Tarihi: {urun.UretimTarihi}\nGaranti Süresi: {urun.GarantiSuresi} gün";
                    MessageBox.Show(message, "Ürün Bilgileri");
                }
            }
        }
    }
}
