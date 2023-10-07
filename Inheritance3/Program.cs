namespace Inheritance3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci 
            { 
                AdSoyad = "Polat Alemdar"
            };

            Calisan calisan = new Calisan
            {
                AdSoyad = "Memati Baş",
                
               
            };
            Egitmen egitmen = new Egitmen();
            Guvenlik guvenlik = new Guvenlik();
            
            Universite uni = new Universite();
            uni.DersAl(ogrenci);
            uni.CalisanEvragiAl(egitmen);
            uni.CalisanEvragiAl(guvenlik);

            Belediye belediye = new Belediye();
            belediye.IkametgahAl(egitmen);
            belediye.IkametgahAl(ogrenci);
            belediye.IkametgahAl(guvenlik);

            List<Calisan> calisanlar = new List<Calisan>();
            calisanlar.Add(egitmen);
            calisanlar.Add(guvenlik);
            //calisanlar.Add(ogrenci);

            foreach (Calisan calisan2 in calisanlar)
            {
                Console.WriteLine($"{calisan2.AdSoyad}");
            }
        }
    }
}