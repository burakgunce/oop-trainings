using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExample
{
    public class Urun
    {
        public static decimal Kdv = 0.18m;
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }

        // static bir metoddan o sınıfın varsa static olmayan hicbir uyesıne erısemezsınız
        public static void KdvyiArtır()
        {
            // Ad = "Elma" yapamazsın
            Kdv = 2;
        }

        // tüm uyeler static uyelere erısebılır.


    }
}
