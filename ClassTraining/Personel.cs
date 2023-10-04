using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTraining
{
    public class Personel
    {
        public decimal Maas { get; set; }
        public string Unvan { get; set; }
        public int CocukSayisi { get; set; }

        public decimal UnvanaGoreMaasBelirle(string unvan)
        {
            if (unvan == "çaycı")
            {
                Maas = 5000;
                return Maas;   
            }
            else
            {
                return Maas = 4000;
            }
        }
        public void MaasHesapla(int cocukSayisi)
        {
            if (cocukSayisi >= 3)
            {
                Maas += 1000;
                Console.WriteLine(Maas);
            }
            else
            {
                Console.WriteLine(Maas);
            }
        }
    }
}
