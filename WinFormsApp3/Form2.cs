using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        List<Musteri> musteriler = new List<Musteri>();

        private void button1_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.AdSoyad = textBox1.Text;
            musteri.Telefon = textBox2.Text;
            musteri.Yas = (int)numericUpDown1.Value;
            musteri.Adres = richTextBox1.Text;

            musteriler.Add(musteri);
            FormTemizle();

        }

        private void FormTemizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            numericUpDown1.Value = 0;
            richTextBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            Form1 form1 = new Form1(musteriler);
            //form1.ListeyeYazdir();
            form1.Refresh();
            this.Close();
            form1.Show();
            

        }
    }
}
