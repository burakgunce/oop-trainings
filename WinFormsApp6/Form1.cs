using System.Media;
using WinFormsApp6.Concrete;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //private void playSimpleSound(string dosyaKonumu)
        //{
        //    SoundPlayer simpleSound = new SoundPlayer(dosyaKonumu);
        //    simpleSound.Play();
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            Default123 default123 = new Default123();
            default123.PlaySimpleSound();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nokia nokia = new Nokia();
            nokia.PlaySimpleSound();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IPhone iphone = new IPhone();
            iphone.PlaySimpleSound();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Samsung samsung = new Samsung();
            samsung.PlaySimpleSound();
        }
    }
}