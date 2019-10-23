using System;

namespace MyFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            //KnowMe("Britta", "yellow");

            string name;
            string color;
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Please enter yout favourite color: ");
            color = Console.ReadLine();
            KnowMe(name, color);


        }

        public static void KnowMe(string name, string color)
        {
            Console.WriteLine($"Hello, {name}. Your favourite color is {color}.");
        }
    }
}
