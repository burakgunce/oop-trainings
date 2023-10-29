using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveciProject.Concrete
{
    public class Dukkan
    {
        public Dukkan()
        {
            Personeller = new List<Personel>();
        }
        public static List<Personel> Personeller { get; set; }
    }
}
