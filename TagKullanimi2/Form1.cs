namespace TagKullanimi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Car> cars = new List<Car>();
        private void Form1_Load(object sender, EventArgs e)
        {
            Car car1 = new Car();
            car1.Brand = "BMW";
            car1.Model = "M4";
            car1.EnginePower = 2000;

            Car car2 = new Car();
            car2.Brand = "Mercedes";
            car2.Model = "AMG";
            car2.EnginePower = 2300;

            CheckBox cb1 = new CheckBox();
            cb1.Text = car1.Brand;
            cb1.Tag = car1;

            CheckBox cb2 = new CheckBox();
            cb2.Text = car2.Brand;
            cb2.Tag = car2;

            flowLayoutPanel1.Controls.Add(cb1);
            flowLayoutPanel1.Controls.Add(cb2);




        }

        private void button1_Click(object sender, EventArgs e)
        {
            cars.Clear();
            foreach (CheckBox cbox in flowLayoutPanel1.Controls)
            {
                if (cbox.Checked)
                {
                    Car car = (Car)cbox.Tag;
                    cars.Add(car);
                }

            }
        }
    }
}