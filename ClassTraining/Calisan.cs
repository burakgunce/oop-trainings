using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTraining
{
    public class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime GoreveBaslamaTarihi { get; set; }
        public string Departman { get; set; }
        public string SicilNo { get; set; }

        public Calisan()
        {
            GoreveBaslamaTarihi = DateTime.Now;
        }

        public Calisan(string ad) : this()
        {
            Ad = ad;
        }
    }

    
}
