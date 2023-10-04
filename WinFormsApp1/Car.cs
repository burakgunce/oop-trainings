using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Car
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Yıl { get; set; }
        public string Renk { get; set; }
        public int MotorHacmi { get; set; }

        public void BilgileriAl(string marka, string model, int yil, string renk, int motorHacmi)
        {
            Marka = marka;
            Model = model;
            Yıl = yil;
            Renk = renk;
            MotorHacmi = motorHacmi;
        }
    }

    
}
