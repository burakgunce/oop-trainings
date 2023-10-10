namespace HayvanlarAlemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hayvan h1 = new Hayvan("kedi");
            h1.Beslen();
            h1.SesCikar();
            h1.HareketEt();

            Kedi ke1 = new Kedi();
            ke1.Beslen();
            ke1.SesCikar();
            ke1.HareketEt();
        }
    }
}