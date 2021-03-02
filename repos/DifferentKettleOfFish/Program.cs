using System;

namespace DifferentKettleOfFish
{
    class Program
    {
        static void Main(string[] args)
        {
            int fish = 1;

            for (int i = fish; fish < 11; fish++)
            {
                if (fish == 3)
                {
                    Console.WriteLine("RED fish!");
                }
                else if (fish == 4)
                {
                    Console.WriteLine("BLUE fish!");
                }
                else
                {
                    Console.WriteLine(fish + " fish!");
                }

                
            }
        }
    }
}
