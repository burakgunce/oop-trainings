using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        List<Ogrenci> ogrenciler = new List<Ogrenci>();
        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = textBox1.Text;
            ogrenci.Soyad = textBox2.Text;
            ogrenci.Email = textBox3.Text;
            ogrenci.Telefon = textBox4.Text;
            ogrenci.Yas = (int)numericUpDown1.Value;
            ogrenci.Cinsiyet = radioButton1.Checked ? "Erkek" : "Kadın";
            ogrenci.Egitim = comboBox1.ValueMember;

            //string bilgiler = $"{ogrenci.Ad}-{ogrenci.Soyad}-{ogrenci.Email}-" +
            //    $"{ogrenci.Telefon}-{ogrenci.Yas}-{ogrenci.Cinsiyet}-{ogrenci.Egitim}";

            ogrenciler.Add(ogrenci);
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = control as TextBox;
                    textBox.Text = string.Empty;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Ogrenci ogrenci in ogrenciler)
            {
                listBox1.Items.Add($"{ogrenci.Ad}-{ogrenci.Soyad}-{ogrenci.Email}-" +
                    $"{ogrenci.Telefon}-{ogrenci.Yas}-{ogrenci.Cinsiyet}-{ogrenci.Egitim}");
            }
        }
    }
}
