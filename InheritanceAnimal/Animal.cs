using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAnimal
{
    public class Animal
    {
        public string Besin { get; set; }
        public string Barinak { get; set; }
        public string UykuSuresi { get; set; }

        public Animal()
        {
            Console.WriteLine("Animal olusturuldu");
        }
        protected void Uyu()
        {
            Console.WriteLine($"{UykuSuresi}  {Barinak} barınagında uyudu");
        }

        private void Beslen()
        {
            Console.WriteLine($"{Besin} ile beslendi");
        }

        public void BilgileriGoster() 
        {
            Beslen();
            Uyu();
        }
    }
}
