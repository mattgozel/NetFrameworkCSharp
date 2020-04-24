using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1;
            int rounds;

            string inputRPS;
            int userRPS;

            int win = 0;
            int loss = 0;
            int tie = 0;
            int roundCounter = 0;

            string tryAgain;

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("We are going to play Rock, Paper, Scissors!");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("How man rounds would like to play? (1-10) ");
                input1 = Console.ReadLine();

                if (int.TryParse(input1, out rounds))
                {
                    if (rounds > 0 && rounds < 11)
                    {

                        rps();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Would you like to play again? (Y/N)");
                        tryAgain = Console.ReadLine();

                        if (string.IsNullOrEmpty(tryAgain))
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("Thank you for playing! Good bye!");
                            Console.ReadLine();
                            break;
                        }
                        
                        else if (tryAgain[0] == 'Y')
                        {
                            win = 0;
                            loss = 0;
                            tie = 0;
                            roundCounter = 0;
                            continue;
                        }

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("Thank you for playing!");
                            Console.ReadLine();
                            break;
                        }

                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your selection is not in range! Good bye!");
                        Console.ReadLine();
                        break;
                    }
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your selection is not in range! Good bye!");
                    Console.ReadLine();
                    break;
                }
            }

            void rps()
            {
                while (roundCounter < rounds)
                {
                    Random rng = new Random();
                    int comp = rng.Next(1, 4);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Please enter your choice:");
                    Console.WriteLine("1. Rock");
                    Console.WriteLine("2. Paper");
                    Console.WriteLine("3. Scissors");
                    Console.Write("Enter your choice: ");
                    inputRPS = Console.ReadLine();

                    if(int.TryParse(inputRPS, out userRPS))
                    {
                        if (userRPS < 1 || userRPS > 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You did not select a valid number, please try again!");
                        }

                        else if (userRPS == comp)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("You both picked the same weapon! Tie!");
                            tie++;
                            roundCounter++;
                        }

                        else if (userRPS == 1  && comp ==2)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("You picked rock and the computer picked paper. You lose!");
                            loss++;
                            roundCounter++;
                        }

                        else if (userRPS == 1 && comp == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You picked rock and the computer picked scissors. You win!");
                            win++;
                            roundCounter++;
                        }

                        else if (userRPS == 2 && comp == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You picked paper and the computer picked rock. You win!");
                            win++;
                            roundCounter++;
                        }

                        else if (userRPS == 2 && comp == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("You picked paper and the computer picked scissors. You lose!");
                            loss++;
                            roundCounter++;
                        }

                        else if (userRPS == 3 && comp == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("You picked scissors and the computer picked rock. You lose!");
                            loss++;
                            roundCounter++;
                        }

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You picked scissors and the computer picked paper. You win!");
                            win++;
                            roundCounter++;
                        }
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You did not enter a number!");
                    }

                }

                if (win > loss)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nCongratulations you won! You had {win} wins, {loss} losses and {tie} ties.");
                }

                else if (loss > win)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"\nYou lost! You had {win} wins, {loss} losses and {tie} ties.");
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"\nYou tied! You had {win} wins, {loss} losses and {tie} ties.");
                }
            }



        }
    }
}
