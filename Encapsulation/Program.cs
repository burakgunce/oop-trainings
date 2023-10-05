namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UtuNesnesi();

            //OgrenciNesnesi();

            //FaizHesaplama();

            //Calisan calisan = new Calisan(17);

            //KediCinsi();



        }

        private static void KediCinsi()
        {
            Kedi kedi = new Kedi("tekir");
            //kedi.Cins = "asdasd";
        }

        private static void FaizHesaplama()
        {
            Musteri musteri = new Musteri();
            Faiz faiz = new Faiz();
            Console.WriteLine("musterı tıpı gır");
            string tip = musteri.MusteriTipiBelirle();
            string faizTuru = faiz.FaizturuAl(tip);
            double faizOrani = faiz.FaizOraniBelirle(faizTuru);
            faiz.OdenecekTutariHesapla(faizOrani);
        }

        private static void OgrenciNesnesi()
        {
            Ogrenci ogrenci = new Ogrenci
            {
                Adi = "John",
                Soyadi = "Doe",
                Sinifi = "203",
                DogumTarihi = new DateTime(2000, 3, 23),
                //Yas = 10; set metodu yazılmadıgı ıcın bu prop salt okunur

            };
            //YasHesapla(); bu metod private olarak tanımlandıgı ıcın cagrılamaz
            ogrenci.OgrenciBilgileriYaz();
            Console.ReadLine();
        }

        private static void UtuNesnesi()
        {
            Utu utu = new Utu() // () yazsanda olur yazmasanda
            {
                Marka = "tefal",
                Renk = "Mavi",
                Sicaklik = 0
            };

            Utu utu2 = new Utu();
            utu2.Marka = "Arçelik";
            utu2.Renk = "Siyah";
            utu2.Sicaklik = 10;

            for (int i = 0; i < 10; i++)
            {
                utu2.Isin(10);
                Console.WriteLine($"Şuan ki sıcaklık = {utu2.Sicaklik}");
            }
        }
    }
}