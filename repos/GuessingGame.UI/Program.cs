using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessingGame.BLL;

namespace GuessingGame.UI
{
    public class ConsoleInput
    {
        public static int GetGuessFromUser()
        {
            Console.Clear();
            int output;
            string input;

            while(true)
            {
                Console.Write("Enter a guess between 1 and 20: ");
                input = Console.ReadLine();
                
                if(int.TryParse(input, out output))
                {
                    return output;
                }

                else
                {
                    Console.WriteLine("That was not a valid number! Press any key to continue...");
                    Console.ReadKey();
                }
            }
        }
    }

    public class ConsoleOutput
    {
        public static void DisplayTitle()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Better, Testable, Guessing Game!\n\n");
            Console.WriteLine("Press any key to start the game...");
            Console.ReadKey();
        }

        public static void DisplayGuessMessage(GuessResult result)
        {
            switch (result)
            {
                case GuessResult.Invalid:
                    DisplayInvalid();
                    break;
                case GuessResult.Higher:
                    DisplayHigher();
                    break;
                case GuessResult.Lower:
                    DisplayLower();
                    break;
                case GuessResult.Victory:
                    DisplayVictory();
                    break;
            }
        }

        private static void DisplayVictory()
        {
            Console.WriteLine("You did it! You are awesome!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static void DisplayLower()
        {
            Console.WriteLine("Your guess was too high, try something lower.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static void DisplayHigher()
        {
            Console.WriteLine("Your guess was too low, try something higher.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static void DisplayInvalid()
        {
            Console.WriteLine("That guess wan't valid, try something between 1 and 20.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }

    public class GameFlow
    {
        GameManager _manager;

        public void PlayGame()
        {
            CreateGameManagerInstance();
            ConsoleOutput.DisplayTitle();

            GuessResult result;
            int guess;

            do
            {
                guess = ConsoleInput.GetGuessFromUser();
                result = _manager.ProcessGuess(guess);
                ConsoleOutput.DisplayGuessMessage(result);
            } while (result != GuessResult.Victory);
        }

        private void CreateGameManagerInstance()
        {
            _manager = new GameManager();
            _manager.Start();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GameFlow game = new GameFlow();
            game.PlayGame();
        }
    }
}
