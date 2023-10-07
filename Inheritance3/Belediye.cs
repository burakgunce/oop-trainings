using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance3
{
    public class Belediye
    {
        public void IkametgahAl(Personel personel)
        {
            Console.WriteLine($"{personel.AdSoyad} ıkametgah aldı");
        }
    }
}
