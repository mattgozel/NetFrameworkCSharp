using System;

namespace AllAboutMe
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, food, whistle;
            int pets;
            bool gnocchi;

            name = "Matty Humble";
            food = "Pizza";
            pets = 5;
            gnocchi = true;
            whistle = "never";

            Console.WriteLine("My name is " + name + ".");
            Console.WriteLine("My favorite food is " + food + ".");
            Console.WriteLine("I have " + pets + " pets.");
            Console.WriteLine("It is " + gnocchi + " that I have eaten gnocchi.");
            Console.WriteLine("I " + whistle + " learned to whistle.");
        }
    }
}
