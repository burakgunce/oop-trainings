using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrikSekil
{
    public class DikUcgen : GeometrikSekil
    {
        public override string AlanHesapla()
        {
            return $"{Genislik * Yukseklik / 2}";
        }

        public override void CevreHesapla()
        {
            double hipotenus = Math.Sqrt(Math.Pow(Genislik, 2) + Math.Pow(Yukseklik, 2));
            Console.WriteLine($"{hipotenus * 3}");
        }
    }
}
