using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factorizor.BLL;

namespace Factorizor.UI
{
    public class ConsoleInput
    {
        public int GetIntFromUser()
        {
            string input;
            int output;

            while (true)
            {
                Console.Write("Please enter the number you would like to factorize: ");
                input = Console.ReadLine();

                if(int.TryParse(input, out output) && output > 0)
                {
                    return output;
                }

                else
                {
                    Console.WriteLine("Please enter a valid, positive, whole number!");
                }
            }


        }
    }

    public class ConsoleOutput
    {
        public void DisplayTitle()
        {
            Console.WriteLine("Welcome to the Better, Testable, Factorizer!\n\n");
            Console.WriteLine("Press any key to start the game...");
            Console.ReadKey();
        }

        public void DisplayFactors()
        {
            PerfectChecker check = new PerfectChecker();
            ConsoleInput input = new ConsoleInput();
            int number = input.GetIntFromUser();

            FactorFinder factor = new FactorFinder();
            string factorContainer = factor.FactorSender(number);
            char[] trimChars = { ',', ' ' };
            Console.WriteLine($"The factors of {number} are: {factorContainer.TrimEnd(trimChars)}");

            PrimeChecker primeCheck = new PrimeChecker();

            if(primeCheck.IsPrimeNumber(number) == true)
            {
                Console.WriteLine($"{number} is a prime number.");
            }

            else
            {
                Console.WriteLine($"{number} is NOT a prime number.");
            }
            
            if(check.IsPerfectNumber(number) == true)
            {
                Console.WriteLine($"{number} is a perfect number.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine($"{number} is NOT a perfect number.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }

    public class Workflow
    {
        public void Start()
        {
            ConsoleOutput title = new ConsoleOutput();
            title.DisplayTitle();

            title.DisplayFactors();
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Workflow start = new Workflow();
            start.Start();
        }
    }
}
