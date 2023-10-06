namespace InheritancePersonel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HumanResources hr = new HumanResources
                ("John Doe", new DateTime(2000, 09, 23), false, 65, 170, true, false, 15000, false, false, true);
            Console.ReadLine();
        }
    }
}