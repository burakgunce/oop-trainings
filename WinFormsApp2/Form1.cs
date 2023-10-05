using System.Linq.Expressions;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Kullanici kullanici = new Kullanici();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                kullanici.Isim = textBox1.Text;
                kullanici.Soyisim = textBox2.Text;
                kullanici.Tc = textBox3.Text;
                kullanici.Email = textBox4.Text;
                MessageBox.Show("iþlem baþarýlý");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}