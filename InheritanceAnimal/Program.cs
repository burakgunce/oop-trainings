namespace InheritanceAnimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bear bear = new Bear()
            {
                Barinak = "Magara",
                Besin = "Bal",
                UykuSuresi = "6 ay"
            };

            bear.BilgileriGoster();
            Console.ReadLine();

            Monkey monkey = new Monkey();
            monkey.Barinak = "Agac";
            monkey.Besin = "Muz";
            monkey.UykuSuresi = "12 Saat";
            monkey.BilgileriGoster();
            Console.ReadLine();


            Human human = new Human("John Doe")
            {
                Barinak = "Ev",
                Besin = "sebze et meyve",
                UykuSuresi = "8 saat",
                Dusunce = "Bilgisayar Fiyatları"
            };

            human.BilgileriGoster();
            human.Dusun();
            human.AsikOl("Jeyn Doe");
            Console.ReadLine();

        }
    }
}