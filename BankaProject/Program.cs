using BankaProject.Abstract;
using BankaProject.Concrete;

namespace BankaProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Numarator numarator = new Numarator();

            List<Musteri> musteriler = new List<Musteri>();

            musteriler.Add(new Musteri { Tc = "12345", MusteriTipi = MusteriTipi.VIP });
            musteriler.Add(new Musteri { Tc = "67890", MusteriTipi = MusteriTipi.VIP });
            musteriler.Add(new Musteri { Tc = "11111", MusteriTipi = MusteriTipi.Gise });
            musteriler.Add(new Musteri { Tc = "22222", MusteriTipi = MusteriTipi.Gise });
            musteriler.Add(new Musteri { Tc = "33333", MusteriTipi = MusteriTipi.Bireysel });
            musteriler.Add(new Musteri { Tc = "44444", MusteriTipi = MusteriTipi.Bireysel });
            musteriler.Add(new Musteri { Tc = "55555", MusteriTipi = MusteriTipi.Gise });
            musteriler.Add(new Musteri { Tc = "66666", MusteriTipi = MusteriTipi.Gise });

            var siraliMusteriler = musteriler.OrderBy(m => m.MusteriTipi).ThenBy(m => m.Tc);

            foreach (var musteri in siraliMusteriler)
            {
                int siraNumarasi = numarator.SiraNumarasiVer(musteri);
                Console.WriteLine($"T.C. Kimlik No: {musteri.Tc}, Müşteri Tipi: {musteri.MusteriTipi}, Sıra Numarası: {siraNumarasi}");
            }

            Console.WriteLine("Toplam VIP İşlem Sayısı: " + numarator.ToplamVipIslemSayisi);
            Console.WriteLine("Toplam Bireysel İşlem Sayısı: " + numarator.ToplamBireyselIslemSayisi);
            Console.WriteLine("Toplam Gise İşlem Sayısı: " + numarator.ToplamGiseIslemSayisi);

            //List<Vip> vips = new List<Vip>();
            //List<Bireysel> bireysels = new List<Bireysel>();
            //List<Gise> gises = new List<Gise>();
            //List<Musteri> musteris = new List<Musteri>();
            //List<int> sayilar = new List<int>();

            //Numarator numarator = new Numarator();

            //Vip vip = new Vip();
            //vip.Tc = "777";
            //vip.SiraNo = numarator.SiraNumarasiVer(vip);
            //vips.Add(vip);
            //musteris.Add(vip);
            //sayilar.Add(vip.SiraNo);

            //Bireysel bireysel = new Bireysel();
            //bireysel.Tc = "991";
            //bireysel.SiraNo = numarator.SiraNumarasiVer(bireysel);
            //bireysels.Add(bireysel);
            //musteris.Add(bireysel);
            //sayilar.Add(bireysel.SiraNo);

            //Gise gise = new Gise();
            //gise.Tc = "881";
            //gise.SiraNo = numarator.SiraNumarasiVer(gise);
            //gises.Add(gise);
            //musteris.Add(gise);
            //sayilar.Add(gise.SiraNo);

            //Gise gise2 = new Gise();
            //gise2.Tc = "882";
            //gise2.SiraNo = numarator.SiraNumarasiVer(gise2);
            //gises.Add(gise2);
            //musteris.Add(gise2);
            //sayilar.Add(gise2.SiraNo);

            //Gise gise3 = new Gise();
            //gise3.Tc = "883";
            //gise3.SiraNo = numarator.SiraNumarasiVer(gise3);
            //gises.Add(gise3);
            //musteris.Add(gise3);
            //sayilar.Add(gise3.SiraNo);

            //Gise gise4 = new Gise();
            //gise4.Tc = "884";
            //gise4.SiraNo = numarator.SiraNumarasiVer(gise4);
            //gises.Add(gise4);
            //musteris.Add(gise4);
            //sayilar.Add(gise4.SiraNo);

            //Gise gise5 = new Gise();
            //gise5.Tc = "885";
            //gise5.SiraNo = numarator.SiraNumarasiVer(gise5);
            //gises.Add(gise5);
            //musteris.Add(gise5);
            //sayilar.Add(gise5.SiraNo);

            //Bireysel bireysel2 = new Bireysel();
            //bireysel2.Tc = "992";
            //bireysel2.SiraNo = numarator.SiraNumarasiVer(bireysel2);
            //bireysels.Add(bireysel2);
            //musteris.Add(bireysel2);
            //sayilar.Add(bireysel.SiraNo);

            //numarator.SiraNumaralariniAktar(musteris);
            //numarator.SiralamayiAyarla();

            //var sortedSayilar = Numarator.CustomSort(sayilar);

            //foreach (var sayi in sortedSayilar)
            //{
            //    Console.WriteLine(sayi);
            //}

        }
    }
}