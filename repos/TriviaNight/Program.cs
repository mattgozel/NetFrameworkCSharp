using System;

namespace TriviaNight
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1, input2, input3;
            int guess1, guess2, guess3;
            int x = 0;

            Console.WriteLine("It's Trivia Night! Are you ready?");
            Console.WriteLine();

            while(true)
            {
                Console.WriteLine("Who is the greatest band?");
                Console.WriteLine("1. Propagandhi");
                Console.WriteLine("2. Dire Straits");
                Console.WriteLine("3. Bright Eyes");
                Console.WriteLine("4. ACDC");
                input1 = Console.ReadLine();

                if (int.TryParse(input1, out guess1))
                {
                    if (guess1 == 1)
                    {
                        Console.WriteLine("Correct!");
                        x++;
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Incorrect!");
                        break;
                    }
                }
            }
            
            while (true)
            {
                Console.WriteLine("What is the best food?");
                Console.WriteLine("1. Pasta");
                Console.WriteLine("2. Chips");
                Console.WriteLine("3. Pizza");
                Console.WriteLine("4. Junior Mints");
                input2 = Console.ReadLine();

                if (int.TryParse(input2, out guess2))
                {
                    if (guess2 == 3)
                    {
                        Console.WriteLine("Correct!");
                        x++;
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Incorrect!");
                        break;
                    }
                }
            }

            while (true)
            {
                Console.WriteLine("What is the best movie?");
                Console.WriteLine("1. Armageddon");
                Console.WriteLine("2. Citizen Kane");
                Console.WriteLine("3. Meatballs");
                Console.WriteLine("4. Sideways");
                input3 = Console.ReadLine();

                if (int.TryParse(input3, out guess3))
                {
                    if (guess3 == 4)
                    {
                        Console.WriteLine("Correct!");
                        x++;
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Incorrect!");
                        break;
                    }
                }
            }

            if (x == 0)
            {
                Console.WriteLine("You got {0} questions correct. You know nothing of how to live beautifully.", x);
            }

            else if (x == 3)
            {
                Console.WriteLine("You got {0} answers correct! You are a person of culture and sophistication.", x);
            }

            else
            {
                Console.WriteLine("Congratulations, you got {0} answer(s) correct!", x);
            }
        }
    }
}
