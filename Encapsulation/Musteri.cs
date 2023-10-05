using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Musteri
    {
        
        public string MusteriTipi { get; set; }

        public string MusteriTipiBelirle()
        {
            string tip = Console.ReadLine();
            MusteriTipi = (tip == "bireysel" ? "bireysel" : "ticari");
            return MusteriTipi;
        }
    }
}
