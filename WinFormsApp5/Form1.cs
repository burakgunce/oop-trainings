namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> asalSayilar = new List<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            asalSayilar.Clear();

            for (int i = 2; i <= numericUpDown1.Value; i++)
            {
                if (AsalMi(i) == true)
                {
                    asalSayilar.Add(i);
                }
            }

            listBox1.Items.Clear();

            foreach (int asalSayi in asalSayilar)
            {
                listBox1.Items.Add(asalSayi);
            }
        }

        private bool AsalMi(int sayi)
        {
            if (sayi <= 1)
            {
                return false;
            }

            for (int i = 2; i * i <= sayi; i++)
            {
                if (sayi % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}