using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Tasit
    {
        public Tasit()
        {
            this.MaximumHiz = 200;
        }

        public int Id { get; set; }
        public int Kapasite { get; set; }
        private int MaximumHiz { get; set; }
        protected int TekerSayisi { get; set; }
    }
}
