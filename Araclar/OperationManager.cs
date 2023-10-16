using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araclar
{
    public class OperationManager : IOperation
    {
        IOperation _op;
        public OperationManager(IOperation op)
        {
            _op = op;
        }
        public void YakıtTipi()
        {
            _op.YakıtTipi();
        }
    }
}
