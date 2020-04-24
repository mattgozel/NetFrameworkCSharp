using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyHearts
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1;
            double ans1;
            double heart;
            double minHeart, maxHeart;

            while (true)
            {
                Console.Write("What is your age? ");
                input1 = Console.ReadLine();

                if (double.TryParse(input1, out ans1))
                {
                    heart = 220 - ans1;
                    Console.WriteLine($"Your maximum heart rate should be {heart} beats per minute.");

                    minHeart = heart * .50;
                    maxHeart = heart * .85;

                    Console.WriteLine($"Your target HR zone is {minHeart} - {maxHeart} beats per minute.");
                    Console.ReadLine();

                    break;
                }

                else
                {
                    Console.WriteLine("You did not enter a valid age, please try again!");
                }
            }
        }
    }
}
