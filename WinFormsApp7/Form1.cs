namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static List<Urun> uruns = new List<Urun>();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Urun urun = new Urun();
                urun.UrunId = int.Parse(textBox1.Text);
                urun.UrunAdi = textBox2.Text;
                urun.UrunAciklamasi = textBox3.Text;
                urun.UretimTarihi = dateTimePicker1.Value;
                urun.GarantiSuresi = dateTimePicker2.Value;

                bool kontrol = IsUrunIdExist(urun.UrunId);
                if (kontrol == true)
                {
                    MessageBox.Show("�r�n Id �nceki �r�n Id ile ayn� olamaz !!!");
                    return; // clean code i�in bunu dersen sonras�nda else demene gerek yok daha h�zl� �al���r.
                }
                uruns.Add(urun);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        public bool IsUrunIdExist(int urunId)
        {
            foreach (Urun urun in uruns)
            {
                if (urun.UrunId == urunId)
                {
                    return true;
                }
                
            }
            return false;
            
        }
    }
}