using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanlarAlemi
{
    public class Kopek : Hayvan
    {
        public Kopek() : base("Kopek")
        {
            
        }

        public override void SesCikar()
        {
            Console.WriteLine("hav hav");
        }

        public void KulaklariniDik()
        {
            Console.WriteLine($"{Tur} kulakalrını dikiyor");
        }
    }
}
