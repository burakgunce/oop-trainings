using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Faiz
    {
        public string FaizTuru { get; set; }
        public double FaizOrani { get; set; }

        public string FaizturuAl(string musteriTipi)
        {
            if (musteriTipi == "bireysel")
            {
                return FaizTuru = "bireysel";
            }
            else
            {
                return FaizTuru = "ticari";
            }
        }

        public double FaizOraniBelirle(string faizturu)
        {
            if (faizturu == "bireysel")
            {
                return FaizOrani = 2.96;
            }
            else
            {
                return FaizOrani = 0.98;
            }
        }

        public void OdenecekTutariHesapla(double faizOrani)
        {
            Console.WriteLine("Alacagınız para mıktarını gırın");
            double miktar = double.Parse(Console.ReadLine());
            double hesap = miktar * faizOrani;
            Console.WriteLine($"Odeyecegiiz tutar {miktar + hesap}");
        }
    }
}
