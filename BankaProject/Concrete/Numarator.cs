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
        private int VipSira = 100;
        private int BireyselSira = 300;
        private int GiseSira = 200;
        private int ToplamVipIslem = 0;
        private int ToplamBireyselIslem = 0;
        private int ToplamGiseIslem = 0;

        public int SiraNumarasiVer(Musteri musteri)
        {
            if (musteri.MusteriTipi == MusteriTipi.VIP)
            {
                ToplamVipIslem++;
                return VipSira++;
            }
            else if (musteri.MusteriTipi == MusteriTipi.Bireysel)
            {
                ToplamBireyselIslem++;
                if (ToplamGiseIslem % 3 == 0)
                    return BireyselSira++;
                else
                    return GiseSira++;
            }
            else
            {
                ToplamGiseIslem++;
                return GiseSira++;
            }
        }

        public int ToplamVipIslemSayisi => ToplamVipIslem;
        public int ToplamBireyselIslemSayisi => ToplamBireyselIslem;
        public int ToplamGiseIslemSayisi => ToplamGiseIslem;

        //public int VipSira { get; private set; } = 100;
        //public int BireyselSira { get; private set; } = 300;
        //public int GiseSira { get; private set; } = 200;
        ////public int GiseMusteriSayisi { get; private set; } = 0;

        //public int ToplamMusteri { get; private set; } = 0;

        //public int SiraNumarasiVer(Musteri musteri)
        //{
        //    if (musteri.OncelikDurumu)
        //    {
        //        VipSira++;
        //        ToplamMusteri++;
        //        return VipSira;
        //    }
        //    else
        //    {
        //        if (musteri is Bireysel)
        //        {
        //            BireyselSira++;
        //            ToplamMusteri++;
        //            return BireyselSira;
        //        }
        //        else
        //        {
        //           GiseSira++;
        //           ToplamMusteri++;
        //           return GiseSira;
        //        }
        //    }
        //}

        //List<int> siralar = new List<int>();
        //public void SiraNumaralariniAktar(List<Musteri> musteris)
        //{

        //    //List<Vip> vips, List< Bireysel > bireysels, List<Gise> gises,
        //    foreach (Musteri musteri in musteris)
        //    {
        //        siralar.Add(musteri.SiraNo);
        //        siralar.Sort();
        //    }

        //}

        //public static List<int> CustomSort(List<int> sayilar)
        //{
        //    List<int> sortedList = new List<int>();
        //    List<int> normalNumbers = new List<int>();
        //    int normalCount = 0;

        //    foreach (var sayi in sayilar)
        //    {
        //        if (sayi >= 300)
        //        {
        //            sortedList.Add(sayi);
        //        }
        //        else
        //        {
        //            normalNumbers.Add(sayi);
        //            normalCount++;

        //            if (normalCount == 3)
        //            {
        //                sortedList.AddRange(normalNumbers);
        //                normalNumbers.Clear();
        //                normalCount = 0;
        //            }
        //        }
        //    }

        //    // Normal sayıları son ekleyin
        //    sortedList.AddRange(normalNumbers);

        //    return sortedList;
        //}

        //public void SiralamayiAyarla()
        //{
        //for (int i = 0; i < siralar.Count; i++)
        //{
        //    int firstdigit = siralar[i]/100;
        //    int firstdigit2 = siralar[i+1]/100;
        //    int firstdigit3 = siralar[i+2]/100;
        //    int firstdigit4 = siralar[i+3]/100;
        //    if (firstdigit == 2 && firstdigit2 == 2 && firstdigit3 == 2 && firstdigit4 == 2)
        //    {
        //        foreach (var item in siralar)
        //        {
        //            if (item / 100 == 3)
        //            {

        //            }
        //        }
        //    }
        //}

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
        //}

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
