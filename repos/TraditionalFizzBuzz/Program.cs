using System;

namespace TraditionalFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int num;
            int fizzCounter = 0;
            int buzzCounter = 0;
            int fizzBuzzCounter = 0;

            while(true)
            {
                Console.Write("How many units fizzing and buzzing do you need in your life? ");
                input = Console.ReadLine();
                if (int.TryParse(input, out num))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You did not enter a valid number. Please try again!");
                }
            }

            for (int i = 0; i <= num; i++)
            {
                if (i != 0 && i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizz buzz");
                    fizzBuzzCounter++;
                }
                else if (i != 0 && i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                    fizzCounter++;
                }
                else if (i != 0 && i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                    buzzCounter++;
                }
                else
                {
                    Console.WriteLine("{0}", i);
                }
            }

            Console.WriteLine("You this many fizzes: {0}, this many buzzes: {1} and this many fizz buzzes: {2}", fizzCounter, buzzCounter, fizzBuzzCounter);
            Console.WriteLine("TRADITION!!!!!");

        }
    }
}
