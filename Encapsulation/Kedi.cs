using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Kedi
    {
        public string Adi { get; set; }
        public string Sahibi { get; set; }
        public string Cins { get; }
        public string Cinsiyet { get; set; }
        public int Yas { get; set; }

        public Kedi(string cins)
        {
            Cins = cins;
        }
        public Kedi()
        {
            
        }
    }
}
