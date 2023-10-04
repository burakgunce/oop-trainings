using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTraining
{
    public class Firin
    {
        public Firin()
        {
            Marka = "Sony";
            Model = "Xperia";
        }

        
        public string Marka { get; set; }
        public double Fiyat { get; set; }
        public string Model { get; set; }
        public int GarantiSüresi { get; set; }
        public bool GarantiVarMi { get; set; }
        public int MaxDerece { get; set; }
        public int Guc { get; set; }

        public void GarantiSüresiniUzat(int ay)
        {
            GarantiSüresi += ay;
        }
    }
}
