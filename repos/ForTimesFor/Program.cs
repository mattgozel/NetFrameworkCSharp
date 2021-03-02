using System;

namespace ForTimesFor
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int num;
            int multi = 1;
            string input2;
            int guess;
            int correct = 0;

            Console.WriteLine("This program will help you with your times tables!");
            Console.Write("Please enter a number: ");
            input = Console.ReadLine();

            if (int.TryParse(input, out num))

                for (int i = 1; i < 16; i++)
                {
                    int ans = multi * num;
                    Console.Write("{0} * {1} is: ", multi, num);
                    input2 = Console.ReadLine();

                    if (int.TryParse(input2, out guess))
                    {

                        if (guess == ans)
                        {
                            Console.WriteLine("Correct!");
                            correct++;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, no, the correct answer is: {0}", ans);
                        }

                        multi++;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid guess!");
                    }
                }
            if (correct <= 7)
            {
                Console.WriteLine("You guessed {0} answer(s) correct, you should study more.", correct);
            }

            else if (correct >= 14)
            {
                Console.WriteLine("Hey there stud, nice job! You got {0} answers correct! Your intellect is only surpassed by your wit.", correct);
            }

            else
            {
                Console.WriteLine("Congratulations! You got {0} answers correct!", correct);
            }
        }
    }
}
