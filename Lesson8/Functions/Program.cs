using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {


            // DRY
            //do not
            //repeat
            //yourself

            int a = 5;
            int b = 5;
            int c = a + b;
            Console.WriteLine($"Result from Main: {c}");
            Sum(a, b);
            Sum(10, 20);
            Hello();
            GreetByName("Britta");




        }
        // static - ei pea olema objekt
        public static void Sum(int x, int y)
        {
            Console.WriteLine($"Result from function: {x + y}");
        }

        public static void Hello()
        {
            Console.WriteLine("Hello!");
        }
        public static void GreetByName(string name)
        {
            Console.WriteLine($"Hello {name}");
        }




    }
}
