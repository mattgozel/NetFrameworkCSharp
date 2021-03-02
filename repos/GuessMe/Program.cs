using System;

namespace GuessMe
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int answer;
            string input;
            int guess;
            int guessCounter = 0;

            Console.WriteLine("We are about to play a game where you guess a number that the computer has picked at random.");
            Console.Write("What is your name? ");
            name = Console.ReadLine();

            while (true)
            {
                string input1;
                int mode;

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"{name}, please select your mode:");
                Console.WriteLine("1. Easy Mode");
                Console.WriteLine("2. Normal Mode");
                Console.WriteLine("3. Hard Mode");
                Console.Write("Enter your number: ");

                input1 = Console.ReadLine();

                if (int.TryParse(input1, out mode))
                {
                    if (mode == 1)
                    {
                        EasyMode();
                        break;
                    }

                    else if (mode == 2)
                    {
                        NormalMode();
                        break;
                    }

                    else if (mode == 3)
                    {
                        HardMode();
                        break;
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{name}, please enter a number between 1 and 3!");
                    }
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{name}, please enter a valid number!");
                }
            }
            
            void NormalMode()
            {
                Random rng = new Random();
                answer = rng.Next(1, 21);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{name}, you have selected normal mode!");

                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("Please guess a number bewtween 1 and 20 (Enter Q at any time to quit): ");
                    input = Console.ReadLine();

                    if (int.TryParse(input, out guess))
                    {
                        if (guess < 1 || guess > 20)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"{name}, please enter a number between 1 and 20!");
                        }

                        else if (guess == answer)
                        {
                            guessCounter++;

                            if (guessCounter == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Holy calamity, scream insanity! {name}! You guessed it with only {guessCounter} guess!");
                                Console.ReadLine();
                                break;
                            }

                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Congratulations, {name}! You guessed {answer} which was the correct answer! It took you {guessCounter} guesses!");
                                Console.ReadLine();
                                break;
                            }
                        }

                        else if (guess > answer)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($"Ha! Nice try, {name}! Too high! Guess a lower number.");
                            guessCounter++;
                        }

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($"NOPE! Too low, {name}! Guess a higher number!");
                            guessCounter++;
                        }
                    }

                    else if (input == "Q")
                    {
                        break;
                    }


                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{name}, you did not enter a number, please try again.");
                    }
                }
            }

            void EasyMode()
            {
                Random rng = new Random();
                answer = rng.Next(1, 6);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{name}, you have selected easy mode!");

                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("Please guess a number bewtween 1 and 5 (Enter Q at any time to quit): ");
                    input = Console.ReadLine();

                    if (int.TryParse(input, out guess))
                    {
                        if (guess < 1 || guess > 5)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"{name}, please enter a number between 1 and 5!");
                        }

                        else if (guess == answer)
                        {
                            guessCounter++;

                            if (guessCounter == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Holy calamity, scream insanity! {name}! You guessed it with only {guessCounter} guess!");
                                Console.ReadLine();
                                break;
                            }

                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Congratulations, {name}! You guessed {answer} which was the correct answer! It took you {guessCounter} guesses!");
                                Console.ReadLine();
                                break;
                            }
                        }

                        else if (guess > answer)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($"Ha! Nice try, {name}! Too high! Guess a lower number.");
                            guessCounter++;
                        }

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($"NOPE! Too low, {name}! Guess a higher number!");
                            guessCounter++;
                        }
                    }

                    else if (input == "Q")
                    {
                        break;
                    }


                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{name}, you did not enter a number, please try again.");
                    }
                }
            }

            void HardMode()
            {
                Random rng = new Random();
                answer = rng.Next(1, 51);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{name}, you have selected hard mode!");

                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("Please guess a number bewtween 1 and 50 (Enter Q at any time to quit): ");
                    input = Console.ReadLine();

                    if (int.TryParse(input, out guess))
                    {
                        if (guess < 1 || guess > 50)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"{name}, please enter a number between 1 and 50!");
                        }

                        else if (guess == answer)
                        {
                            guessCounter++;

                            if (guessCounter == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Holy calamity, scream insanity! {name}! You guessed it with only {guessCounter} guess!");
                                Console.ReadLine();
                                break;
                            }

                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Congratulations, {name}! You guessed {answer} which was the correct answer! It took you {guessCounter} guesses!");
                                Console.ReadLine();
                                break;
                            }
                        }

                        else if (guess > answer)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($"Ha! Nice try, {name}! Too high! Guess a lower number.");
                            guessCounter++;
                        }

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($"NOPE! Too low, {name}! Guess a higher number!");
                            guessCounter++;
                        }
                    }

                    else if (input == "Q")
                    {
                        break;
                    }


                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{name}, you did not enter a number, please try again.");
                    }
                }
            }
        }
    }
}
