using System;

namespace DoItBetter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1, input2, input3;
            int ans1, ans2, ans3;
            int brag1, brag2, brag3;

            while (true)
            {
                Console.Write("How many miles can you run? ");
                input1 = Console.ReadLine();

                if (int.TryParse(input1, out ans1))
                {
                    brag1 = ans1 * 2 + 1;
                    Console.WriteLine("Pshhh, I can run {0} miles.", brag1);
                    break;
                }

                else
                {
                    Console.WriteLine("You did not answer with a valid number!");
                }
            }

            while (true)
            {
                Console.Write("How many hot dogs can you eat? ");
                input2 = Console.ReadLine();

                if (int.TryParse(input2, out ans2))
                {
                    brag2 = ans2 * 2 + 1;
                    Console.WriteLine("Every day I'm eating more and more hot dogs. I can eat {0}.", brag2);
                    break;
                }

                else
                {
                    Console.WriteLine("You did not answer with a valid number!");
                }
            }

            while (true)
            {
                Console.Write("How many languages can you speak? ");
                input3 = Console.ReadLine();

                if (int.TryParse(input3, out ans3))
                {
                    brag3 = ans3 * 2 + 1;
                    Console.WriteLine("Oh yeah? Well, I can speak {0} languages.", brag3);
                    break;
                }

                else
                {
                    Console.WriteLine("You did not answer with a valid number!");
                }
            }

        }
    }
}
