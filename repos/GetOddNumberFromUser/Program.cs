using System;

namespace GuessingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer;
            string input;
            int guess;

            Random rng = new Random();
            answer = rng.Next(1, 21);

            while(true)
            {
                Console.Write("Enter a guess from 1 to 20: ");
                input = Console.ReadLine();

            if (int.TryParse(input, out guess))
            {
                if (guess == answer)
                {
                    break;
                }
                if (guess < 1 || guess > 20)
                {
                    Console.WriteLine("Your guess should be between 1 and 20.");
                    continue;
                }
                if (guess > answer)
                {
                    Console.WriteLine("Lower!");
                    continue;
                }

                    Console.WriteLine("Higher!");
            }
            else
            {
                Console.WriteLine("You did not enter a valid number, please try again!");
                continue;
            }

            
            }
        Console.WriteLine("You got it the answer was {0}.", answer);
        Console.WriteLine("Press any key to quit...");
        Console.ReadKey();
        }
    }
}
