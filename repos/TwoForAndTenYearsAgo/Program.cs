using System;

namespace TwoForAndTenYearsAgo
{
    class Program
    {
        static void Main(string[] args)
        {
            string guess;
            int year;

            while (true)
            {
                Console.WriteLine("What year would you like to count back from? ");
                guess = Console.ReadLine();

                if(int.TryParse(guess, out year))
                {
                    break;
                }

                Console.WriteLine("You did not enter a valid year. Please try again.");
            }
            


            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine(i + " years ago would be " + (year - i));
            }

            Console.WriteLine("\nI can count backwards using a different way too...");

            for (int i = year; i >= year - 20; i--)
            {
                Console.WriteLine((year - i) + " years ago would be " + i);
            }
        }
    }
}
