using System;

namespace AllTheTrivia
{
    class Program
    {
        static void Main(string[] args)
        {
            string guess1, guess2, guess3, guess4;

            while (true)
            {
                Console.Write("1,024 Gigabytes is equal to one what? ");
                guess1 = Console.ReadLine();

                if (string.IsNullOrEmpty(guess1))
                {
                    Console.WriteLine("You did not answer the question!");
                }

                else
                {
                    break;
                }
            }

            while (true)
            {
                Console.Write("In our solar system which is the only planet that rotates clockwise? ");
                guess2 = Console.ReadLine();

                if (string.IsNullOrEmpty(guess2))
                {
                    Console.WriteLine("You did not answer the question!");
                }

                else
                {
                    break;
                }
            }

            while (true)
            {
                Console.Write("The largest volcano ever discovered in our solar system is located on which planet? ");
                guess3 = Console.ReadLine();

                if (string.IsNullOrEmpty(guess3))
                {
                    Console.WriteLine("You did not answer the question!");
                }

                else
                {
                    break;

                }
            }

            while (true)
            {
                Console.Write("What is the most abundant element in the earth's atmosphere? ");
                guess4 = Console.ReadLine();

                if (string.IsNullOrEmpty(guess4))
                {
                    Console.WriteLine("You did not answer the question!");
                }

                else
                {
                    break;

                }
            }

            Console.WriteLine("Wow! 1,024 Gigabytes is a {0}", guess3);
            Console.WriteLine("I didn't know the largest volcano ever discovered was on {0}", guess1);
            Console.WriteLine("That's amazing that {0} is the most abundant element in the atmosphere...", guess2);
            Console.WriteLine("{0} is the only planet that rotates clockwise, neat!", guess4);
        }
    }
}
