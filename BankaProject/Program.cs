using BankaProject.Abstract;
using BankaProject.Concrete;

namespace BankaProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Vip> vips = new List<Vip>();
            List<Bireysel> bireysels = new List<Bireysel>();
            List<Gise> gises = new List<Gise>();
            List<Musteri> musteris = new List<Musteri>();
            
            Numarator numarator = new Numarator();

            Vip vip = new Vip();
            vip.Tc = "777";
            vip.SiraNo = numarator.SiraNumarasiVer(vip);
            vips.Add(vip);
            musteris.Add(vip);

            Bireysel bireysel = new Bireysel();
            bireysel.Tc = "991";
            bireysel.SiraNo = numarator.SiraNumarasiVer(bireysel);
            bireysels.Add(bireysel);
            musteris.Add(bireysel);

            Gise gise = new Gise();
            gise.Tc = "881";
            gise.SiraNo = numarator.SiraNumarasiVer(gise);
            gises.Add(gise);
            musteris.Add(gise);

            Gise gise2 = new Gise();
            gise2.Tc = "882";
            gise2.SiraNo = numarator.SiraNumarasiVer(gise2);
            gises.Add(gise2);
            musteris.Add(gise2);

            Gise gise3 = new Gise();
            gise3.Tc = "883";
            gise3.SiraNo = numarator.SiraNumarasiVer(gise3);
            gises.Add(gise3);
            musteris.Add(gise3);

            Gise gise4 = new Gise();
            gise4.Tc = "884";
            gise4.SiraNo = numarator.SiraNumarasiVer(gise4);
            gises.Add(gise4);
            musteris.Add(gise4);

            Gise gise5 = new Gise();
            gise5.Tc = "885";
            gise5.SiraNo = numarator.SiraNumarasiVer(gise5);
            gises.Add(gise5);
            musteris.Add(gise5);

            Bireysel bireysel2 = new Bireysel();
            bireysel2.Tc = "992";
            bireysel2.SiraNo = numarator.SiraNumarasiVer(bireysel2);
            bireysels.Add(bireysel2);
            musteris.Add(bireysel2);

            numarator.SiraNumaralariniAktar(musteris);
            numarator.SiralamayiAyarla();



        }
    }
}