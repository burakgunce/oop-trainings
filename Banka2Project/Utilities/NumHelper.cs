using Banka2Project.Abstract;
using Banka2Project.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka2Project.Utilities
{
    public class NumHelper
    {
        public int SiraNumarasiVer(Musteri musteri)
        {
            if (musteri.MusteriTipi == MusteriTipi.Vip)
            {
                Numarator.ToplamVipIslem++;
                return Numarator.VipSira++;
            }
            else if (musteri.MusteriTipi == MusteriTipi.Bireysel)
            {
                Numarator.ToplamBireyselIslem++;
                return Numarator.BireyselSira++;
            }
            else
            {
                Numarator.ToplamGiseIslem++;
                return Numarator.GiseSira++;
            }
        }


    }
}
