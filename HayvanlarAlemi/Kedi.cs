using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanlarAlemi
{
    public class Kedi : Hayvan
    {
        public Kedi() : base("Kedi")
        {
            
        }

        public override void SesCikar()
        {
            Console.WriteLine("miyav miyav");
        }
    }
}
