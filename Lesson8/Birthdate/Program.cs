using System;

namespace Birthdate
{
    class Program
    {
        static void Main(string[] args)
        {
            int userBirth;
            Console.WriteLine("Enter you birth year: ");
            userBirth = int.Parse(Console.ReadLine());
            Age(userBirth);

        }
        public static void Age(int birth)
        {
            int Age = 2019 - birth;
            Console.WriteLine($"Your age is {Age}");
        }
    }
}
