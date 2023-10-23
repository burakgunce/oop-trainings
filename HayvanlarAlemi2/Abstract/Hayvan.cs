using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanlarAlemi2.Abstract
{
    public abstract class Hayvan
    {
        public int Boy { get; set; }
        public int Kilo { get; set; }
        public string Yiyecek { get; set; }
        public string Cinsiyet { get; set; }
        public int Yas { get; set; }
    }
}
