using System;

namespace HighRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Random diceRoller = new Random();

            string input;
            int x;
           
            while(true)
            {
                Console.WriteLine("TIME TO ROOOOOOLL THE DICE!");
                Console.WriteLine();
                Console.WriteLine("How many sides does your dice have?");
                input = Console.ReadLine();

                if (int.TryParse(input, out x))
                {
                    int rollResult = diceRoller.Next(x) + 1;

                    if (rollResult == 1)
                    {
                        Console.WriteLine("You rolled a critical failure!");
                    }

                    else if (rollResult == x)
                    {
                        Console.WriteLine("You rolled a critical! Nice Job!");
                    }

                    else
                    {
                        Console.WriteLine("I rolled a " + rollResult);
                    }
                }
            }
        }
    }
}
