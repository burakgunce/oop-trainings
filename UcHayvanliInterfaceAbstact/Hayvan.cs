using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcHayvanliInterfaceAbstact
{
    public abstract class Hayvan
    {
        

        public int Id { get; set; }
        public string Isim { get; set; }
        public int Yas { get; set; }

        public virtual void SesCikar2()
        {
            Console.WriteLine("Ses");
        }

        public abstract void Ye2();
        
    }
}
