using System;

namespace SpaceCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string userSentence;
            Console.WriteLine("Enter your sentence: ");
            userSentence = Console.ReadLine();
            CountSpace(userSentence); 
        }
        public static void CountSpace(string sentence)
        {
            int counter = 0;
            foreach(char symbol in sentence)
            {
                if (symbol == ' ')
                {
                    counter++;

                }
            }
            Console.WriteLine($"There are {counter} speces in your sentence.");
        }

    }
}
