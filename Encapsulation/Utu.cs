using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Utu
    {


        public string Marka { get; set; }
        public string Renk { get; set; }

        private int sicaklik;
        // diğer yöntem = public int Sicaklik { get => sicaklik; set => sicaklik = value; }

        public int Sicaklik // eski yöntem
        {
            get
            {
                return sicaklik;
            }
            set
            {
                sicaklik = value;
                // burada if(value > 100) gibi şeyler yapabilirsin
            }
        }

        public void Isin(int derece)
        {
            Sicaklik += derece;
        }
    }
}
