using KahveciProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveciProject.Concrete
{
    public class FiltreKahve : Kahve
    {
        decimal _fiyat = 70;
        public override decimal Fiyat { get => _fiyat; }

        //public string KahveAdi { get; set; } = "Filtre Kahve";

        string _ad = "Filtre Kahve";
        public override string KahveAdi => _ad;
    }   
}
