using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaProject.Abstract
{
    public abstract class Musteri
    {
        public string Tc { get; set; }
        public int SiraNo { get; set; }
        public abstract bool OncelikDurumu { get; }
    }
}
