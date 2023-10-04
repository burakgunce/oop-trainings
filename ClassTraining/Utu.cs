using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTraining
{
    public class Utu
    {
        public Utu() 
        {
            Console.WriteLine("constructer çalıştı");
        }

        public Utu(string marka, string renk, int sicaklik, bool kazanliMi) 
        {
            Marka = marka;
            Renk = renk;
            Sicaklik = sicaklik;
            KazanliMi = kazanliMi;
            Console.WriteLine($"{Marka}   {Renk}");
        }
        
        public string Marka { get; set; }
        public string Renk { get; set; }
        public int Sicaklik { get; set; }
        public bool KazanliMi { get; set; }

        public void Isin(int derece)
        {
            Sicaklik += derece;
            Console.WriteLine($"Sıcaklık arttı şu anki sıcaklık : {Sicaklik}");
        }
    }
}
