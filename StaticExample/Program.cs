namespace StaticExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun u1 = new Urun() { Ad = "tshirt", Fiyat = 500 };
            Urun u2 = new Urun() { Ad = "gomlek", Fiyat = 700 };
            // urun sınıfı ıcerısınde her bır orun ornegı ıcın bellkete ayrı ayrı tanımlanan ad gıbı ozellıkler
            // statık olmayan yanı non statıc uyelerdır.

            //Console.WriteLine(u1.Kdv);  static uyeler ornekler uzerınden erısılemez
            Console.WriteLine(Urun.Kdv); // sadece classın referansı ıle cagırılabılır

            //statık sınıflar ıse uyelerının tamamı statık olan sınıflardır oprnek math kutuphanesı
            //Math mat = new Math() olusturamazsın
            // statık sınıfların orneklerını olusturamazsın

            double islem = DortIslem.Topla(61,53);

            // static bir metoddan o sınıfın varsa static olmayan hicbir uyesıne erısemezsınız
            //
        }
    }
}