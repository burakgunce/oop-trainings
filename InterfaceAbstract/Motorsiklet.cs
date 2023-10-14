using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstract
{
    public class Motorsiklet : KaraTasiti, IKaraTasidiService
    {
        public void FrenYap()
        {
            throw new NotImplementedException();
        }

        public void Hizlan()
        {
            throw new NotImplementedException();
        }

        public void MotoruCalistir()
        {
            throw new NotImplementedException();
        }
    }
}
