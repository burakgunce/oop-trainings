namespace EnumSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen adını ogrenmek ıstedıgınız ay numarasını gırınız " +
                "(1-12 arası)");
            int ayNumarasi = int.Parse(Console.ReadLine());
            string secilenAy = Enum.GetName<Aylar>((Aylar)ayNumarasi).ToString();

            string secilenAy2 = Enum.GetName(typeof(Aylar), ayNumarasi).ToString(); //2. yol
            Console.WriteLine(secilenAy);
            Console.WriteLine(secilenAy2);

            int[] degerler = (int[])Enum.GetValues(typeof(Aylar));
            foreach (int item in degerler)
            {
                Console.WriteLine(item); // 1 den 12 ye kadar int olarak yazar
                Console.WriteLine(Enum.GetName(typeof(Aylar), item));

            }

            List<string> gunlerListesi = new List<string>(Enum.GetNames(typeof(Gunler)));
            foreach (string item in gunlerListesi)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(Gunler.Cuma.ToString());
            Console.WriteLine(Renkler.Kırmızı.ToString());

            Console.WriteLine(Renkler.SarıVeMavi.ToString());
            Console.WriteLine(EnumExtensions.GetDisplayName); // ismi yazmak için burda ekstra bir metod yazman lazım
        }
    }
}