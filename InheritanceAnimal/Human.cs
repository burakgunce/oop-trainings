using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAnimal
{
    public class Human : Animal
    {
        public string Adi { get; set; }
        public string Dusunce { get; set; }

        public Human(string ad)
        {
            Adi = ad;
            Console.WriteLine($"{Adi} olusturuldu");
        }

        public void Dusun()
        {
            Console.WriteLine($"{Adi}  {Dusunce} dusuncesini paylastı");
        }

        public void AsikOl(string kime)
        {
            Console.WriteLine($"{Adi}  {kime} asık oldu");
        }
    }
}
