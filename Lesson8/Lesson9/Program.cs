using System;

namespace Lesson9
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your gender?");
            string gender = Console.ReadLine();
            Console.WriteLine("Are you coming or leaving?");
            string answer = Console.ReadLine();
            Console.WriteLine("What is your year of birth?");
            int birth = int.Parse(Console.ReadLine());

            if (answer.ToLower() == "coming")
            {
                Coming(gender, birth);
            }
            else if (answer.ToLower() == "leaving")
            {
                Leaving(gender, birth);
            }
            else
            {
                Console.WriteLine("Dont be rude!");
            }

        }



        public static void Coming(string sex, int birth) //muutuja lisaväärtus
        {

            if(sex == "male")
            {
                int Age = 2019 - birth;
                Console.WriteLine($"Hello Sir, your age is {Age}!");
            }
            else 
            {
                int Age = 2019 - birth;
                Console.WriteLine($"Hello Madam, your age is {Age}!");
            }
         
           
        }
        public static void Leaving(string sex, int birth)
        {
            if (sex == "male")
            {
                int Age = 2019 - birth;
                Console.WriteLine($"Goodby Sir, your age is {Age}!");
            }
            else
            {
                int Age = 2019 - birth;
                Console.WriteLine($"Hello Madam, your age is {Age}!");
            }
        }
       
    }

}
