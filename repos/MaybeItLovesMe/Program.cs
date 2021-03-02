using System;

namespace MaybeItLovesMe
{
    class Program
    {
        static void Main(string[] args)
        {
            int LoopCounter = 1;
            int petal;
            Random rng = new Random();
            petal = rng.Next(13, 90);

            Console.WriteLine("Well here goes nothing...");


            while(LoopCounter <= petal)
            {
                if (LoopCounter % 2 == 1)
                {
                    Console.WriteLine("It LOVES me!");
                    LoopCounter++;
                }
                else
                {
                    Console.WriteLine("It loves me NOT!");
                    LoopCounter++;
                }
            }

            
            if (LoopCounter % 2 == 1)
            {
                Console.WriteLine("Oh, wow! It really LOVES me!");
            }
            else
            {
                Console.WriteLine("Awwww, bummer.");
            }
        }
    }
}
