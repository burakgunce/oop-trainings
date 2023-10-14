using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcHayvanliInterfaceAbstact.Abstract;

namespace UcHayvanliInterfaceAbstact
{
    public class Kopek : Hayvan, IKediKopekOrtak , IKopekYunusOrtak
    {
        public void Kos()
        {
            throw new NotImplementedException();
        }

        public void Oyna()
        {
            throw new NotImplementedException();
        }

        public override void Ye2()
        {
            Console.WriteLine("mama yendi");
        }

        public override void SesCikar2()
        {
            Console.WriteLine("hav hav");
        }
    }
}
