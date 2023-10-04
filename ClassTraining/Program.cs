namespace ClassTraining
{
    public class Program
    {
        static void Main(string[] args)
        {
            //UtuNesnesi();

            //PersonelMaas();

            //FirinNesnesi();

            Calisan calisan1 = new Calisan("Burak");
            Console.WriteLine(calisan1.Ad);
            Console.WriteLine(calisan1.GoreveBaslamaTarihi);
            

        }

        private static void FirinNesnesi()
        {
            Firin firin1 = new Firin
            {
                Marka = "Phillips",
                Fiyat = 12000,
                Model = "7000Series",
                GarantiSüresi = 24,
                GarantiVarMi = true,
                Guc = 10000
            };

            firin1.GarantiSüresiniUzat(36);
            Console.WriteLine(firin1.GarantiSüresi);

            Firin firin2 = new Firin();
            Console.WriteLine(firin2.Marka);
        }

        private static void PersonelMaas()
        {
            Personel personel = new Personel();
            personel.Unvan = Console.ReadLine();
            personel.UnvanaGoreMaasBelirle(personel.Unvan);
            int cocukSayisi = int.Parse(Console.ReadLine());
            personel.MaasHesapla(cocukSayisi);
        }

        private static void UtuNesnesi()
        {
            Utu utu = new Utu();
            utu.Marka = "Rowenta";
            utu.Renk = "Beyaz";
            utu.KazanliMi = true;
            utu.Sicaklik = 0;

            string utuBilgileri = $"{utu.Marka}   {utu.Renk}   {(utu.KazanliMi ? "Var" : "Yok")} " +
                $"{utu.Sicaklik}";
            Console.WriteLine(utuBilgileri);

            Utu utu2 = new Utu("Arçelik", "Siyah", 0, true);

            Utu utu3 = new Utu("Arzum", "turuncu", 0, true);
            utu3.Isin(200);
        }
    }
}