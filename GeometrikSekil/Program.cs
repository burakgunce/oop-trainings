namespace GeometrikSekil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kare _kare = new Kare(18);
            _kare.CevreHesapla();
            Console.WriteLine(_kare.AlanHesapla());

            DikUcgen _dikUcgen = new DikUcgen();
            _dikUcgen.Genislik = 12;
            _dikUcgen.Yukseklik = 14;
            _dikUcgen.CevreHesapla();
            Console.WriteLine(_dikUcgen.AlanHesapla());
        }
    }
}