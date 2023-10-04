namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car car1 = new Car();
            car1.Marka = textBox1.Text;
            car1.Model = textBox2.Text;
            car1.Yýl = (int)numericUpDown1.Value;
            car1.Renk = radioButton1.Checked ? "Sedefli Beyaz" : "Mat Siyah";
            car1.MotorHacmi = (int)numericUpDown2.Value;

            listBox1.Items.Add(car1.Marka);
            listBox1.Items.Add(car1.Model);
            listBox1.Items.Add(car1.Yýl);
            listBox1.Items.Add(car1.Renk);
            listBox1.Items.Add(car1.MotorHacmi);
        }
    }
}