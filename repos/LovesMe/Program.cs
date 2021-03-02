using System;

namespace LovesMe
{
    class Program
    {
        static void Main(string[] args)
        {
            int LoopCounter = 1;
            
            Console.WriteLine("Well here goes nothing...");

            while (LoopCounter <= 17)
            {
                Console.WriteLine("It loves me NOT!");
                Console.WriteLine("It LOVES me!");
                LoopCounter++;
            }

            Console.WriteLine("I knew it! It LOVES me!");
        }
    }
}
