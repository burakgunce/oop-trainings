using KahveciProject.Abstract;
using KahveciProject.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveciProject.Concrete
{
    public class Siparis
    {
        public Siparis()
        {
            Kahveler = new List<Kahve>();
            Suruplar = new List<Surup>();
        }

        public static List<Kahve> Kahveler { get; set; }
        public static List<Surup> Suruplar { get; set; }
    }
}
