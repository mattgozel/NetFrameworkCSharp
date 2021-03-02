using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HiddenNuts
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] hidingSpots = new string[100];
            Random squirrel = new Random();
            hidingSpots[squirrel.Next(0, hidingSpots.Length)] = "Nut";
            Console.WriteLine("The nut has been hidden ...");

            int index = Array.IndexOf(hidingSpots, "Nut");

            Console.WriteLine($"Found it! It's in spot #{index}");           
        }
    }
}
