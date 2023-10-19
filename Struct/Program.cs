namespace Struct
{
    public class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////////////////////////
            //Structlar stack te tutuldugu ıcın 2. ornekte aynı seylerı yazmıcak aslında
            //kopyasıyla iş yapmış oldun
            MyClass myClass = new MyClass();
            myClass.a = 3;
            myClass.b = 4;
            MyClass myClass2 = myClass;
            myClass2.a = 5;
            myClass2.b = 6;
            Console.WriteLine($"{myClass.a}{myClass.b}{myClass2.a}{myClass2.b}");

            MyStruct myStruct = new MyStruct();
            myStruct.a = 1;
            myStruct.b = 2;
            MyStruct myStruct2 = myStruct;
            myStruct2.a = 3;
            myStruct2.b = 4;
            Console.WriteLine($"{myStruct.a}{myStruct.b}{myStruct2.a}{myStruct2.b}");
            
            /////////////////////////////////////////////////////////////
            
            MyStruct4 myStruct4 = new MyStruct4();
            myStruct4.x = 3;
            myStruct4.y = true;
            myStruct4.z = "3";
            Console.WriteLine($"{myStruct4.x}");
            Console.WriteLine($"{myStruct4.y}");
            Console.WriteLine($"{myStruct4.z}");
            Console.WriteLine(myStruct4.Islem());


            /*new keywordu kullanmadan yaparsan bunlara default degererını vermemıs olursun new yazmadan
             * kullanmak için once bunlara bir deger ataman lazım
             */
            MyStruct3 myStruct3;
            myStruct3.x = 3;
            myStruct3.y = true;
            Console.WriteLine($"{myStruct3.x}");
            Console.WriteLine($"{myStruct3.y}");
            Console.WriteLine($"{myStruct3.z}");

            /*struct new keywordu ile kullanılır ise struct içerisindeki fieldlar varsayılan
             * değerleri ile kullanılır.
             */
            MyStruct3 _myStruct3 = new MyStruct3();
            Console.WriteLine($"{_myStruct3.x}");
            Console.WriteLine($"{_myStruct3.y}");
            Console.WriteLine($"{_myStruct3.z}");
        }
    }

    struct MyStruct4
    {
        public int x;
        public bool y;
        public string z { get; set; }

        public double Islem()
        {
            if (y)
            {
                return x * int.Parse(z);
            }
            return -1;
        }
    }
    
    struct MyStruct3
    {
        public int x;
        public bool y;
        public string z;
    }
    
    
    /* bir struct baska bır strcut ya da class kullanılarak miras alamazlar
     * ama interface ler ile miras mekanizması çalışır.
     */
    struct MyStruct1 : IInterface // : MyClass
    {
        int x;
        bool y;

        public void A()
        {
            throw new NotImplementedException();
        }

        public void B()
        {
            throw new NotImplementedException();
        }
    }

    struct MyStruct
    {
        public int a;
        public int b;
    }

    public class MyClass
    {
        public int a;
        public int b;
    }

    interface IInterface
    {
        void A();
        void B();
    }
}