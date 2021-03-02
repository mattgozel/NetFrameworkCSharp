using System;

namespace PassingTheTuringTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, color, food, num;
            int num2;

            while (true)
            {
                Console.Write("Whata is your name? ");
                name = Console.ReadLine();

                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("You did not enter anything!");
                }

                else
                {
                    break;
                }
            }

            Console.WriteLine("Hello {0}! It is nice to meet you. My name is T-1000.", name);
            
            while (true)
            {
                Console.Write("What is your favorite color? ");
                color = Console.ReadLine();

                if (string.IsNullOrEmpty(color))
                {
                    Console.WriteLine("You did not enter anything!");
                }

                else
                {
                    break;
                }
            }

            Console.WriteLine("{0} is a beautiful color!", color);

            while (true)
            {
                Console.Write("What is your favorite food? ");
                food = Console.ReadLine();

                if (string.IsNullOrEmpty(food))
                {
                    Console.WriteLine("You did not enter anything!");
                }

                else
                {
                    break;
                }
            }

            while (true)
            {
                Console.Write("What is your favorite number? ");
                num = Console.ReadLine();

                if (int.TryParse(num, out num2))
                {
                    break;
                }

                else
                {
                    Console.WriteLine("You did not enter a valid number!");
                }
            }

            Console.WriteLine("Interesting! {0} and {1} are both great choices! You are a person of culture!", food, num2);
            Console.WriteLine("Goodbye!");
        }
    }
}
