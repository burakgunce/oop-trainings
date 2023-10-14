using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcHayvanliInterfaceAbstact.Abstract;

namespace UcHayvanliInterfaceAbstact
{
    public class Kedi : Hayvan, IKediKopekOrtak
    {
        public void Kos()
        {
            throw new NotImplementedException();
        }

        public void Tirman()
        {

        }
    }
}
