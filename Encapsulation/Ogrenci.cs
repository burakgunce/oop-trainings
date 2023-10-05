using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Ogrenci
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Sinifi { get; set; }
        private DateTime dogumTarihi;

        public DateTime DogumTarihi
        {
            get { return dogumTarihi; }
            set 
            { 
                dogumTarihi = value;
                yas = DateTime.Now.Year - DogumTarihi.Year;
                // YasHesapla();
            }
        }
        
        private int yas;
        public int Yas
        {
            get { return yas; }
        }

        private void YasHesapla()
        {
            yas = DateTime.Now.Year - DogumTarihi.Year ;
        }

        public void OgrenciBilgileriYaz()
        {
            Console.WriteLine($"{Sinifi} sınıfında bulunan {Adi} {Soyadi} isimli ogrencının yası : {Yas}");
        }
    }
}
