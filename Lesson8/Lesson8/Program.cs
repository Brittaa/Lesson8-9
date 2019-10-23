using System;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            //TASK 1 - Write a program to count how many numbers between 1 and 100 are divisibly by 3 with no remainder.
            // Display the numbers and the count on the console.


            /*Console.WriteLine("Hello World!");

           

            int counter = 0;


            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                    counter++;
                }
                

            }
            Console.WriteLine($"TOTAL {counter}");



            Console.ReadLine();*/


            //TASK 2 - Write a program that picks a random number between 1 to 10.
            // Give the user 4 chances to guess the number. If the user guesses the number, display "You won!";
            // otherwise, display "You lost!"


            int userNumber;
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 11);
            bool gameOver = false;
            int userChance = 0;

            while (!gameOver)
            {
                Console.WriteLine("Enter number from 1 to 10: ");
                userNumber = int.Parse(Console.ReadLine());

                if (userNumber == randomNumber)
                {
                    Console.WriteLine("You won!");
                    gameOver = true;
                }
                else
                {
                    Console.WriteLine("Try again!");
                    userChance++;
                }
                if (userChance == 4)
                {
                    Console.WriteLine("Ups! You lost!");
                    Console.WriteLine($"The number you tried to guess was {randomNumber}");
                    gameOver = true;
                    
                }
            }


            Console.ReadLine();


            }
        }
}
