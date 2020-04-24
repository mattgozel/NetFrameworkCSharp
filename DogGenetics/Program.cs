using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogGenetics
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            Random rng = new Random();
            int bern = rng.Next(1, 51);
            int chi = rng.Next(1, 21);
            int pug = rng.Next(1, 21);
            int cur = rng.Next(1, 10);
            int doberman = 100 - bern - chi - pug - cur;

            while (true)
            {
                Console.Write("What is your dogs name? ");
                name = Console.ReadLine();

                if (string.IsNullOrEmpty(name))
                {
                    continue;
                }

                else
                {
                    break;
                }
            }

            Console.WriteLine($"Well then, I have this highly reliable report on {name}'s prestigious background right here.");
            Console.WriteLine($"\n{name} is:");

            Console.WriteLine($"\n{bern}% St. Bernard");
            Console.WriteLine($"{chi}% Chihuahua");
            Console.WriteLine($"{pug}% Pug");
            Console.WriteLine($"{cur}% Common Cur");
            Console.WriteLine($"{doberman}% King Doberman");

            Console.WriteLine("\nWow, that's QUITE the dog!");

            Console.ReadLine();

        }
    }
}
