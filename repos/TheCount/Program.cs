using System;

namespace TheCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1;
            string input2;
            string input3;
            int start;
            int stop;
            int count;
            int loopCounter = 0;

            Console.WriteLine("*** I LOVE TO COUNT! LET ME SHARE MY COUNTING WITH YOU! ***");
            while (true)
            {
                Console.Write("Start at: ");
                input1 = Console.ReadLine();

                if (int.TryParse(input1, out start))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please try again with a valid number!");
                }
            }

            while (true)
            {
                Console.Write("Stop at: ");
                input2 = Console.ReadLine();
                if (int.TryParse(input2, out stop))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please try again with a valid number!");
                }
            }

            while (true)
            {
                Console.Write("Count by: ");
                input3 = Console.ReadLine();
                if (int.TryParse(input3, out count))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please try again with a valid number!");
                }
            }
                        
                            for (int i = start; i <= stop; i += count)
                            {
                                Console.Write("{0} ", i);
                                loopCounter++;

                                if (loopCounter == 3)
                                {
                                    Console.Write(" - Ah ah ah!");
                                    Console.WriteLine();
                                    loopCounter = 0;
                                }
                            }
            Console.ReadLine();
        }
    }
}
