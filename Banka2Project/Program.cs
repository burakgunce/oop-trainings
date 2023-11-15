using Banka2Project.Abstract;
using Banka2Project.Utilities;

namespace Banka2Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> siraNumaralari = new List<int>();
            List<int> vipSiralar = new List<int>();
            List<int> bireyselSiralar = new List<int>();
            List<int> giseSiralar = new List<int>();

            NumHelper numHelper = new NumHelper();
            Musteri musteri1 = new Musteri();
            musteri1.Tc = "12345678";
            numHelper.SiraNumarasiVer(musteri1);

            Musteri musteri2 = new Musteri();
        }
    }
}