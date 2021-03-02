using System;

namespace BestAdderEver
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1, input2, input3;
            int num1, num2, num3;
            int ans;

            while (true)
            {
                Console.Write("Please enter a whole number: ");
                input1 = Console.ReadLine();

                if (int.TryParse(input1, out num1))
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Please enter a valid number!");    
                }
            }

            while (true)
            {
                Console.Write("Please enter another whole number: ");
                input2 = Console.ReadLine();

                if (int.TryParse(input2, out num2))
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Please enter a valid number!");
                }
            }

            while (true)
            {
                Console.Write("Please enter one final whole number: ");
                input3 = Console.ReadLine();

                if (int.TryParse(input3, out num3))
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Please enter a valid number!");
                }
            }

            ans = num1 + num2 + num3;

            Console.Write("{0} + {1} + {2} = ", num1, num2, num3);
            Console.WriteLine("{0}", ans);
        }
    }
}
