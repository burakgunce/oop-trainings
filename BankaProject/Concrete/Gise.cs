using BankaProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaProject.Concrete
{
    public class Gise : Musteri
    {
        public override bool OncelikDurumu { get { return false; } }
    }
}
