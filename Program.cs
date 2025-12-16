using System;

namespace DigitAlphabetCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int digitCount = 0;
            int alphabetCount = 0;

            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            foreach (char ch in input)
            {
                if (char.IsDigit(ch))
                {
                    digitCount++;
                }
                else if (char.IsLetter(ch))
                {
                    alphabetCount++;
                }
            }

            Console.WriteLine("Number of Alphabets: " + alphabetCount);
            Console.WriteLine("Number of Digits: " + digitCount);

            Console.ReadLine(); // Keeps console open
        }
    }
}
