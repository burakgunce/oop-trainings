using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveciProject.Abstract
{
    public abstract class Kahve
    {
        public abstract string KahveAdi { get; }
        public abstract decimal Fiyat { get; }
        
    }
}
