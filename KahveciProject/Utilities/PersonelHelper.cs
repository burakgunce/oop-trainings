using KahveciProject.Concrete;
using KahveciProject.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveciProject.Utilities
{
    public class PersonelHelper
    {
        public bool BosPersonelVarMi(List<Personel> personeller)
        {
            foreach (var personel in personeller)
            {
                if (personel.Durum == Durum.Musait)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
