using System;

namespace MiniMadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1, input2, input3, input4, input5, input6, input7, input8, input9, input10;
            int num;

            Console.WriteLine("Please enter the following:");

            while(true)
            {
                Console.Write("Noun: ");
                input1 = Console.ReadLine();

                if(string.IsNullOrEmpty(input1))
                {
                    Console.WriteLine("This cannot be blank!");
                }

                else
                {
                    break;
                }
            }

            while (true)
            {
                Console.Write("Adjective: ");
                input2 = Console.ReadLine();

                if (string.IsNullOrEmpty(input2))
                {
                    Console.WriteLine("This cannot be blank!");
                }

                else
                {
                    break;
                }
            }

            while (true)
            {
                Console.Write("Noun: ");
                input3 = Console.ReadLine();

                if (string.IsNullOrEmpty(input3))
                {
                    Console.WriteLine("This cannot be blank!");
                }

                else
                {
                    break;
                }
            }

            while (true)
            {
                Console.Write("Number: ");
                input4 = Console.ReadLine();

                if (int.TryParse(input4, out num))
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
                Console.Write("Adjective: ");
                input5 = Console.ReadLine();

                if (string.IsNullOrEmpty(input5))
                {
                    Console.WriteLine("This cannot be blank!");
                }

                else
                {
                    break;
                }
            }

            while (true)
            {
                Console.Write("Plural Noun: ");
                input6 = Console.ReadLine();

                if (string.IsNullOrEmpty(input6))
                {
                    Console.WriteLine("This cannot be blank!");
                }

                else
                {
                    break;
                }
            }

            while (true)
            {
                Console.Write("Plural Noun: ");
                input7 = Console.ReadLine();

                if (string.IsNullOrEmpty(input7))
                {
                    Console.WriteLine("This cannot be blank!");
                }

                else
                {
                    break;
                }
            }

            while (true)
            {
                Console.Write("Plural Noun: ");
                input8 = Console.ReadLine();

                if (string.IsNullOrEmpty(input8))
                {
                    Console.WriteLine("This cannot be blank!");
                }

                else
                {
                    break;
                }
            }

            while (true)
            {
                Console.Write("Verb present tense: ");
                input9 = Console.ReadLine();

                if (string.IsNullOrEmpty(input9))
                {
                    Console.WriteLine("This cannot be blank!");
                }

                else
                {
                    break;
                }
            }

            while (true)
            {
                Console.Write("Same verb but past tense: ");
                input10 = Console.ReadLine();

                if (string.IsNullOrEmpty(input10))
                {
                    Console.WriteLine("This cannot be blank!");
                }

                else
                {
                    break;
                }
            }

            Console.WriteLine("{0}: the {1} frontier. These are the voyages of the starship {2}. Its {3}-year mission: to explore strange {4} {5}, to seek out {4} {6} and {4} {7}, to boldly {8} where no one has {9} before.", input1, input2, input3, num, input5, input6, input7, input8, input9, input10);
        }
    }
}
