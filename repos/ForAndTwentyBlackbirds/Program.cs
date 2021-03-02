using System;

namespace ForAndTwentyBlackbirds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("It's Spring...!");
            for (int i = 1; i < 11; i++)
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine("\nOh no, it's fall...");
            for (int i = 10; i > 0; i--)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
        }
    }
}
