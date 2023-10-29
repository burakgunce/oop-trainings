using KahveciProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveciProject.Concrete
{
    public class Musteri : Kisi
    {
        public Kahve SiparisVer(Kahve kahve)
        {
            return kahve;
            //Console.WriteLine(kahve.KahveAdi + "siparişi alındı");
        }
    }
}
