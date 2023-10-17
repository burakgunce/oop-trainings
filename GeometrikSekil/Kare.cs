using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrikSekil
{
    public class Kare : GeometrikSekil
    {
        public Kare(double kenar) 
        {
            Genislik = Yukseklik = kenar;
        }   
        public override string AlanHesapla()
        {
            return $"Karenin alanı  {Math.Pow(Genislik, 2)}   ";
        }

        public override void CevreHesapla()
        {
            Console.WriteLine($"Karenin Çevresi  {4*Genislik}");
        }
    }
}
