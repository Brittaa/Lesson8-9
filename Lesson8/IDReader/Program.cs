using System;

namespace IDReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string id;
            Console.WriteLine("Please enter your ID: ");
            id = Console.ReadLine();

            bool idValid; //bool kui kaks valikut

            idValid = CheckIDLenght(id);

            if (idValid) //sama mis isValid == true
            {
                GetGender(id);
                GetYear(id);
            }
            else
            {
                Console.WriteLine("Not OK!");
            }
            


           
        }
        public static void GetGender(string idCode)
        {
            int firstNumber = int.Parse(idCode[0].ToString());
            if (firstNumber == 4 || firstNumber == 6 || firstNumber == 2)
            {
                Console.WriteLine("Hello, Madam!");
            }
            else 
            {
                Console.WriteLine("Hello, Sir!");
            }
        }
        public static bool CheckIDLenght(string idCode)
        {
            bool isValid;
            if (idCode.Length == 11)
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }
            return isValid;

        }
        public static void GetYear (string idCode)
        {
            int firstNumber = int.Parse(idCode[0].ToString());
            if (firstNumber == 1 || firstNumber == 2)
            {
                string year = idCode.Substring(1, 2);
                string fullyear = $"18{year}";
                Console.WriteLine($"Your birthyear is {fullyear}.");
            }
            else if (firstNumber == 3 || firstNumber == 4)
            {
                string year = idCode.Substring(1, 2);
                string fullyear = $"19{year}";
                Console.WriteLine($"Your birthyear is {fullyear}.");
            }
            else //(firstNumber == 5 || firstNumber == 6)
            {
                string year = idCode.Substring(1, 2);
                string fullyear = $"20{year}";
                Console.WriteLine($"Your birthyear is {fullyear}.");
            }
        }
    }
}
