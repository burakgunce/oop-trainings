using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstract
{
    public class Helikopter : HavaTasiti, IHavaTasidiService
    {
        public int PervaneSayisi { get; set; }

        public void In()
        {
            throw new NotImplementedException();
        }

        public void MotoruCalistir()
        {
            throw new NotImplementedException();
        }

        public void Uc()
        {
            throw new NotImplementedException();
        }
    }
}
