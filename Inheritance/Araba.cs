using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Araba : Tasit
    {
        public Araba()
        {
            KapiSayisi = 4;
            TekerSayisi = 4;
            Id = 1;
        }

        public Araba(int id, int kapi)
        {
            Id = id;
            KapiSayisi = kapi;
        }

        public int KapiSayisi { get; set; }
    }
}
