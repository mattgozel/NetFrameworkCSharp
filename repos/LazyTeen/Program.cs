using System;

namespace LazyTeen
{
    class Program
    {
        static void Main(string[] args)
        {
            int teen = 0;
            int pct;
            int loop = 1;

            Random rng = new Random();
            pct = rng.Next(1, 101);

            do
            {
                Console.WriteLine("Clean your room! (x{0})", loop);
                loop++;
                teen += 5;
                
                if (teen >= pct)
                {
                    Console.WriteLine("FINE! I'LL CLEAN MY ROOM. BUT I REFUSE TO EAT MY PEAS.");
                    break;
                }

                if (loop == 16)
                {
                    Console.WriteLine("Clean your room!! That's IT, I'm doing it!!! YOU'RE GROUNDED AND I'M TAKING YOUR XBOX!");
                    break;
                }
            } while (true);
            
        }
    }
}
