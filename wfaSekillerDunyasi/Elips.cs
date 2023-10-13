using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaSekillerDunyasi
{
    public class Elips : Sekil
    {
        public Elips() : base("Elips") { }
        

        public double YariCap1 { get { return Genislik / 2d; } }
        public double YariCap2 { get { return Yukseklik / 2d; } } // prop yaricap2 => Yukseklik / 2 yapabilirsin sadece get metodu varsa


        public override double Alan()
        {
            return Math.PI * YariCap1 * YariCap2;
        }

        public override double Cevre()
        {
            return Math.PI * Math.Sqrt(2 * (Math.Pow(YariCap1, 2) + Math.Pow(YariCap2, 2)));
        }

        public override void Ciz(Graphics g)
        {
            Brush firca = new SolidBrush(Renk);
            g.FillEllipse(firca, X, Y, Genislik, Yukseklik);
        }
    }
}
