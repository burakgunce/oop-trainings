using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public decimal Maas { get; set; }
        private int _yas;
        public int Yas
        {
            get
            {
                return _yas;
            }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("yaşınız 18 den kucuk olamaz");
                }
                else
                {
                    _yas = value;
                }
            }
        }

        public Calisan(int yas)
        {
            Yas = yas;
        }
        public Calisan()
        {
            
        }
    }
}
