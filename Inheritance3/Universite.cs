using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance3
{
    public class Universite
    {
        public void DersAl(Ogrenci ogrenci)
        {
            Console.WriteLine($"{ogrenci.AdSoyad} ders aldı");
        }

        public void CalisanEvragiAl(Calisan calisan)
        {
            Console.WriteLine($"{calisan.AdSoyad} bu unıversıtede " +
                $"{calisan.IseGirisTarihi} tarihinden beri calısmaktadır");
        }
    }
}
