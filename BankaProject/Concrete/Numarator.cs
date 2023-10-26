using BankaProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaProject.Concrete
{
    public class Numarator
    {
        public int VipSira { get; private set; } = 100;
        public int BireyselSira { get; private set; } = 300;
        public int GiseSira { get; private set; } = 200;
        //public int GiseMusteriSayisi { get; private set; } = 0;

        public int ToplamMusteri { get; private set; } = 0;

        public int SiraNumarasiVer(Musteri musteri)
        {
            if (musteri.OncelikDurumu)
            {
                VipSira++;
                ToplamMusteri++;
                return VipSira;
            }
            else
            {
                if (musteri is Bireysel)
                {
                    BireyselSira++;
                    ToplamMusteri++;
                    return BireyselSira;
                }
                else
                {
                   GiseSira++;
                   ToplamMusteri++;
                   return GiseSira;
                }
            }
        }

        List<int> siralar = new List<int>();
        public void SiraNumaralariniAktar(List<Musteri> musteris)
        {

            //List<Vip> vips, List< Bireysel > bireysels, List<Gise> gises,
            foreach (Musteri musteri in musteris)
            {
                siralar.Add(musteri.SiraNo);
                siralar.Sort();
            }

        }

        public void SiralamayiAyarla()
        {
            
            
            //var sortedSayilar = siralar.OrderBy(s => s.ToString()[0]).ThenBy(s => s).ToList();

            //foreach (var sayi in sortedSayilar)
            //{
            //    Console.WriteLine(sayi);
            //}

            //Comparison<int> customComparison = (x, y) =>
            //{
            //    int xPriority = GetPriority(x);
            //    int yPriority = GetPriority(y);

            //    if (xPriority == yPriority)
            //    {
            //        if (xPriority == 2)
            //        {
            //            int xNormalOrder = GetNormalOrder(x);
            //            int yNormalOrder = GetNormalOrder(y);
            //            return xNormalOrder.CompareTo(yNormalOrder);
            //        }
            //        return x.CompareTo(y);
            //    }
            //    return xPriority.CompareTo(yPriority);
            //};

            //siralar.Sort(customComparison);

            //foreach (var sayi in siralar)
            //{
            //    Console.WriteLine(sayi);
            //}
        }

        //static int GetPriority(int number)
        //{
        //    int firstDigit = number / 100;
        //    if (firstDigit == 1)
        //        return 1; // Vip
        //    else if (firstDigit == 2)
        //        return 2; // Normal
        //    else if (firstDigit == 3)
        //        return 3; // Bireysel
        //    else
        //        return 4; // Diğer
        //}


        //static int GetNormalOrder(int number)
        //{
        //    return number;
        //}

        //GiseSira++;
        //            ToplamMusteri++;
        //            GiseMusteriSayisi++;

        //            // Her üç gişe müşterisinden sonra bir bireysel için sıra no verme
        //            if (GiseMusteriSayisi % 3 == 0)
        //            {
        //                BireyselSira++;
        //                return BireyselSira;
        //            }
        //            else
        //            {
        //                return GiseSira;
        //            }


        //public Musteri SiradakiMusteriyiBelirle()
        //{
        //    if (GiseMusteriSayisi % 3 == 0)
        //    {
        //        var bireyselMusteri = new Bireysel();
        //        bireyselMusteri.SiraNo = SiraNumarasiVer(bireyselMusteri);
        //        return bireyselMusteri;
        //    }
        //    else
        //    {
        //        var giseMusteri = new Gise();
        //        giseMusteri.SiraNo = SiraNumarasiVer(giseMusteri);
        //        return giseMusteri;
        //    }
        //}


    }
}
