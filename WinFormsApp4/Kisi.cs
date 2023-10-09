using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    public class Kisi
    {
        public string Ad { get; set; } = null!; //null forgiving operator
        public string Soyad { get; set; } = ""; //default deger atama

        public override string ToString()
        {
            return Ad + " " + Soyad; // object classında virtual method olarak yazıldıgı ıcın ezıyoruz 2. yontem bu
        }
    }
}
