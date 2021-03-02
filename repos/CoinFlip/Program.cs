using System;

namespace CoinFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            Random rng = new Random();
            x = rng.Next(1, 3);

            if (x == 1)
            {
                Console.WriteLine("You flipped heads!");
            }

            else if (x == 2)
            {
                Console.WriteLine("You flipped tails!");
            }
        }
    }
}
