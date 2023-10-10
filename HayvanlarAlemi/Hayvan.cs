using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanlarAlemi
{
    public class Hayvan
    {
        public Hayvan() : this("Hayvan")
        {
            Tur = "Hayvan";
        }

        public Hayvan(string tur)
        {
            Tur = tur;
        }

        public string Tur { get; }

        public virtual void Beslen()
        {
            Console.WriteLine("{0} besleniyor", Tur);
        }
        public virtual void SesCikar()
        {
            Console.WriteLine("{0} ses çıkarıyor", Tur);
        }
        public virtual void HareketEt()
        {
            Console.WriteLine("{0} hareket ediyor", Tur);
        }

        public override string ToString()
        {
            return Tur;
        }

    }
}
