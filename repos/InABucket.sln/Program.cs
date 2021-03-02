using System;

namespace InABucket
{
    class Program
    {
        static void Main(string[] args)
        {
            String walrus;
            double piesEaten;
            float weightOfTeacupPig;
            int grainsOfSand;

            walrus = "Sir Leroy Jenkins III";
            piesEaten = 42.1;
            weightOfTeacupPig = 52;
            grainsOfSand = 2147483647;

            Console.WriteLine("Meet my pet Walrus, " + walrus);
            Console.Write("He was a bit hungry today, and ate this many pies: ");
            Console.WriteLine(piesEaten);
            Console.WriteLine("My teacup pig weighs this man pounds: " + weightOfTeacupPig);
            Console.WriteLine("He ate this many grains of sand: " + grainsOfSand);
        }
    }
}
