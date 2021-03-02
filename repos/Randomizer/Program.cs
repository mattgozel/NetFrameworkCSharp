using System;

namespace Randomizer
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomizer = new Random();
            int x = randomizer.Next(10);
                       
            if (x == 0)
            {
                Console.WriteLine("Those aren’t the droids you’re looking for.");
            }
            else if (x == 1)
            {
                Console.WriteLine("Never go in against a Sicilian when death is on the line!");
            }
            else if (x == 2)
            {
                Console.WriteLine("Goonies never say die.");
            }
            else if (x == 3)
            {
                Console.WriteLine("With great power there must also come — great responsibility.");
            }
            else if (x == 4)
            {
                Console.WriteLine("Never argue with the data.");
            }
            else if (x == 5)
            {
                Console.WriteLine("Try not. Do, or do not. There is no try.");
            }
            else if (x == 6)
            {
                Console.WriteLine("You are a leaf on the wind, watch how you soar.");
            }
            else if (x == 7)
            {
                Console.WriteLine("Do absolutely nothing, and it will be everything that you thought it could be.");
            }
            else if (x == 8)
            {
                Console.WriteLine("Kneel before Zod.");
            }
            else if (x == 9)
            {
                Console.WriteLine("Make it so.");
            }
        }
    }
}
