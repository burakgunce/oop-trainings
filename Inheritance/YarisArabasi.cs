using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class YarisArabasi : Araba
    {
        public YarisArabasi(int kapi = 4)
        {
            KapiSayisi = kapi;
        }
        public YarisArabasi(int id, int kapi = 2) : base(id, kapi) // bu classın base classındaki 2 parametreli constructar ı calıstırmak ıcın
        {
            Id = id;
            TekerSayisi = 4;
            KapiSayisi = kapi;
        }
    }
}
